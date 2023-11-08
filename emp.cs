using System;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp1
{
    internal class dbconnectivity
    {
        static void Main()
        {
            // 1. Create Connection
            string connString = "Data Source=DESKTOP-NVND1RL\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            // 2. Create a Select/Update etc Commands
            SqlCommand cmd = new SqlCommand("select * from employee", conn);

            // 3. Open connection
            conn.Open();


            //Insert
            String query = "INSERT INTO EMPLOYEE (EMPID , EMPNAME) VALUES(@EMPID,@EMPNAME)";

            SqlCommand command = new SqlCommand(query,conn);
            command.Parameters.Add("@EMPID","115");
            command.Parameters.Add("@EMPNAME","KHAN");
            command.ExecuteNonQuery();

            // 5. As it's a Select command, use a data reader
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine("");
            }

            // 6. Close Connection
            conn.Close();

            Console.ReadKey();
        }
    }
}



// 4. Insert
/*string query = "INSERT INTO Employee (EmpID, EmpName) VALUES (@EmpID, @EmpName)";
SqlCommand command = new SqlCommand(query, conn);

command.Parameters.AddWithValue("@EmpID", "103");
command.Parameters.AddWithValue("@EmpName", "Jeevan");
command.ExecuteNonQuery();*/

// 5. Update
/*String query2 = "UPDATE EMPLOYEE SET EMPID = '888', EMPNAME = 'FaizV2' WHERE EMPID = '100'";
SqlCommand command2 = new SqlCommand(query2, conn);
command2.ExecuteNonQuery();*/

// 6. Delete
/*SqlCommand Command3 = new SqlCommand("DELETE FROM EMPLOYEE WHERE EMPID='1234'", conn);
Command3.ExecuteNonQuery();*/
