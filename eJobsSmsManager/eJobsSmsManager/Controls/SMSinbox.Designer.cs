namespace eJobsSmsManager.Controls
{
    partial class SMSinbox
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
            this.MsgRecipient = new System.Windows.Forms.Label();
            this.MsgCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.MsgContent = new System.Windows.Forms.Label();
            this.MsgDateTime = new System.Windows.Forms.Label();
            this.MsgStatus = new System.Windows.Forms.Label();
            this.MsgId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MsgRecipient
            // 
            this.MsgRecipient.AutoSize = true;
            this.MsgRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MsgRecipient.Location = new System.Drawing.Point(45, 20);
            this.MsgRecipient.Name = "MsgRecipient";
            this.MsgRecipient.Size = new System.Drawing.Size(67, 17);
            this.MsgRecipient.TabIndex = 0;
            this.MsgRecipient.Text = "Recipient";
            // 
            // MsgCheckbox
            // 
            this.MsgCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MsgCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MsgCheckbox.Checked = false;
            this.MsgCheckbox.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.MsgCheckbox.ForeColor = System.Drawing.Color.White;
            this.MsgCheckbox.Location = new System.Drawing.Point(15, 19);
            this.MsgCheckbox.Name = "MsgCheckbox";
            this.MsgCheckbox.Size = new System.Drawing.Size(20, 20);
            this.MsgCheckbox.TabIndex = 1;
            // 
            // MsgContent
            // 
            this.MsgContent.AutoSize = true;
            this.MsgContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MsgContent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgContent.Location = new System.Drawing.Point(46, 38);
            this.MsgContent.MaximumSize = new System.Drawing.Size(100, 15);
            this.MsgContent.Name = "MsgContent";
            this.MsgContent.Size = new System.Drawing.Size(58, 15);
            this.MsgContent.TabIndex = 2;
            this.MsgContent.Text = "Message";
            // 
            // MsgDateTime
            // 
            this.MsgDateTime.AutoSize = true;
            this.MsgDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MsgDateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgDateTime.Location = new System.Drawing.Point(259, 5);
            this.MsgDateTime.Name = "MsgDateTime";
            this.MsgDateTime.Size = new System.Drawing.Size(77, 15);
            this.MsgDateTime.TabIndex = 3;
            this.MsgDateTime.Text = "MM/dd/YYYY";
            // 
            // MsgStatus
            // 
            this.MsgStatus.AutoSize = true;
            this.MsgStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MsgStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgStatus.Location = new System.Drawing.Point(276, 37);
            this.MsgStatus.Name = "MsgStatus";
            this.MsgStatus.Size = new System.Drawing.Size(41, 15);
            this.MsgStatus.TabIndex = 4;
            this.MsgStatus.Text = "Status";
            // 
            // MsgId
            // 
            this.MsgId.AutoSize = true;
            this.MsgId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MsgId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MsgId.Location = new System.Drawing.Point(47, -1);
            this.MsgId.Name = "MsgId";
            this.MsgId.Size = new System.Drawing.Size(41, 15);
            this.MsgId.TabIndex = 5;
            this.MsgId.Text = "Status";
            this.MsgId.Visible = false;
            // 
            // SMSinbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MsgId);
            this.Controls.Add(this.MsgStatus);
            this.Controls.Add(this.MsgDateTime);
            this.Controls.Add(this.MsgContent);
            this.Controls.Add(this.MsgCheckbox);
            this.Controls.Add(this.MsgRecipient);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SMSinbox";
            this.Size = new System.Drawing.Size(347, 62);
            this.Load += new System.EventHandler(this.SMSinbox_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SMSinbox_MouseClick);
            this.MouseEnter += new System.EventHandler(this.SMSinbox_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SMSinbox_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MsgRecipient;
        private Bunifu.Framework.UI.BunifuCheckbox MsgCheckbox;
        private System.Windows.Forms.Label MsgContent;
        private System.Windows.Forms.Label MsgDateTime;
        private System.Windows.Forms.Label MsgStatus;
        private System.Windows.Forms.Label MsgId;
    }
}
