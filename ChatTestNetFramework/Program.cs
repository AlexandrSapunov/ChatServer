using Server.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        public static Server ServerWorker;
        static int Main(string[] args)
        {
            string Ip = IPAddress.Any.ToString();
            Console.WriteLine(Ip);

            ServerWorker = new Server(Ip);
            ServerWorker.Start();

            Console.WriteLine("Введите exit что бы завершить работу");
            while (true)
            {
                string input = Console.ReadLine();
                var command = Commands.Commands.GetCommand(input);

                switch (command.Type)
                {
                    case TypeCommand.Send:
                        CommandWorker.Send(command.FullValue);
                        break;
                    case TypeCommand.Ban:
                        CommandWorker.Ban(command.FullValue);
                        break;
                    case TypeCommand.Help:
                        CommandWorker.Help();
                        break;
                    case TypeCommand.Status:
                        CommandWorker.Status();
                        break;
                    case TypeCommand.Exit:
                        CommandWorker.Exit();
                        break;
                    case TypeCommand.Userlist:
                        CommandWorker.UserList();
                        break;
                    default:
                        break;
                }            
            }

        }
    }
}