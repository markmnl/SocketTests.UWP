using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Net.Sockets;
using System.Net;

namespace SocketTests.UWP
{
    [TestClass]
    public class SocketTests
    {
        private static int port = 37895;

        private void BindUDPSocket(bool blocking, bool enableBroadcast)
        {
            port++;

            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sock.Bind(new IPEndPoint(IPAddress.Any, port));
            sock.Blocking = blocking;
            sock.EnableBroadcast = enableBroadcast;
        }

        [TestMethod]
        public void BindBlockingUDPSocket()
        {
            BindUDPSocket(true, false);
            // nothing to assert, just cheking exception not thrown
        }

        [TestMethod]
        public void BindNonBlockingUDPSocket()
        {
            BindUDPSocket(true, false);
            // nothing to assert, just cheking exception not thrown
        }

        [TestMethod]
        public void BindNonBlockingBroadcastUDPSocket()
        {
            BindUDPSocket(false, true);
            // nothing to assert, just cheking exception not thrown
        }

        [TestMethod]
        public void BindBlockingBroadcastUDPSocket()
        {
            BindUDPSocket(true, true);
            // nothing to assert, just cheking exception not thrown
        }

    }
}
