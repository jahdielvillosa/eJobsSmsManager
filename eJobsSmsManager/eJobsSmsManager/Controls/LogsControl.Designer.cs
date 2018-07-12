namespace eJobsSmsManager.Controls
{
    partial class LogsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServiceIDlabel = new System.Windows.Forms.Label();
            this.Clientlabel = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.notificationlabel = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ServiceIDlabel
            // 
            this.ServiceIDlabel.AutoSize = true;
            this.ServiceIDlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceIDlabel.Location = new System.Drawing.Point(14, 13);
            this.ServiceIDlabel.Name = "ServiceIDlabel";
            this.ServiceIDlabel.Size = new System.Drawing.Size(21, 17);
            this.ServiceIDlabel.TabIndex = 0;
            this.ServiceIDlabel.Text = "ID";
            // 
            // Clientlabel
            // 
            this.Clientlabel.AutoSize = true;
            this.Clientlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientlabel.Location = new System.Drawing.Point(49, 13);
            this.Clientlabel.Name = "Clientlabel";
            this.Clientlabel.Size = new System.Drawing.Size(46, 17);
            this.Clientlabel.TabIndex = 1;
            this.Clientlabel.Text = "Client";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslabel.Location = new System.Drawing.Point(236, 13);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(46, 17);
            this.Statuslabel.TabIndex = 2;
            this.Statuslabel.Text = "Status";
            // 
            // notificationlabel
            // 
            this.notificationlabel.AutoSize = true;
            this.notificationlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationlabel.Location = new System.Drawing.Point(137, 14);
            this.notificationlabel.Name = "notificationlabel";
            this.notificationlabel.Size = new System.Drawing.Size(21, 17);
            this.notificationlabel.TabIndex = 3;
            this.notificationlabel.Text = "ID";
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.StatusPanel.Location = new System.Drawing.Point(-12, -9);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(326, 11);
            this.StatusPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(-10, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 11);
            this.panel1.TabIndex = 5;
            // 
            // LogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.notificationlabel);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.Clientlabel);
            this.Controls.Add(this.ServiceIDlabel);
            this.Name = "LogsControl";
            this.Size = new System.Drawing.Size(295, 44);
            this.Load += new System.EventHandler(this.LogsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceIDlabel;
        private System.Windows.Forms.Label Clientlabel;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label notificationlabel;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
