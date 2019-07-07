using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetHpServer;

namespace NetHpServerLinux
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketServer socketServer = new SocketServer();
            socketServer.Init();

            Task.Run(() =>
            {
                while (true)
                {
                    //socketServer.SendToAll(Encoding.Default.GetBytes("Hello! This is the message that server sends to all clients,Hello! This is the message that server sends to all clients "));
                    Thread.Sleep(50);
                }
            });

            string c;
            while ((c = Console.ReadKey().KeyChar.ToString()) != null)
            {
                switch (c)
                {
                    case "1":
                        socketServer.SendToAll(Encoding.Default.GetBytes("Hello! This is the message that server sends to all clients"));
                        Console.WriteLine();
                        break;
                    case "2":
                        break;
                }
            }
        }
    }
}
