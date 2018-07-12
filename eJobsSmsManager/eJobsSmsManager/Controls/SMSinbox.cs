using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eJobsSmsManager.Controller;
using eJobsSmsManager.Views;

namespace eJobsSmsManager.Controls
{
    public partial class SMSinbox : UserControl
    {
        public SMSinbox()
        {
            InitializeComponent();
        }

        ISmsSender sms = SmsFactory.getSystem("eJobs");

        private void SMSinbox_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void SMSinbox_Load(object sender, EventArgs e)
        {
            if(this.MsgStatus.Text == "Pending")
            {
                this.MsgStatus.ForeColor = Color.OrangeRed;
            }
        }

        private void SMSinbox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        
        public void setContent(int serviceId, string recipient, string message, string msgdateTime, string status  )
        {
            MsgId.Text = serviceId.ToString();
            MsgRecipient.Text = recipient;
            MsgContent.Text = message;
            MsgDateTime.Text = msgdateTime;
            MsgStatus.Text = status;
        }

        private void SMSinbox_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.MsgContent.Text);
            //Console.WriteLine();
            //DataTable MessageList = sms.getRecord();
            //bunifuCustomDataGrid1.DataSource = MessageList;
            //Console.WriteLine("open sms inbox mouse click");

            //foreach (DataRow data in MessageList.Rows)
            //{
            /*
            SMSinbox msg = new SMSinbox();
            msg.setContent(
                0,
                data["Recipient"].ToString(),
                data["Message"].ToString(),
                data["DtSchedule"].ToString(),
                "Pending");

            rows++;
            tableLayoutPanel1.RowCount = rows;
            tableLayoutPanel1.Controls.Add(msg);

            Console.WriteLine(data["Recipient"]);
            Console.WriteLine("row count " + rows);
            */
            //  MessageBox.Show(data["Message"].ToString());
            // }
            //return MessageList;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
