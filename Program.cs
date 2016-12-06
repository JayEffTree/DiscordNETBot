using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;

namespace TestNETBot
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscordClient client = new DiscordClient("", true);

            client.MessageReceived += (sender, e) => // Channel message has been received
            {
                if (e.MessageText.StartsWith(".ping"))
                {
                    e.Channel.SendMessage("Pong, " + e.Author.Mention);
                }
            };

        Console.WriteLine("Attempting to connect!");

            try
            {
                client.SendLoginRequest();
                client.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            client.Connected += (sender, e) =>
            {
                Console.WriteLine("CLIENT CONNECTED");
            };

            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
