using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace atlas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q0CBJCI\\SQLEXPRESS;Initial Catalog=atlas;Integrated Security=True");
        DataSet ds;
        public static int id;
        public static string admin;
        string password;
        int administrator;
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox1.Text.Contains("=") == true)
            {
                MessageBox.Show("Incorrect character entered");
                textBox1.Clear();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM accounts WHERE username='" + textBox1.Text + "'", con);
                int username_test = Convert.ToInt32(cmd.ExecuteScalar());
                if (username_test == 0)
                {
                    MessageBox.Show("Username not found");
                }
                else
                {
                    admin = textBox1.Text;
                    SqlDataAdapter da = new SqlDataAdapter("Select * from accounts Where username='" + textBox1.Text + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "user");
                    id = Convert.ToInt32(ds.Tables["user"].Rows[0]["id"]);
                    password = Convert.ToString(ds.Tables["user"].Rows[0]["password"]);
                    administrator = Convert.ToInt32(ds.Tables["user"].Rows[0]["administrator"]);



                    button2.Visible = true;
                    button1.Visible = false;

                    textBox1.Clear();
                    textBox2.Clear();

                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;

                    AcceptButton = button2;

                    textBox2.Visible = true;
                    textBox1.Visible = false;

                    textBox2.Focus();
                }
            }
            con.Close();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("=") == true)
            {
                MessageBox.Show("Incorrect character entered");
                textBox2.Clear();
            }
            else
            {
                if (password == textBox2.Text)
                {
                    saloon saloon = new saloon();
                    saloon.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    textBox2.Clear();
                    button3.Visible = true;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;

            pictureBox2.Visible = true;
            pictureBox3.Visible = false;

            AcceptButton = button1;

            textBox1.Visible = true;
            textBox2.Visible = false;

            textBox1.Focus();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;

            AcceptButton = button1;

            textBox1.Visible = true;
            textBox2.Visible = false;

            textBox1.Focus();

            signin signin = new signin();
            signin.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
