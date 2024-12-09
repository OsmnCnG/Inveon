using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp.SRP.Services_01
{
    public class LoginService
    {
        private readonly EmailService EmailService;

        private readonly SmsService SmsService;

        public LoginService(EmailService emailNotification, SmsService smsNotification)
        {
            EmailService = emailNotification;

            SmsService = smsNotification;
        }


        public void Login()
        {
            //if login success return notify message
            EmailService.sendEmail("email gönderildi");
            SmsService.sendSms("sms gönderildi");
        }

    }
}
