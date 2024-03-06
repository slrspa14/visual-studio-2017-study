using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP_client_study
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 4)
            {
                Console.WriteLine("사용법 :{0} <Bind IP> <Bind Port> <Server IP> <Message>",
                    Process.GetCurrentProcess().ProcessName);
                return;
            }
            string bindIp = args[0];
            int bindport = Convert.ToInt32(args[1]);
            string serverip = args[2];
            const int serverport = 5425;
            string message = args[3];
            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindport);
                IPEndPoint serveraddress = new IPEndPoint(IPAddress.Parse(serverip), serverport);

                Console.WriteLine("클라이언트 : {0}, 서버 : {1}", clientAddress.ToString(), serveraddress.ToString());

                TcpClient client = new TcpClient(clientAddress);

                client.Connect(serveraddress);

                byte[] data = System.Text.Encoding.Default.GetBytes(message);
                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                Console.WriteLine("송신 : {0}", message);

                data = new byte[256];

                string responseData = "";

                int bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);
                Console.WriteLine("수신 : {0}", responseData);

                stream.Close();
                client.Close();
            }
            catch(SocketException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("클라이언트 종료");
        }
    }
}
