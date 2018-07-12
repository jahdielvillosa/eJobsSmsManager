using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Net.Http;
using System.Collections.Specialized;

namespace eJobsSmsManager.Controller
{
    class JsonHandler
    {

        public class MessageDetails
        {
            public string Id { get; set; }
            public string RecType { get; set; }
            public string Recipient { get; set; }
            public string Message { get; set; }
            public string DTSending { get; set; }
            public string RefId { get; set; }
            public string RefTable { get; set; }

        }

        public class RootDetails
        {
            public List<MessageDetails> MessageList { get; set; }
        }

        public DataTable Getcontent(string url)
        {
            //deserialize json string
            //string json = @"[{'one': 'two','key':'value'},{'one': 'two2','key':'value2'}]";
            //string json = @"[{'id':'01','reciever':'09279016517','message':'hello world','status':'success'},{'id':'01','reciever':'09279016517','message':'hello world','status':'success'}]";
            // url = 

            try
            {
                //request json data
                Uri uri = new Uri(url);
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Method = WebRequestMethods.Http.Get;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string output = reader.ReadToEnd();
                response.Close();

                //deserialize json string
                var json = output;

                if(json == null || json=="")
                {
                    Console.WriteLine("...");
                   
                }
                else
                {

                    Console.WriteLine("Fetching list from server" + json);

                    //for json list
                    //Console.WriteLine(json);
                    DataSet dataset = JsonConvert.DeserializeObject<DataSet>(json);
                    DataTable dataTable = dataset.Tables["Table"];

                    //display result in console
                    //Console.WriteLine(dataTable.Rows.Count);
                    //foreach (DataRow row in dataTable.Rows)
                    //{
                    //    Console.WriteLine(row["id"]);
                    //    Console.WriteLine(row["RecType"]);
                    //    Console.WriteLine(row["Recipient"]);
                    //    Console.WriteLine(row["Message"]);
                    //    Console.WriteLine(row["DTSending"]);
                    //    Console.WriteLine(row["RefId"]);
                    //    Console.WriteLine(row["RefTable"]);

                    //}

                    return dataTable;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public string sendMsgData(string Url, NameValueCollection Data)
        {
            string responseInString = "";
            using (var wb = new WebClient())
            {
                try
                {
                    var response = wb.UploadValues(Url, "POST", Data);
                    responseInString = Encoding.UTF8.GetString(response);
                    //Console.WriteLine(responseInString);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return responseInString;
        }


    }
}

