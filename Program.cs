using Newtonsoft.Json;
using RESTfulAPIConsume.Constants;
using RESTfulAPIConsume.RequestHandlers;
using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Text;
//using System.Net.WebClient.DownloadFile;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;


namespace RESTfulAPIConsume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the API request ...");
            Console.WriteLine();

            IRequestHandler httpWebRequestHandler = new HttpWebRequestHandler();

            // 1st get request:
            // authentication 
            WebRequest reqID = WebRequest.Create(RequestConstants.UrlGetReportDefinitionId);
            reqID.Method = "GET";
            reqID.ContentType = "application/json";

            HttpWebResponse respID = reqID.GetResponse() as HttpWebResponse;
            var response = GetId(httpWebRequestHandler);

            // show all JSON response in console
            //Console.WriteLine("response: {0}", response );

            // parse the response to dynamic data variable
            dynamic data = JObject.Parse(response);
   

            // 2nd get request:
            // define the download URL from the reportID and download the CSV file to local storage

            // display response on console
            //documentation: https://docs.microsoft.com/en-us/dotnet/api/system.net.webrequest?view=net-6.0
            //Console.WriteLine(resp.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = resp.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            //Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            resp.Close();
            
            // write reponse to local file
            File.WriteAllText(RequestConstants.path, responseFromServer);
            
            Console.WriteLine(respID);
            Console.ReadLine();
        }

        public static string GetId(IRequestHandler requestHandler)
        {
            return requestHandler.GetId(RequestConstants.UrlGetReport);

        }
    }
}