using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IdeabizDemo
{
    class IdeabizRequestHandler
    {
        IdeabizAPIAuth idabizAuth = null;


        /// <summary>
        /// Send API call to ideabiz
        /// This will handle and inject access token
        /// This library need https://www.nuget.org/packages/Newtonsoft.Json/ 
        /// </summary>
        /// <param name="URL">Request full URL (eg : https://ideabiz.lk/apicall/smsmessaging/v2/94777123456/request</param>
        /// <param name="method">IdeabizAPIAuth.REQUEST_METHOD GET OR POST</param>
        /// <param name="body">plain text body. JSON string or urlencoded body</param>
        /// <param name="contentType">Content type, eg: application/json</param>
        /// <param name="accept">Accept content type : eg application/json</param>
        /// <returns>Ideabiz Response contain status, statusCode, Body</returns>
        public IdeabizResponse sendAPICall(String URL, IdeabizAPIAuth.REQUEST_METHOD method, String body, String contentType,String accept)
        {
            
            IdeabizResponse response = idabizAuth.sendRequest(URL, method, body, contentType, "Bearer " + idabizAuth.ACCESS_TOKEN,accept);

            if (response.Status.Equals("ERROR") && response.StatusCode==401 && (response.Body.Contains("Expired") || response.Body.Contains("Inactive")))
            {
                IdabizAuth.renewToken();
                response = idabizAuth.sendRequest(URL, method, body, contentType, "Bearer " + idabizAuth.ACCESS_TOKEN,accept);

            }
           
            return response;
        }

        public IdeabizRequestHandler()
        {
            IdabizAuth = new IdeabizAPIAuth();
        }

        public IdeabizAPIAuth IdabizAuth
        {
            get
            {
                return idabizAuth;
            }

            set
            {
                idabizAuth = value;
            }
        }

    }
}
