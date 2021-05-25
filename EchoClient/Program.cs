using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var msg = Console.ReadLine();

            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sock.Connect("127.0.0.1", 7788);    //주소와 포트로 접속함
            sock.Send(Encoding.UTF8.GetBytes(msg)); //메세지를 전송 UTF8로 인코딩된
            sock.Shutdown(SocketShutdown.Send); //다 보냈음을 알림

            var stream = new MemoryStream(1024 * 1024); //메모리 스트림을 써서 쌓아놓을예정

            var buf = new byte[1024 * 4];

            while (true)
            {
                var nbytes = sock.Receive(buf);
                if (nbytes <= 0)
                {
                    break;
                }

                stream.Write(buf, 0, nbytes); //바이트를 쌓아놨다.
            }
            sock.Close();

            Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));


        }
    }
}
