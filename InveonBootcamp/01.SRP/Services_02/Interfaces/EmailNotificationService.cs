﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp.SRP.Services_02.Interfaces
{
    public class EmailNotificationService2 : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine("Email gönderildi:", message);
        }
    }
}
