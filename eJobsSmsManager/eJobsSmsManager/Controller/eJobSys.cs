﻿using System;
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
                return "http://localhost:50382";
            }
        }

        public DataTable getUnsentItemsOnline()
        {
            return webData.Getcontent(dbserver + "/SMSWebService.asmx/getUnsentItems");
        }

        public void updateRecordOnline(int serviceId, int refId)
        {

            string url = dbserver + "/SMSWebService.asmx/updateNotification";

            var data = new NameValueCollection();

            data["serviceId"] = serviceId.ToString();
            data["refId"] = refId.ToString();
            
            // Console.WriteLine("data update " + data);

            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("updateRecordOnline :" + responseInString);

        }


        public void updateRecord(int serviceId)
        {

            string url = "http://localhost:49360//SMSWebService.asmx/updateRecord";

            var data = new NameValueCollection();

            data["serviceId"] = serviceId.ToString();

            // Console.WriteLine("data update " + data);

            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("updateRecord :" + responseInString);

        }

        public string getRefID(string id)
        {
            //test
            string url = "http://localhost:49360/LocalService.asmx/getRecordId";

            var data = new NameValueCollection();
            data["serviceid"] = "1";

            string responseInString = webData.sendMsgData(url, data);
            Console.WriteLine("get record " + responseInString);

            return responseInString;
           
        }


        public void insertRecord(string Id, string jobId,
            string appId,  string message, string sendDt, string status){
            
            string url = "http://localhost:49360/LocalService.asmx/InsertNotification";

            var data = new NameValueCollection();
         
            data["Id"] = Id.ToString();
            data["serviceId"] = Id.ToString();
            data["jobId"] = jobId.ToString();
            data["appId"] = appId.ToString();
            data["message"] =  message;
            data["status"] = status.ToString();

            // Console.WriteLine("data update " + data);

            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("logs update " + responseInString);
        }

        public void insertRecipients(string notificationid, string recipient)
        {

            string url = "http://localhost:49360/LocalService.asmx/insertRecipients";

            var data = new NameValueCollection();

            data["notificationid"] = notificationid;
            data["recipient"] = recipient.ToString();


            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("Recipient added to database. ");
        }

        public DataTable getRecord()
        {
            //test
            string url = "http://localhost:49360/LocalService.asmx/readNotification";

            var data = new NameValueCollection();
            data["id"] = "1";
            string responseInString = webData.sendMsgData(url, data);

            Console.WriteLine("get record " + responseInString);

            DataSet dataset = JsonConvert.DeserializeObject<DataSet>(responseInString);
            DataTable dataTable = dataset.Tables["Table"];

            return dataTable;

           // return webData.Getcontent(dbserver + "/SMSWebService.asmx/getUnsentItems");
        }

        public bool checkrecord(int serviceid)
        {
            string url = "http://localhost:49360/LocalService.asmx/getRecord";

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
            string url = "http://localhost:49360/LocalService.asmx/getStatus";

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
                //Pending
            }
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
            Recipient = "639950753794"; //format (63 + number ex. 639279016517)
            Message = "c# text test :" + DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            Console.WriteLine("CONNECTING TO COM4");
            if (GSMBot.PortConnect("COM3"))
            {
                
                Console.WriteLine("COM4 CONNECTED. SENDING MESSAGE");
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
                Console.WriteLine("Error connecting to Broadband COM4");
                messageStatus = "COM error";
            }
            GSMBot.closeConnection();
            return messageStatus;
        }
    }
}