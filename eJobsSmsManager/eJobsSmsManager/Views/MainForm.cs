using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eJobsSmsManager.Controls;
using eJobsSmsManager.Controller;

namespace eJobsSmsManager.Views
{
    public partial class MainForm : Form
    {
        private ISmsSender jobSys;
        public MainForm()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadMsgPending();
            LoadSentItems();
            LoadLogs();
        }

        
        private void LoadMsgPending()
        {
            jobSys = SmsFactory.getSystem("eJobs");

            //get unset list from db
            DataTable MessageList = jobSys.getUnsentItemsOnline();

            try
            {
                
                //convert datasource to list
                List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();
                
                tableLayoutPanel1.RowCount = 0;
                foreach (DataRow row in MessageList.Rows)
                {
                    string rqID = row["RequestId"].ToString();
                    string svcID = row["RequestId"].ToString();
                    string jobId = row["ServiceID"].ToString();
                    int serviceID = Int32.Parse(svcID);
                    string recipient = row["Recipient"].ToString();
                    string message = row["Message"].ToString();
                    string Schedule = row["DTSchedule"].ToString();
                    string RefId = row["RecType"].ToString();
                    string ClientName = row["ClientName"].ToString();
                    //messageStatus = LabSys.SendSMS(recipient, message); //uncomment to enable sending
                    //Console.WriteLine("notificationID: " + serviceID);
                    Console.WriteLine("recipient: " + recipient);
                    //Console.WriteLine("message: " + message);
                    //Console.WriteLine("Schedule: " + Schedule);
                    //Console.WriteLine("RefId: " + RefId);
                    string msgStatus = "Pending";

                    //check if service id have record in local db
                    if ( jobSys.checkrecord(serviceID)) //true if serviceID has record on local db
                    {
                        Console.WriteLine("ID " + serviceID + ", Has Record on local. " );

                        //get notification referenceID
                        int refID = Int32.Parse(jobSys.getRefID(svcID));
                        Console.WriteLine("RefID : " + refID);

                        //check record status
                        if (jobSys.checkstatus(serviceID))
                        {
                            Console.WriteLine("Status: Sent" );

                            //possible scenario, status on online db is PENDING,
                            //while status on localdb is SENT
                            //Action: update online db

                            //update onlinedb
                            jobSys.updateRecordOnline(serviceID, refID);
                            
                        }
                        else  //local db notification status is PENDING
                        {
                            Console.WriteLine("Status: Pending, Attempting to Send Message.");
                            //attempt to sms

                            //get response (Sent/Failed)
                            string response = "Sent";
                            //response = jobSys.SendSMS("09950753794", "Test from eJobs Manger program ");
                            response = jobSys.sendMessageOnList(refID, message);
                            if (response == "Sent")
                            {
                                //update onlinedb
                                jobSys.updateRecordOnline(serviceID, refID);

                                //update localdb
                                Console.WriteLine("serviceID: " + serviceID);
                                jobSys.updateRecordStatus(serviceID);

                                //insert sent to log
                                jobSys.insertLog(refID,"Sent");
                            }else{  //COM error / Failed

                                //insert failed to log, 
                                //no update on notification status
                                //to resend on next refresh
                                jobSys.insertLog(refID, response);

                            }

                        }
                        Console.WriteLine("Updating Record Successful");

                    }
                    else
                    {
                        Console.WriteLine("ID " + serviceID + ", Has NO Record on local. ");
                        Console.WriteLine("Adding NEW record to the Local Database");
                        //add record to the db
                        jobSys.insertRecord(svcID, jobId, "1",message,Schedule,"Pending");

                        //add message to view
                        Console.WriteLine("adding sms inbox ");

                        //get notification referenceID
                        Console.WriteLine("getRefID : " + svcID);
                        int refID = Int32.Parse(jobSys.getRefID(svcID));

                        Console.WriteLine("recipient: " + recipient);
                    
                        //add Recipients to the table 
                        // Split string on spaces.
                        // ... This will separate all the words.
                        string[] recipients = recipient.Split(',');
                        foreach (string number in recipients)
                        {
                            Console.WriteLine("Recipient " +number + "added - RefID: " + refID);
                            jobSys.insertRecipients(refID.ToString(),number);
                        }
                    
                        Console.WriteLine("Adding Record Successful");
                    }

                    //inset new activity log
                    //LabSys.SetActivityLog(notificationID, messageStatus, "none");

                    // break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("No Pending Record");
            }
        }

        private void LoadSentItems()
        {

            jobSys = SmsFactory.getSystem("eJobs");
            //get unset list from db
            DataTable MessageList = jobSys.getRecord();

            //convert datasource to list
            List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.Controls.Clear();
            foreach (DataRow row in MessageList.Rows)
            {
                string notificationID = row["NotficationId"].ToString();
                string ClientName = row["ClientName"].ToString();
                string message = row["Message"].ToString();
                string Schedule = row["DTlog"].ToString();
                string msgStatus = row["Status"].ToString();

                SMSinbox msgbox = new SMSinbox();
                msgbox.setContent(Int32.Parse(notificationID), ClientName, message, Schedule, msgStatus);
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                tableLayoutPanel1.Controls.Add(msgbox);
            }

        }


        private void LoadLogs()
        {
            
            jobSys = SmsFactory.getSystem("eJobs");
            //get unset list from db
            DataTable MessageList = jobSys.getLogs();

            //convert datasource to list
            List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();

            LogsTablePanel.RowCount = 0;
            LogsTablePanel.Controls.Clear();
            foreach (DataRow row in MessageList.Rows)
            {
                string notificationID = row["NotficationId"].ToString();
                string serviceId = row["ServiceId"].ToString();
                string clientName = row["ClientName"].ToString();
                string message = row["Message"].ToString();
                string schedule = row["DTlog"].ToString();
                string status = row["Status"].ToString();

                LogsControl logs = new LogsControl();
                logs.setDetails(Int32.Parse(notificationID), Int32.Parse(serviceId),clientName,status);

                //SMSinbox msgbox = new SMSinbox();
                //msgbox.setContent(Int32.Parse(notificationID), ClientName, message, Schedule, msgStatus);
                LogsTablePanel.RowCount = LogsTablePanel.RowCount + 1;
                LogsTablePanel.Controls.Add(logs);
            }

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            jobSys = SmsFactory.getSystem("eJobs");
            jobSys.SendSMS("09950753794", "Pickup Details" +
                                        "Date:18 Jul 2018 (Wed)" +
                                        "Time&Location:12:00:00 Airport" +
                                        "Guest:Admin Test #09950753794" +
                                        "Driver:Supplier #09950753794" +
                                        "Unit:Default "); 

            //jobSys.updateRecordStatus(1);
            //jobSys.insertLog(2003,"Sent");

            //LoadSentItems();
        
            LoadLogs();
        }

        private void sendertimer_Tick(object sender, EventArgs e)
        {
            LoadSentItems();
            LoadMsgPending();
            LoadLogs();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {

            sendertimer.Enabled = bunifuiOSSwitch1.Value;
            Console.WriteLine("Timer : " + sendertimer.Enabled);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;

            tableLayoutPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);

            LogsTablePanel.Padding = new Padding(0, 0, vertScrollWidth, 0);


        }

        private void RefreshNotifbutton_Click(object sender, EventArgs e)
        {
            LoadMsgPending();
            LoadSentItems();
        }

        private void LogsRefreshbutton_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }
    }
}
