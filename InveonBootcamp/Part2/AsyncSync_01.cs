using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._06.AsyncPart
{
    
    public class AsyncMethod_01
    {

        public static async Task<string> GetPostFromInstagram()
        {
            Console.WriteLine("Get Post Method Start!");

            await Task.Delay(1000);

            return "Posts";
        }

        public static async Task<string> GetProfileDetailFromInstagram()
        {
            Console.WriteLine("Get Profile Method Start!");

            await Task.Delay(2000);

            return "ProfileDetails";
        }







    }
}
