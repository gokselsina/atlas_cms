using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace atlas
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }
        int verify_code;
        string name,surname,email,username,password,gender="Male";
        Random rnd = new Random();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q0CBJCI\\SQLEXPRESS;Initial Catalog=atlas;Integrated Security=True");

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                if (textBox5.Text == textBox6.Text)
                {
                    if (textBox3.Text.Contains("@") == true)
                    {
                        name = textBox1.Text;
                        surname = textBox2.Text;
                        email = textBox3.Text;
                        username = textBox4.Text;
                        password = textBox6.Text;
                        

                        // doğrulama kodu oluşturma
                        verify_code = rnd.Next(100000, 1000000);
                        MailMessage mesaj = new MailMessage(); // Mail sınıfından bir değişken türetiyoruz
                        mesaj.From = new MailAddress("atlascinemasystem@gmail.com");
                        mesaj.To.Add(email);
                        mesaj.Subject = "Verify Code";
                        mesaj.Body = "Your Verification Code : " + verify_code.ToString();
                        SmtpClient rc = new SmtpClient();

                        // Gönderenin eposta giriş bilgileri
                        rc.Credentials = new System.Net.NetworkCredential("atlascinemasystem@gmail.com", "Heaven.7");
                        rc.Port = 587;
                        rc.Host = "smtp.gmail.com";
                        rc.EnableSsl = true;
                        object userState = mesaj;
                        try
                        {
                            rc.SendAsync(mesaj, (object)mesaj);
                            MessageBox.Show("Verification code sent to your email address");
                            panel2.Visible = true;
                            panel2.BringToFront();

                            panel1.Visible = false;
                        }
                        catch (SmtpException ex)
                        {
                            MessageBox.Show(ex.Message, "Error sending mail");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error sending mail, check your email address");
                    }
                }
                else
                {
                    MessageBox.Show("Error, passwords not the same");
                }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void Signin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Signin_FormClosing(object sender, FormClosingEventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // doğrulama kodu oluşturma
                verify_code = rnd.Next(100000, 1000000);
                MailMessage mesaj = new MailMessage(); // Mail sınıfından bir değişken türetiyoruz
                mesaj.From = new MailAddress("atlascinemasystem@gmail.com");
                mesaj.To.Add(email);
                mesaj.Subject = "Verify Code";
                mesaj.Body = "Your Verification Code : " + verify_code.ToString();
                SmtpClient rc = new SmtpClient();

                // Gönderenin eposta giriş bilgileri
                rc.Credentials = new System.Net.NetworkCredential("atlascinemasystem@gmail.com", "Heaven.7");
                rc.Port = 587;
                rc.Host = "smtp.gmail.com";
                rc.EnableSsl = true;
                object userState = mesaj;
                try
                {
                    rc.SendAsync(mesaj, (object)mesaj);
                    MessageBox.Show("Verification code sent to your email address");
                    panel2.Visible = true;
                    panel2.BringToFront();

                    panel1.Visible = false;
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show(ex.Message, "Error sending mail");
                }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == verify_code.ToString())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO accounts (username,password,administrator) VALUES ('" + username + "','" + password + "','False')", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO user_info (name,surname,email,gender,balance) VALUES ('" + name + "','" + surname + "','"+email+"','"+gender+"','"+0+"')", con);
                cmd2.ExecuteNonQuery();
                con.Close(); 
                MessageBox.Show("Registration completed");
                login login = new login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verification code incorrect");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
