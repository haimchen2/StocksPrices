using System;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client";
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("127.0.0.1", 8085);
           
            using (Socket socket = tcpClient.Client)
            {
                byte[] bytesRecived = new byte[4];
                socket.Receive(bytesRecived);

                foreach (var item in bytesRecived)
                {
                    Console.WriteLine(item);
                }
                byte[] bytes2send = { 5,6,7,8 };
                socket.Send(bytes2send);
              
            }
            tcpClient.Close();
            Console.Read();
        }
    }
}
