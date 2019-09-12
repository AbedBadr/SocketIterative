using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace SocketIterative
{
    class TCPEchoServer1
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(6789);
            serverSocket.Start();
            Console.WriteLine("Server started");

            while (true)
            {
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("Server activated");

                EchoService echoService = new EchoService(connectionSocket);
                echoService.DoIt();
            }
        }
    }
}
