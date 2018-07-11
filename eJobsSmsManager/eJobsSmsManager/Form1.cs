using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eJobsSmsManager.Views;

namespace eJobsSmsManager
{
    public partial class Form1 : Form
    {
        //Views
        Main mainView = new Main();
        AboutForm AboutView = new AboutForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mainView.TopLevel = false;
            mainView.AutoScroll = true;
            MainPanel.Controls.Add(mainView);
            mainView.Show();

            AboutView.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //main.Show();
            mainView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mainView.TopLevel = false;
            mainView.AutoScroll = true;
            MainPanel.Controls.Add(mainView);
            mainView.Show();


        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {

            AboutView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            AboutView.TopLevel = false;
            AboutView.AutoScroll = true;
            MainPanel.Controls.Add(AboutView);
            AboutView.Show();

            mainView.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
