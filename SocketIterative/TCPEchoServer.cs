using System;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace SocketIterative
{
    class Program
    {
        static void Main1(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(ip, 6789);
            serverSocket.Start();
            Console.WriteLine("Server started");

            while (true)
            {
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                //Socket connectionSocket = serverSocket.AcceptSocket();
                Console.WriteLine("Server activated");

                Stream ns = connectionSocket.GetStream();
                //Stream ns = new NetworkStream(connectionSocket);
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true; // enable automatic flushing

                string message = sr.ReadLine();
                string answer = "";
                while (message != null && message != "")
                {
                    Console.WriteLine("Client: " + message);
                    answer = message.ToUpper();
                    sw.WriteLine(answer);
                    message = sr.ReadLine();
                }
                /*
                ns.Close();
                connectionSocket.Close();
                serverSocket.Stop();
                */
            }
        }
    }
}
