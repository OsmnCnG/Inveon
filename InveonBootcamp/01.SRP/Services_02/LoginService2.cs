using InveonBootcamp.SRP.Services_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp.SRP.Services_02
{
    public class LoginService2
    {
        private readonly INotificationService NotificationService2;

        public LoginService2(INotificationService notificationService)
        {
            NotificationService2 = notificationService;
        }


        public void Login()
        {

            NotificationService2.Notify("User logged in");
        }

    }
}
