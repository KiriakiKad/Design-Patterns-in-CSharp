using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystemFactoryDP
{
    public class NotificationFactory
    {
        public INotification SendNotification(string selectedType)
        {

            if (selectedType.Equals("sms")){
                return new SmsNotification();
            }else if (selectedType.Equals("email"))
            {
                return new EmailNotification();
            }else if (selectedType.Equals("push"))
            {
                return new PushNotification();
            }
            else if (selectedType.Equals("quit"))
            {
                Environment.Exit(0);
                return null;
            }
            else
            {
                throw new ArgumentException("Unsupported type");
            }

        }
    }
}
