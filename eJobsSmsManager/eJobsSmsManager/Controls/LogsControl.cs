using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eJobsSmsManager.Controls
{
    public partial class LogsControl : UserControl
    {
        public LogsControl()
        {
            InitializeComponent();
        }

        private void LogsControl_Load(object sender, EventArgs e)
        {

            if (Statuslabel.Text == "Failed")
            {
                StatusPanel.BackColor = Color.OrangeRed;
            }
            else
            {
                StatusPanel.BackColor = Color.DodgerBlue;
            }
        }

        public void setDetails(int notifId,int serviceID, string clientName, string status){
            ServiceIDlabel.Text = serviceID.ToString();
            Clientlabel.Text = clientName;
            Statuslabel.Text = status;
            notificationlabel.Text = notifId.ToString();
            
        }
    }
}
