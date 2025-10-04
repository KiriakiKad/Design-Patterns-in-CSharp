using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemFactoryDP
{
    class Program
    {

        static void Main(string[] args)
        {
            var factory = new NotificationFactory();

            while (true)
            {
                Console.Write("Select the type of message that you wnat o send: (email, sms, push) or quit: ");

                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                input = input.Trim().ToLower();

                var notification = factory.SendNotification(input);

                if (notification != null)
                {
                    Console.Write("Enter your message: ");
                    var message = Console.ReadLine();
                    notification.Send(message);
                }
            }
        }
    }
}
