using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Commands
{
    public static class CommandWorker
    {
        public static void Send(string message)
        {
            Console.WriteLine($"Sending message: {message}");
            Program.ServerWorker.SendMessage(message);
        }

        public static void Status()
        {
            string ip = InfoServer.Ip.ToString();
            DateTime dateTime = InfoServer.ServerStartTime;

            Console.WriteLine($"Status:\n");
            Console.WriteLine($"Ip адрес: {InfoServer.Ip}");
            Console.WriteLine($"порт: {InfoServer.Port}");
            Console.WriteLine($"Время включения: {InfoServer.ServerStartTime}");
        }

        public static void Help()
        {
            Console.WriteLine("Help: Show list command\n");
            Console.WriteLine("Send: Send message\n");
            Console.WriteLine("Ban: Disconnect User\n");
            Console.WriteLine("Status:   ()\n");
            Console.WriteLine("Exit: Close client");
        }

        public static void Ban(string name)
        {
            Program.ServerWorker.Ban(name);
        }

        public static void UserList()
        {
            Program.ServerWorker.InfoClient();
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
