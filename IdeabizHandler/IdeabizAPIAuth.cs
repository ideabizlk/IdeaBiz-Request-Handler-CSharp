using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IdeabizDemo
{
    /*
    This class will handle the API call and authorization for ideabiz
    This Class use app settings for save and read API credentials
    If need use DB or other datasource to save credentials, 
    please  reimpliment save settings and readsettings method
    */
    class IdeabizAPIAuth
    {
        public  String CONSUMER_KEY;
        public  String CONSUMER_SECRET;
        public  String TOKEN_API;
        public  String ACCESS_TOKEN;
        public  String REFRESH_TOKEN;

        public enum REQUEST_METHOD { GET, POST };

        /*
        Save credentials
        */
        public  void saveSettings()
        {
            IdeabizHandler.Ideabiz.Default.ACCESS_TOKEN = ACCESS_TOKEN;
            IdeabizHandler.Ideabiz.Default.REFRESH_TOKEN = REFRESH_TOKEN;
            IdeabizHandler.Ideabiz.Default.Save();
        }

        /*
        Read credentials
        */
        public  void readSettings()
        {
            TOKEN_API = IdeabizHandler.Ideabiz.Default.TOKEN_API;
            CONSUMER_KEY = IdeabizHandler.Ideabiz.Default.CONSUMER_KEY;
            CONSUMER_SECRET = IdeabizHandler.Ideabiz.Default.CONSUMER_SECRET;
            ACCESS_TOKEN = IdeabizHandler.Ideabiz.Default.ACCESS_TOKEN;
            REFRESH_TOKEN = IdeabizHandler.Ideabiz.Default.REFRESH_TOKEN;

        }

        /*
        Once token expired, it will renew and save from this method
        */
        public  void renewToken()
        {
           IdeabizResponse response= sendRequest(TOKEN_API + "?grant_type=refresh_token&refresh_token=" + REFRESH_TOKEN + "&scope=PRODUCTION", REQUEST_METHOD.POST, " ", "application/x-www-form-urlencoded","Basic " + Base64Encode(CONSUMER_KEY + ":" + CONSUMER_SECRET),"application/json");

            if (response.Status.Equals("SUCCESS"))
            {
                Dictionary< string, string> data = JsonConvert.DeserializeObject< Dictionary < string, string >> (response.Body);

                data.TryGetValue("access_token", out ACCESS_TOKEN);
                data.TryGetValue("refresh_token", out REFRESH_TOKEN);
                saveSettings();

            }
            else
            {
                throw new Exception("Authentication error");
            }

        }

        /*
        base64 Encoder for Authorization basic
        */
        string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }


        
        public  IdeabizResponse sendRequest(String URL, REQUEST_METHOD method, String body, String contentType,String authorization, String accept)
        {
            IdeabizResponse ideabizResponse = new IdeabizResponse();

            try
            {

                var request = (HttpWebRequest)WebRequest.Create(URL);

                request.ContentType = contentType;
                request.Accept = accept;
                request.Headers["Authorization"] = authorization;

                if (method == REQUEST_METHOD.POST)
                {
                    var data = Encoding.ASCII.GetBytes(body); ;

                    if (ContainsUnicodeCharacter(body))
                    {
                        data = Encoding.UTF8.GetBytes(body);
                    }


                    request.Method = "POST";
                    request.ContentLength = data.Length;
                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                ideabizResponse.StatusCode = (int)response.StatusCode ;

                String responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                ideabizResponse.Body = responseString;
                ideabizResponse.Status = "SUCCESS";


                

            }
            catch (WebException ex)
            {
                HttpWebResponse response = (HttpWebResponse)ex.Response;

                if(response == null)
                {
                    throw ex;
                }
                ideabizResponse.Status = "ERROR";
                ideabizResponse.StatusCode = (int)response.StatusCode;
                ideabizResponse.Body =new StreamReader(response.GetResponseStream()).ReadToEnd();


            }
         return ideabizResponse;

        }

         bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.Any(c => c > MaxAnsiCode);
        }

        public IdeabizAPIAuth()
        {
            readSettings();
        }
    }
}
