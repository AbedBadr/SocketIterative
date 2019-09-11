using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SocketIterative
{
    public class EchoService
    {
        private TcpClient _connectionSocket;

        public EchoService(TcpClient connection)
        {
            _connectionSocket = connection;
        }

        public void DoIt()
        {

        }
    }
}
