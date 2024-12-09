using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp.SRP.Services_01
{
    public class SmsService
    {
        public void sendSms(string message)
        {
            Console.WriteLine("Sms gönderildi:", message);
        }
    }
}
