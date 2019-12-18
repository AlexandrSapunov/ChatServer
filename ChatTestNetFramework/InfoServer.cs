using System;
using System.Net;

namespace Server
{
    public class InfoServer
    {
        public static IPEndPoint Ip { get; set; }
        public static int Port { get; private set; } = 8080;
        public static int NumberConnectedUsers { get; set; } = 0;
        public static DateTime ServerStartTime { get; set; }
    }
}
