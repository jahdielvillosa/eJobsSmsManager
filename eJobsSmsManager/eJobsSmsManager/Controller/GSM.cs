using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting.Channels;
using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.Server;
using System.Globalization;

namespace eJobsSmsManager.Controller
{
    class GSM
    {

        private GsmCommMain comm;
        private delegate void SetTextCallback(string text);
        private SmsServer smsServer;

        //Send message to the number and message
        public bool GSMSend(string RecieverNumber, string txtMessage)
        {
            bool sendSuccess = false;
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    SmsSubmitPdu pdu;
                    byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                    pdu = new SmsSubmitPdu(txtMessage, Convert.ToString(RecieverNumber), dcs);
                    int times = 1;
                    for (int i = 0; i < times; i++)
                    {
                        comm.SendMessage(pdu);
                    }
                    //MessageBox.Show("SMS sent");
                    //Console.WriteLine("SMS SENT SUCCESSFUL");
                    sendSuccess = true;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Modem is not available" + ex.ToString());
                    Console.WriteLine("Modem is not available: " + ex.ToString());
                    sendSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SMS SENDING FAILED: " + ex.ToString());
                // MessageBox.Show("SMS not send");
                // Console.WriteLine("SMS SENDING FAILED");
                sendSuccess = false;
            }

            return sendSuccess;
        }

        //Connect the selected port number of the GSM modem
        public bool PortConnect(string selectedPort)
        {
            bool isConnected = false;
            try
            {
                comm = new GsmCommMain(selectedPort, 19200, 150);
            }
            catch (Exception ex)
            {
                Console.WriteLine("PORT CONNECT ERROR:" + ex.ToString());
            }

            Cursor.Current = Cursors.Default;
            bool retry;

            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    Cursor.Current = Cursors.Default;
                    //MessageBox.Show("Modem Connected Sucessfully");
                    Console.WriteLine("Modem Connected Sucessfully"); ;
                    isConnected = true;
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(selectedPort, "GSM Modem is not available: " + ex.ToString(),
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        Console.WriteLine("reconnecting to GSM Modem");
                        retry = true; //set true to loop and try again
                        isConnected = false;
                    }
                    else
                    {
                        isConnected = false;
                        return isConnected;
                    }
                }
            }
            while (retry);

            return isConnected;
        }

        public void closeConnection()
        {
            try
            {

            comm.Close();

            }
            catch (Exception ex )
            {
                Console.WriteLine(ex);
            }
        }
    }
}
