using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP_server_study
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("사용법 :{0} <Bind IP>", Process.GetCurrentProcess().ProcessName);
                return;
            }
            string bindIP = args[0];//ip
            const int bindPort = 5425;//포트번호 상수
            TcpListener server = null;//서버 객체 생성
            try
            {
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bindIP), bindPort);// ip,port할당
                server = new TcpListener(localAddress);
                server.Start();//서버시작

                //accept
                Console.WriteLine("에코서버 시작");
                while(true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("클라이언트 접속 : {0}", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

                    NetworkStream stream = client.GetStream();

                    int length;
                    string data = null;
                    byte[] bytes = new byte[256];
                    while((length = stream.Read(bytes, 0, bytes.Length))!=0)//받은 데이터, , 데이터 길이
                    {
                        data = Encoding.Default.GetString(bytes, 0, length);//인코딩
                        Console.WriteLine("수신 : {0}", data);

                        byte[] msg = Encoding.Default.GetBytes(data); //에코서버라서 받은거 바로 보내주려고 담고

                        stream.Write(msg, 0, msg.Length);//보낼 데이터, , 데이터 길이전송
                        Console.WriteLine("송신 : {0}", data);
                    }
                    //연결종료
                    stream.Close();
                    client.Close();
                }
            }
            catch(SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                server.Stop();//연결요청 수신대기 종료
            }
            Console.WriteLine("섭종");
        }
    }
}
