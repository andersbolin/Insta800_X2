using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccess
    {

        /// <summary>
        /// This method returns the number of objects in the database as an integer.
        /// </summary>
        /// <returns></returns>
        public static int TrainDBCount()
        {
            String connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\TrainDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand selectCommand = new SqlCommand("SELECT COUNT(*) FROM Table1", con);
            Int32 count = (Int32)selectCommand.ExecuteScalar();
            con.Close();
            return count;
        }
        /// <summary>
        /// Method creates a row in the Train DataBase by reading train object and storing each variable in the DB
        /// </summary>
        /// <param name="typ"></param>
        /// <param name="chair1dust"></param>
        /// <param name="chair1spots"></param>
        /// <param name="chair1garbage"></param>
        /// <param name="chair2dust"></param>
        /// <param name="chair2spots"></param>
        /// <param name="chair2garbage"></param>
        /// <param name="chair3dust"></param>
        /// <param name="chair3spots"></param>
        /// <param name="chair3garbage"></param>
        /// <param name="extradust"></param>
        /// <param name="extraspots"></param>
        /// <param name="extragarbage"></param>
        /// <param name="extraname"></param>
        /// <param name="wagonnumber"></param>
        /// <param name="chair1"></param>
        /// <param name="chair2"></param>
        /// <param name="chair3"></param>
        /// <param name="trainnumber"></param>
        public static void createrow(string typ, int chair1dust, int chair1spots, int chair1garbage, int chair2dust, int chair2spots, int chair2garbage, int chair3dust, int chair3spots, int chair3garbage, int extradust, int extraspots, int extragarbage, string extraname, int wagonnumber, int chair1, int chair2, int chair3, string trainnumber)
        {
            String connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\TrainDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand("SELECT COUNT(*) FROM Table1", con);
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Table1(ID, TYP, CHAIR1DUST, CHAIR1SPOTS, CHAIR1GARBAGE, CHAIR2DUST, CHAIR2SPOTS, CHAIR2GARBAGE, CHAIR3DUST, CHAIR3SPOTS, CHAIR3GARBAGE, EXTRADUST, EXTRASPOTS, EXTRAGARBAGE, EXTRANAME,  WAGONNUMBER, CHAIR1, CHAIR2, CHAIR3, TRAINNUMBER) values (@val1, @Val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12, @val13, @val14, @val15, @val16, @val17, @val18, @val19, @val20)", con))
                {
                    int count = (int)selectCommand.ExecuteScalar();
                    cmd.Parameters.AddWithValue("@Val1", count + 1);
                    cmd.Parameters.AddWithValue("@Val2", typ);
                    cmd.Parameters.AddWithValue("@Val3", chair1dust);
                    cmd.Parameters.AddWithValue("@Val4", chair1spots);
                    cmd.Parameters.AddWithValue("@Val5", chair1garbage);
                    cmd.Parameters.AddWithValue("@Val6", chair2dust);
                    cmd.Parameters.AddWithValue("@Val7", chair2spots);
                    cmd.Parameters.AddWithValue("@Val8", chair2garbage);
                    cmd.Parameters.AddWithValue("@Val9", chair3dust);
                    cmd.Parameters.AddWithValue("@Val10", chair3spots);
                    cmd.Parameters.AddWithValue("@Val11", chair3garbage);
                    cmd.Parameters.AddWithValue("@Val12", extradust);
                    cmd.Parameters.AddWithValue("@Val13", extraspots);
                    cmd.Parameters.AddWithValue("@Val14", extragarbage);
                    cmd.Parameters.AddWithValue("@Val15", extraname);
                    cmd.Parameters.AddWithValue("@Val16", wagonnumber);
                    cmd.Parameters.AddWithValue("@Val17", chair1);
                    cmd.Parameters.AddWithValue("@Val18", chair2);
                    cmd.Parameters.AddWithValue("@Val19", chair3);
                    cmd.Parameters.AddWithValue("@Val20", trainnumber);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }
        /// <summary>
        /// method clears the Database from entries
        /// </summary>
        public static void deleteTrainData()
        {
            int antal = TrainDBCount();
            String connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\TrainDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connString);
            for (int x = 1; x <= antal; x++)
            {
                SqlCommand insertCommand = new SqlCommand("DELETE Table1 WHERE ID = " + x, con);
                con.Open();
                insertCommand.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// This Method reads all trains currently stored in the DataBase and sends them to the Manager wich creates
        /// each one as a train object in the array.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="typ"></param>
        /// <param name="chair1dust"></param>
        /// <param name="chair1spots"></param>
        /// <param name="chair1garbage"></param>
        /// <param name="chair2dust"></param>
        /// <param name="chair2spots"></param>
        /// <param name="chair2garbage"></param>
        /// <param name="chair3dust"></param>
        /// <param name="chair3spots"></param>
        /// <param name="chair3garbage"></param>
        /// <param name="extradust"></param>
        /// <param name="extraspots"></param>
        /// <param name="extragarbage"></param>
        /// <param name="extraname"></param>
        /// <param name="wagonnumber"></param>
        /// <param name="chair1"></param>
        /// <param name="chair2"></param>
        /// <param name="chair3"></param>
        /// <param name="trainnumber"></param>
        public static void loadTrainData(int row, out string typ, out int chair1dust, out int chair1spots, out int chair1garbage, out int chair2dust, out int chair2spots, out int chair2garbage, out int chair3dust, out int chair3spots, out int chair3garbage, out int extradust, out int extraspots, out int extragarbage, out string extraname, out int wagonnumber, out int chair1, out int chair2, out int chair3, out string trainnumber) 
        {
            string m_typ = "";
            int m_chair1dust = 0;
            int m_chair1spots = 0;
            int m_chair1garbage = 0;
            int m_chair2dust = 0;
            int m_chair2spots = 0;
            int m_chair2garbage = 0;
            int m_chair3dust = 0;
            int m_chair3spots = 0;
            int m_chair3garbage = 0;
            int m_extradust = 0;
            int m_extraspots = 0;
            int m_extragarbage = 0;
            string m_extraname = "";
            int m_wagonnumber = 0;
            int m_chair1 = 0;
            int m_chair2 = 0;
            int m_chair3 = 0;
            string m_trainnumber = ""; 
            int antal = TrainDBCount();
            String connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\TrainDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            using (SqlCommand command = new SqlCommand("SELECT ID, TYP, CHAIR1DUST, CHAIR1SPOTS, CHAIR1GARBAGE, CHAIR2DUST, CHAIR2SPOTS, CHAIR2GARBAGE, CHAIR3DUST, CHAIR3SPOTS, CHAIR3GARBAGE, EXTRADUST, EXTRASPOTS, EXTRAGARBAGE, EXTRANAME, WAGONNUMBER, CHAIR1, CHAIR2, CHAIR3, TRAINNUMBER from Table1 WHERE ID = " + row, con))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    m_typ = reader.GetString(1);
                    m_chair1dust = reader.GetInt32(2);
                    m_chair1spots = reader.GetInt32(3);
                    m_chair1garbage = reader.GetInt32(4);
                    m_chair2dust = reader.GetInt32(5);
                    m_chair2spots = reader.GetInt32(6);
                    m_chair2garbage = reader.GetInt32(7);
                    m_chair3dust = reader.GetInt32(8);
                    m_chair3spots = reader.GetInt32(9);
                    m_chair3garbage = reader.GetInt32(10);
                    m_extradust = reader.GetInt32(11);
                    m_extraspots = reader.GetInt32(12);
                    m_extragarbage = reader.GetInt32(13);
                    m_extraname = reader.GetString(14);
                    m_wagonnumber = reader.GetInt32(15);
                    m_chair1 = reader.GetInt32(16);
                    m_chair2 = reader.GetInt32(17);
                    m_chair3 = reader.GetInt32(18);
                    m_trainnumber = reader.GetString(19);
                }

                typ = m_typ;
                chair1dust = m_chair1dust;
                chair1spots = m_chair1spots;
                chair1garbage = m_chair1garbage;
                chair2dust = m_chair2dust;
                chair2spots = m_chair2spots;
                chair2garbage = m_chair2garbage;
                chair3dust = m_chair3dust;
                chair3spots = m_chair3spots;
                chair3garbage = m_chair3garbage;
                extradust = m_extradust;
                extraspots = m_extraspots;
                extragarbage = m_extragarbage;
                extraname = m_extraname;
                wagonnumber = m_wagonnumber;
                chair1 = m_chair1;
                chair2 = m_chair2;
                chair3 = m_chair3;
                trainnumber = m_trainnumber;
                con.Close();
            }
        }
    }    
}
