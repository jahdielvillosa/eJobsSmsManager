using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eJobsSmsManager.Controller;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace eJobsSmsManager.Controller
{
    class eJobSys : ISmsSender
    {
        JsonHandler webData = new JsonHandler();
        public string dbserver
        {
            get
            {
                return "http://localhost:50382/SMSWebService.asmx/";
            }
        }

        public string localserver
        {
            get
            {
                return "http://localhost:49360/LocalService.asmx/";
            }
        }

        public DataTable getUnsentItemsOnline()
        {
            return webData.Getcontent(dbserver + "getUnsentItems");
        }

        public void updateRecordOnline(int requestID, int refId)
        {

            string url = dbserver + "updateNotification";

            var data = new NameValueCollection();

            data["requestID"] = requestID.ToString();
            data["refId"] = refId.ToString();
            
            // Console.WriteLine("data update " + data);

            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("updateRecordOnline :" + responseInString);

        }


        public void updateRecordStatus(int serviceId)
        {

            string url = localserver + "updateRecord";

            var data = new NameValueCollection();
            //Console.WriteLine(serviceId);
            data["serviceId"] = serviceId.ToString();
            
            string responseInString = webData.sendMsgData(url, data);
            Console.WriteLine("updated record " + responseInString);
        }

        public string getRefID(string id)
        {
            //test
            string url = localserver + "getRecordId";

            var data = new NameValueCollection();
            data["serviceid"] = id;

            string responseInString = webData.sendMsgData(url, data);
            Console.WriteLine("get refID: " + responseInString);

            return responseInString;
           
        }
        
        public void insertRecord(string Id, string jobId,
            string appId,  string message, string sendDt, string status){
            
            string url = localserver + "InsertNotification";

            var data = new NameValueCollection();
         
            data["Id"] = Id.ToString();
            data["serviceId"] = Id.ToString();
            data["jobId"] = jobId.ToString();
            data["appId"] = appId.ToString();
            data["message"] =  message;
            data["status"] = status.ToString();

            // Console.WriteLine("data update " + data);

            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("insert record : " + responseInString);
        }

        public void insertRecipients(string notificationid, string recipient)
        {

            string url = localserver + "insertRecipients";

            var data = new NameValueCollection();

            data["notificationid"] = notificationid;
            data["recipient"] = recipient.ToString();


            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("Recipient added to database. ");
        }

        public DataTable getRecord()
        {

            return webData.Getcontent(localserver + "getNotifcationList");
        }


        public DataTable getLogs()
        {

            return webData.Getcontent(localserver + "getLogs");
        }

        public bool checkrecord(int serviceid)
        {
            string url = localserver + "getRecord";

            var data = new NameValueCollection();
            data["id"] = serviceid.ToString();
            string responseInString = webData.sendMsgData(url, data);
            Console.WriteLine("checkrecord: " + responseInString);

            if(responseInString == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool checkstatus(int serviceid)
        {
            string url = localserver + "getStatus";

            var data = new NameValueCollection();
            data["serviceid"] = serviceid.ToString();
            string responseInString = webData.sendMsgData(url, data);
            Console.WriteLine("check status: " + responseInString);

            if (responseInString == "Sent")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //


        //send sms 
        public string SendSMS(string Recipient, string Message)
        {
            GSM GSMBot = new GSM();
            string messageStatus = "";
           // Recipient = "639950753794"; //format (63 + number ex. 639279016517)
            //Message = "c# text test :" + DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            Console.WriteLine("CONNECTING TO COM5");
            if (GSMBot.PortConnect("COM5"))
            {
                
                Console.WriteLine("COM5 CONNECTED. SENDING MESSAGE");
                if (GSMBot.GSMSend(Recipient, Message))
                {
                    //insert serverupdate here
                    Console.WriteLine("MESSAGE SENT");              //sending success
                    messageStatus = "Sent";
                }
                else
                {
                    Console.WriteLine("MESSAGE SENDING FAILED");    //sending failed
                    messageStatus = "Failed";
                }
                
            }
            else
            {
                Console.WriteLine("Error connecting to Broadband COM5");
                messageStatus = "COM error";
            }
            GSMBot.closeConnection();
            return messageStatus;
        }

        public void insertLog(int notificationid, string status)
        {
            //insertLog

            string url = localserver + "insertLog";

            var data = new NameValueCollection();

            data["notificationid"] = notificationid.ToString();
            data["status"] = status.ToString();
            
            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("Log added to database. ID : " + notificationid + ", status: " + status +" : " + responseInString);
        }

        public string sendMessageOnList(int refID, string message)
        {
            //get list of numbers using refID
            string response = "Sent";
            string url = localserver + "getRecipients";

            var data = new NameValueCollection();

            data["refID"] = refID.ToString();

            DataSet dataset = JsonConvert.DeserializeObject<DataSet>(webData.sendMsgData(url, data));
            DataTable MessageList = dataset.Tables["Table"];
            
            //convert datasource to list
            List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

            foreach (DataRow row in MessageList.Rows)
            {
                //send each
                string recipientNumber = row["Recipient"].ToString();
                Console.WriteLine("Sending Message to " + recipientNumber);
                string smsresponse = SendSMS(recipientNumber, message);

                //if one of sms response failed, return failed
                if (smsresponse != "Sent")
                {
                    response = smsresponse; 
                }
            }

            return response;
        }

        
    }
}
