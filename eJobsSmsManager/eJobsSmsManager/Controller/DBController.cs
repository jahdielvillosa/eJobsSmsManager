using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eJobsSmsManager.Model;
using System.Data;
using System.Data.SqlClient;

namespace eJobsSmsManager.Controller
{
    class DBController
    {
        public void setData()
        {
            string dbcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Villosa\\Documents\\eJobsManagerDB.mdf;Integrated Security=True;";
            string sample = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            SqlConnection sqlConnection1 = new SqlConnection(dbcon);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Insert into Notifications (Id,svcId,Msg,Recpt,JobId,Status) values(1,'1','hello','09123123213','1','Sent')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            /*while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(0));
            }
            // Data is accessible through the DataReader object here.
            */
            sqlConnection1.Close();
        }

        public void insert()
        {
            /*
            string dbcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Villosa\\Documents\\eJobsManagerDB.mdf;Integrated Security=True;";
            string sample = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            SqlConnection sqlConnection1 = new SqlConnection(dbcon);
            SqlCommand cmd;
            SqlDataReader reader;

            sqlConnection1.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "Insert into Notifications (Id,svcId,Msg,Recpt,JobId,Status) values(1,'1','hello','09123123213','1','Sent')";
            cmd = new SqlCommand(sql, sqlConnection1);

            adapter.InsertCommand = new SqlCommand(sql, sqlConnection1);
            adapter.InsertCommand.ExecuteNonQuery();

            /*while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(0));
            }
            // Data is accessible through the DataReader object here.
            
            cmd.Dispose();
            sqlConnection1.Close();
            */
        }

        public void open()
        {
            string connetionString = null;
            SqlConnection cnn ;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Villosa\\Documents\\eJobsManagerDB.mdf;Integrated Security=True;";
            cnn = new SqlConnection(connetionString);
            try {
                cnn.Open();
                Console.WriteLine("Connection Open ! ");
                cnn.Close();
            } catch (Exception ex) {
                Console.WriteLine("Can not open connection ! ");
            }
        }


    }
}
