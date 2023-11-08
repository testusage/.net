using System;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create conn
            String connString = "Data Source=DESKTOP-NVND1RL\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //Select Command
            SqlCommand cmd = new SqlCommand("select * from student",conn);

            //Open conn
            conn.Open();

            //Delete
            String query3 = "Delete from student where stuID = '105'";
            SqlCommand command3 = new SqlCommand(query3,conn);
            command3.ExecuteNonQuery();
            

            //Data Reader
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
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

//Insert
/*String query = "Insert into student (StuID , StudName , Course , Semester) Values(@StuID , @StudName , @Course , @Semester)";
SqlCommand command = new SqlCommand(query, conn);

command.Parameters.Add("@StuID", "115");
command.Parameters.Add("@StudName", "Faiz");
command.Parameters.Add("@Course", ".Net");
command.Parameters.Add("@Semester", "7");
command.ExecuteNonQuery();*/


//Update
/*String query2 = "Update Student Set StudName = 'Zuckerberg' Where StuID = '100'";
SqlCommand command2 = new SqlCommand(query2, conn);
command2.ExecuteNonQuery();*/
