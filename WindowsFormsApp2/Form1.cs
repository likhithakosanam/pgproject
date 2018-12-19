using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private object likhitha;
        private object Desktop;

        public Form1()
        {
            InitializeComponent();
        }

        public object Users { get; private set; }

        public void button1_Click_1(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String regNo = textBox2.Text;
            String state = comboBox2.Text;
            String course = comboBox1.Text;
           
            String bsc = RB3.Text;
            String bba = RB4.Text;
            String bcom = RB5.Text;
            DateTime DOB;
            DOB = date1.Value;
           
            if (RB3.Checked)
                RB3.Text = bsc;
            else if (RB4.Checked)
                RB3.Text = bba;
            else if (RB5.Checked)
                RB3.Text = bcom;
            MessageBox.Show("Details saving successful");
            /*String connetionString;
            SqlConnection conn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\likhitha\Documents\hostel1.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("[dbo].[Procedure]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //C:\Users\likhitha\source\repos\WindowsFormsApp4\WindowsFormsApp4\Database1_log.ldf
            cmd.Parameters.AddWithValue("name", textBox1.Text);
            cmd.Parameters.AddWithValue("regno", textBox2.Text);
            cmd.Parameters.AddWithValue("gender", RB1.Text );
            cmd.Parameters.AddWithValue("state", comboBox2.Text);
            cmd.Parameters.AddWithValue("DOB", date1.Value);
            cmd.Parameters.AddWithValue("degree", RB3.Text);
            cmd.Parameters.AddWithValue("course", comboBox1.Text);
            cmd.Parameters.AddWithValue("room", comboBox3.Text);
            conn.Open();
            int s = cmd.ExecuteNonQuery();*/
            String Querry = " INSERT INTO TESTING VALUES('" +textBox1.Text+"','"+textBox2.Text+"');";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\likhitha\Desktop\c# programs\WindowsFormsApp2\WindowsFormsApp2\hostel1.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(Querry, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            Form2 newFrm2 = new Form2();
            newFrm2.Show();
            this.Hide();
        }

        public void RESET_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String regNo = textBox2.Text;
            String state = comboBox2.Text;
            String course = comboBox1.Text;
            String bsc = RB3.Text;
            String bba = RB4.Text;
            String bcom = RB5.Text;
            DateTime DOB;
            DOB = date1.Value;
            //button1_Click_1(object sender, EventArgs e);
            //RESET_Click obj = new RESET_Click();
            //obj.button1_Click_1();
            string message = "Do you want to reset everything?";
            string title = "Reset Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
               
                RB3.Checked = false;
                RB4.Checked = false;
                RB5.Checked = false;
                comboBox1.Text="";
                comboBox2.Text = "";
               
            }
            else
            {
                textBox1.Text = name;
                textBox2.Text = regNo;
                comboBox1.Text= course;
                comboBox2.Text = state;
                if (RB3.Checked)
                    RB3.Text = bsc;
                else if(RB4.Checked)
                    RB3.Text = bba;
                else if (RB5.Checked)
                    RB3.Text = bcom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String regNo =textBox2.Text;
            String state = comboBox2.Text;
            String course = comboBox1.Text;
            String bsc = RB3.Text;
            String bba = RB4.Text;
            String bcom = RB5.Text;
            DateTime DOB;
            DOB = date1.Value;
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                textBox1.Text = name;
                textBox2.Text = Convert.ToString(regNo);
                comboBox1.Text = course;
                comboBox2.Text = state;
               
                if (RB3.Checked)
                    RB3.Text = bsc;
                else if (RB4.Checked)
                    RB3.Text = bba;
                else if (RB5.Checked)
                    RB3.Text = bcom;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {}

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RB3.Checked)
            {
                
                    comboBox1.Items.Add("COMPUTER SCIENCE");
                    comboBox1.Items.Add("MATHEMATICS");
                    comboBox1.Items.Add("PHYSICS");
                    comboBox1.Items.Add("CHEMISTRY");
                    comboBox1.Items.Add("BOTANY");
                    comboBox1.Items.Add("ZOOLOGY");
                    comboBox1.Items.Add("STATISTICS");
                
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RB4.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("BUSSINESS STATISTICS");
                comboBox1.Items.Add("BUSSINESS MATHEMATICS");
                comboBox1.Items.Add("TALLY");
                comboBox1.Items.Add("EXCEL");
                comboBox1.Items.Add("ECONOMICS");
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (RB5.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Accountancy");
                comboBox1.Items.Add("Statistics");
                comboBox1.Items.Add("Management");
                comboBox1.Items.Add("Human Resource");
                comboBox1.Items.Add("ECONOMICS");
            }
        }

       /* private void button1_Click_1(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            double regNo = double.Parse(textBox2.Text);
            String state = comboBox2.Text;
            String course = comboBox1.Text;
            String room = comboBox3.Text;
          }*/
    }

    internal class RESET_Click
    {
    }

    internal class button1_Click_1
    {
    }
}
