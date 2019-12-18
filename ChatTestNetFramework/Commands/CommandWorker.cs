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

        public static void Help()
        {
            Console.WriteLine("Help: казывает все команды сервера\n");
            Console.WriteLine("Send: Отправляет сообщения\n");
            Console.WriteLine("UserList: показывает список пользователей ip и время их подключения\n");
            Console.WriteLine("Ban: Отключает клиента от сервера\n");
            Console.WriteLine("Status: Показывает ip адрес, порт и время подключения\n");
            Console.WriteLine("Exit: Закрыть сервер");
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
