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
        }

        
        private void LoadMsgPending()
        {
            jobSys = SmsFactory.getSystem("eJobs");

            //get unset list from db
            DataTable MessageList = jobSys.getUnsentItemsOnline();

            //convert datasource to list
            List<DataRow> Messagelist = MessageList.AsEnumerable().ToList();


            tableLayoutPanel1.RowCount = 0;
            foreach (DataRow row in MessageList.Rows)
            {
                
                string svcID = row["ServiceId"].ToString();
                int serviceID = Int32.Parse(svcID);
                string recipient = row["Recipient"].ToString();
                string message = row["Message"].ToString();
                string Schedule = row["DTSchedule"].ToString();
                string RefId = row["RecType"].ToString();
                //messageStatus = LabSys.SendSMS(recipient, message); //uncomment to enable sending
                //Console.WriteLine("notificationID: " + serviceID);
                //Console.WriteLine("recipient: " + recipient);
                //Console.WriteLine("message: " + message);
                //Console.WriteLine("Schedule: " + Schedule);
                //Console.WriteLine("RefId: " + RefId);
                string msgStatus = "Pending";

                //check if service id have record in local db
                if ( jobSys.checkrecord(serviceID))
                {
                    Console.WriteLine("ID " + serviceID + ", Has Record on local. " );

                    //get notification referenceID
                    int refID = Int32.Parse(jobSys.getRefID(svcID));

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
                    else
                    {
                        Console.WriteLine("Status: Pending");
                        //attempt to sms

                        //get response (Sent/Failed)
                        string response = "Sent";
                        
                        if (response == "Sent")
                        {
                            //update onlinedb
                            jobSys.updateRecordOnline(serviceID, refID);

                            //update localdb
                            jobSys.updateRecordStatus(serviceID);

                            //insert sent to log
                            jobSys.insertLog(refID,"Sent");
                        }else{

                            //insert failed to log, 
                            //no update on notification status
                            //to resend on next refresh
                            jobSys.insertLog(refID, "Failed");

                        }

                    }

                }
                else
                {
                    Console.WriteLine("ID " + serviceID + ", Has NO Record on local. ");
                    Console.WriteLine("Adding to the Local Database");
                    //add record to the db
                    jobSys.insertRecord(svcID, svcID, "1",message,Schedule,"Pending");

                    //add message to view
                    SMSinbox msgbox = new SMSinbox();
                    msgbox.setContent(serviceID, recipient, message, Schedule, msgStatus);
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(msgbox);

                    //get notification referenceID
                    int refID = Int32.Parse(jobSys.getRefID(svcID));

                    //add Recipients to the table 
                    // Split string on spaces.
                    // ... This will separate all the words.
                    string[] recipients = recipient.Split(',');
                    foreach (string number in recipients)
                    {
                        Console.WriteLine("Recipient " +number + "added - RefID: " + refID);
                        jobSys.insertRecipients(refID.ToString(),number);
                    }

                }

                //inset new activity log
                //LabSys.SetActivityLog(notificationID, messageStatus, "none");

                // break;
            }
        }

        private void LoadSentItems()
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            jobSys = SmsFactory.getSystem("eJobs");

            jobSys.updateRecordStatus(1);
        }
    }
}
