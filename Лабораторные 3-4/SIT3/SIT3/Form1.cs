using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SiTLab3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showWarning(String warningMeessage)
        {
            MessageBox.Show(warningMeessage, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void showError(String errorMessage)
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (IPToField.Text == "")
            {
                showWarning("Введите IP адрес");
                return;
            }

            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);

                byte[] icmpData = new byte[1024];
                int bytes;

                IPAddress ipFrom = IPAddress.Parse(IPToField.Text);
                IPAddress ipTo = IPAddress.Parse(IPToField.Text);

                ICMPPackage icmp = new ICMPPackage();
                icmp.type = (byte)Convert.ToInt32(TypeField.Text);
                icmp.code = (byte)Convert.ToInt32(CodeField.Text);
                icmp.checksum = 0;

                IPEndPoint ipEndPoint = new IPEndPoint(ipFrom, 0);
                EndPoint endPoint = (EndPoint)ipEndPoint; // сетевой адрес

                // Отправка сообщения
                icmpData = Encoding.ASCII.GetBytes(InputField.Text);
                Buffer.BlockCopy(icmpData, 0, icmp.message, 4, icmpData.Length); // помещаем в message сообщение (4 байта оставляем для ICMP-заголовка)
                icmp.size = icmpData.Length + 4;
                int sizePacket = icmp.size + 4; // 4 байта резервных
                UInt16 checksum = icmp.getChecksum(); // хэш - сумма
                icmp.checksum = checksum;
                socket.SendTo(icmp.getData(), sizePacket, SocketFlags.None, ipEndPoint);

                // Приём сообщения
                icmpData = new byte[1024];
                bytes = socket.ReceiveFrom(icmpData, ref endPoint); // количество считанных байтов (принимаем данные в буфер данных и сохраняем конечную точку)
                ICMPPackage response = new ICMPPackage(icmpData, bytes);
                OutputField.Text += "Ответ от: " + endPoint.ToString() + "\n";

                string result = Encoding.ASCII.GetString(response.message, 4, response.size - 4); // декодируем данные (4 байта резервных)
                OutputField.Text += "Отправленное сообщение: " + result + "\n\n";

                socket.Close();
            }
            catch (SocketException exc)
            {
                showError(exc.Message);
            }
            catch (FormatException exc)
            {
                showError(exc.Message);
            }
        }
    }

    public class ICMPPackage
    {
        public byte type;
        public byte code;
        public UInt16 checksum;
        public int size;
        public byte[] message = new byte[1024];

        public ICMPPackage()
        {}

        public ICMPPackage(byte[] data, int size)
        {
            // 0 - 19 - байты для IP-заголовка
            type = data[20]; // тип
            code = data[21]; // код
            checksum = BitConverter.ToUInt16(data, 22); // хэш - сумма
            this.size = size - 24; // 20 байтов IP-заголовка, 4 байта ICMP-заголовка
            Buffer.BlockCopy(data, 24, message, 0, this.size);
        }

        public byte[] getData()
        {
            // помещаем данные в buffer[]
            byte[] icmpData = new byte[size + 8];
            Buffer.BlockCopy(BitConverter.GetBytes(type), 0, icmpData, 0, 1); // тип
            Buffer.BlockCopy(BitConverter.GetBytes(code), 0, icmpData, 1, 1);  // код
            Buffer.BlockCopy(BitConverter.GetBytes(checksum), 0, icmpData, 2, 2); // хэш - сумма
            Buffer.BlockCopy(message, 0, icmpData, 4, size); // сообщение
            return icmpData;
        }

        // контрольная сумма
        public UInt16 getChecksum()
        {
            UInt32 retVal = 0;
            byte[] buffer = getData();
            int sizePacket = size + 8;
            int index = 0;

            while (index < sizePacket)
            {
                if (index + 1 == sizePacket)
                {
                    retVal += buffer[index];
                    break;
                }
                else
                {
                    retVal += Convert.ToUInt32(BitConverter.ToUInt16(buffer, index));
                    index += sizeof(short);
                }
            }
            retVal = (retVal >> 16) + (retVal & 0xffff);
            retVal += (retVal >> 16);

            return (UInt16) (~retVal);
        }
    }
}
