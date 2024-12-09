using InveonBootcamp._03.LSP;
using InveonBootcamp._05.DIP.Interfaces;
using InveonBootcamp._05.DIP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InveonBootcamp._06.AsyncPart
{
    public class TasksMethods
    {

        public static async Task MultiThread()
        {

            int[] numbers = Enumerable.Range(0, 1000).ToArray();


            foreach (var number in numbers) {
                Task.Run(() => Console.WriteLine(number));
            }

        }


        public static async Task MultiThreadTaskParallel()
        {
            int[] numbers = Enumerable.Range(0, 1000).ToArray();

            //task parallel library ile : tpl kaç thread kullanması gerektiğini otomatik ayarlar

            Parallel.ForEach(Enumerable.Range(0, 1000).ToArray(), number =>
            {
                Console.WriteLine(number);
            });
        }
    }
}