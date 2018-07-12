using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eJobsSmsManager.Controller
{
    interface ISmsSender
    {
        string dbserver { get; }

        //interface methods
        DataTable getUnsentItemsOnline();
        void updateRecordOnline(int requestID, int refId);
        void updateRecordStatus(int serviceId);
        void insertRecord(string Id, string jobId, string appId, string message, string sendDt , string status);
        DataTable getRecord();
        string getRefID(string id);
        string SendSMS(string Recipient, string Message);
        void insertRecipients(string notificationid, string recipient);
        bool checkrecord(int serviceid);
        bool checkstatus(int serviceid);
        void insertLog(int notificationid,string status);
        string sendMessageOnList(int refID, string message);
   }
}
