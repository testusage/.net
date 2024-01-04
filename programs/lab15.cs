using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-NVND1RL\\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string query = "INSERT INTO Library (BookID, BookTitle, AuthorsName, Publisher, YearOfPublication, Quantity , Department)VALUES(@BookID, @BookTitle, @AuthorsName, @Publisher, @YearOfPublication, @Quantity, @Department)";
            SqlCommand insertCommand = new SqlCommand(query, conn);

            insertCommand.Parameters.AddWithValue("@BookID",TextBox1.Text);
            insertCommand.Parameters.AddWithValue("@BookTitle",TextBox2.Text);
            insertCommand.Parameters.AddWithValue("@AuthorsName",TextBox3.Text);
            insertCommand.Parameters.AddWithValue("@Publisher",TextBox4.Text);
            insertCommand.Parameters.AddWithValue("@YearOfPublication",TextBox5.Text);
            insertCommand.Parameters.AddWithValue("@Quantity",TextBox6.Text);
            if (RadioButton1.Checked)
            {
                insertCommand.Parameters.AddWithValue("@Department", RadioButton1.Text);
            }
            else if (RadioButton2.Checked)
            {
                insertCommand.Parameters.AddWithValue("@Department", RadioButton2.Text);
            }
            else if (RadioButton3.Checked)
            {
                insertCommand.Parameters.AddWithValue("@Department", RadioButton3.Text);
            }
            insertCommand.ExecuteNonQuery();
            conn.Close();
            Response.Write(TextBox1.Text + " Book details saved Successfully!");
        }
    }
}
