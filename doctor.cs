using System;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create conn
            String connString = "Data Source=DESKTOP-NVND1RL\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //Open conn
            conn.Open();

            //Insert
            String query = "insert into doctor (DoctorID , DoctorName , Department , Fees) Values(@DoctorID , @DoctorName , @Department , @Fees)";
            SqlCommand command1 = new SqlCommand(query, conn);

            command1.Parameters.Add("@DoctorId",16);
            command1.Parameters.Add("@DoctorName", "D");
            command1.Parameters.Add("@Department", "ECE");
            command1.Parameters.Add("@Fees", 7000);

            command1.ExecuteNonQuery();

            //Select
            SqlCommand cmd = new SqlCommand("select * from doctor",conn);

            //Data Reader
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine("");
            }

            //Close conn
            conn.Close();

            Console.ReadKey();
            
        }
    }
}

-------------------------------------------------------

using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class dbconnectivity
    {
        static void Main()
        {
            // 1. Create Connection
            string connString = "Data Source=DESKTOP-NVND1RL\\SQLEXPRESS;Initial Catalog=YourDatabaseName;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            // 2. Create a Select Command
            SqlCommand cmd = new SqlCommand("SELECT Doctor_name, Doctor_ID, Department, Days_of_availability, Consultation_fees FROM Doctor", conn);

            // 3. Open connection
            conn.Open();

            // 4. Use SqlDataReader to fetch and display doctor details
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"Doctor Name: {dr["Doctor_name"]}");
                Console.WriteLine($"Doctor ID: {dr["Doctor_ID"]}");
                Console.WriteLine($"Department: {dr["Department"]}");
                Console.WriteLine($"Days of Availability: {dr["Days_of_availability"]}");
                Console.WriteLine($"Consultation Fees: {dr["Consultation_fees"]}");
                Console.WriteLine("");
            }

            // 5. Close Connection
            conn.Close();

            Console.ReadKey();
        }
    }
}
