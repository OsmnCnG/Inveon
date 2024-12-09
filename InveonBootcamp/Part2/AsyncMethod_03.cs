using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp._06.AsyncPart
{
    public class AsyncMethod_03
    {

        public static async Task<string> GetShortLivedAccessTokenAsync()
        {
            try
            {

                var accessToken = "acb";//http request

                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new Exception("short lived access token alınamadı.");
                }

                return accessToken;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
                return ex.Message;
            }
        }

        public static async Task<string> GetLongLivedAccessTokenAsync(string accessToken)
        {

            try
            {

                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new Exception("access token alınamadı");
                }

                return accessToken + "/longLivedAccessToken";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
                return ex.Message;

            }

        }




    }
}
