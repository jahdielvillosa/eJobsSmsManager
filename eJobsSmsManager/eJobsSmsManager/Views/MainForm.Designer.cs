namespace eJobsSmsManager.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.SendBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.sendertimer = new System.Windows.Forms.Timer(this.components);
            this.RefreshNotifbutton = new System.Windows.Forms.Button();
            this.LogsRefreshbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RefreshNotifbutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(13, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 363);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notification List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bunifuiOSSwitch1);
            this.panel2.Controls.Add(this.SendBtn);
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 61);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timer";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(678, 19);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 3;
            this.bunifuiOSSwitch1.Value = false;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // SendBtn
            // 
            this.SendBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.ForeColor = System.Drawing.Color.Gray;
            this.SendBtn.Location = new System.Drawing.Point(115, 32);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "Send Test";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.Color.Gray;
            this.refreshBtn.Location = new System.Drawing.Point(14, 32);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(95, 23);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh/Send";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.LogsRefreshbutton);
            this.panel3.Controls.Add(this.LogsTablePanel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(405, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 364);
            this.panel3.TabIndex = 3;
            // 
            // LogsTablePanel
            // 
            this.LogsTablePanel.AutoScroll = true;
            this.LogsTablePanel.ColumnCount = 1;
            this.LogsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LogsTablePanel.Location = new System.Drawing.Point(9, 53);
            this.LogsTablePanel.Margin = new System.Windows.Forms.Padding(1);
            this.LogsTablePanel.Name = "LogsTablePanel";
            this.LogsTablePanel.RowCount = 1;
            this.LogsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LogsTablePanel.Size = new System.Drawing.Size(325, 305);
            this.LogsTablePanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logs";
            // 
            // sendertimer
            // 
            this.sendertimer.Interval = 5000;
            this.sendertimer.Tick += new System.EventHandler(this.sendertimer_Tick);
            // 
            // RefreshNotifbutton
            // 
            this.RefreshNotifbutton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RefreshNotifbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshNotifbutton.ForeColor = System.Drawing.Color.Gray;
            this.RefreshNotifbutton.Location = new System.Drawing.Point(298, 7);
            this.RefreshNotifbutton.Name = "RefreshNotifbutton";
            this.RefreshNotifbutton.Size = new System.Drawing.Size(75, 23);
            this.RefreshNotifbutton.TabIndex = 5;
            this.RefreshNotifbutton.Text = "Refresh";
            this.RefreshNotifbutton.UseVisualStyleBackColor = true;
            this.RefreshNotifbutton.Click += new System.EventHandler(this.RefreshNotifbutton_Click);
            // 
            // LogsRefreshbutton
            // 
            this.LogsRefreshbutton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.LogsRefreshbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsRefreshbutton.ForeColor = System.Drawing.Color.Gray;
            this.LogsRefreshbutton.Location = new System.Drawing.Point(258, 6);
            this.LogsRefreshbutton.Name = "LogsRefreshbutton";
            this.LogsRefreshbutton.Size = new System.Drawing.Size(75, 23);
            this.LogsRefreshbutton.TabIndex = 6;
            this.LogsRefreshbutton.Text = "Refresh";
            this.LogsRefreshbutton.UseVisualStyleBackColor = true;
            this.LogsRefreshbutton.Click += new System.EventHandler(this.LogsRefreshbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "ServiceID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(123, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(270, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel LogsTablePanel;
        private System.Windows.Forms.Timer sendertimer;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private System.Windows.Forms.Button RefreshNotifbutton;
        private System.Windows.Forms.Button LogsRefreshbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}