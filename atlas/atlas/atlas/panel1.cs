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
    public partial class panel1 : Form
    {
        public panel1()
        {
            InitializeComponent();
        }

        int active_seat, seat_no, price, balance;
        string seat_gender, gender;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q0CBJCI\\SQLEXPRESS;Initial Catalog=atlas;Integrated Security=True");
        DataSet ds;
        bool seatctrl = true;

        void refinfo()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM user_info WHERE id='" + login.id + "'", con);
            ds = new DataSet();
            da.Fill(ds, "user");
            gender = ds.Tables["user"].Rows[0]["gender"].ToString();
            balance = Convert.ToInt32(ds.Tables["user"].Rows[0]["balance"]);
            labelBalance.Text = balance.ToString() + "$";
            con.Close();
        }

        void refform()
        {
            refinfo();
            con.Open();
            
            
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM seats WHERE saloon_no='" + saloon.saloon_no + "'", con);
            int list = Convert.ToInt32(cmd.ExecuteScalar());
            if (list > 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM seats WHERE saloon_no='" + saloon.saloon_no + "'", con);
                ds = new DataSet();
                da.Fill(ds, "seats");
                for (int i = 0; i < list; i++)
                {
                    seat_no = Convert.ToInt32(ds.Tables["seats"].Rows[i]["seat_no"]);
                    seat_gender = ds.Tables["seats"].Rows[i]["gender"].ToString();
                    switch (seat_no)
                    {
                        case 1:
                            if (seat_gender == "Male")
                            {
                                button1.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button1.BackColor = Color.LightPink;
                            }
                            break;

                        case 2:
                            if (seat_gender == "Male")
                            {
                                button2.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button2.BackColor = Color.LightPink;
                            }
                            break;
                        case 3:
                            if (seat_gender == "Male")
                            {
                                button3.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button3.BackColor = Color.LightPink;
                            }
                            break;
                        case 4:
                            if (seat_gender == "Male")
                            {
                                button4.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button4.BackColor = Color.LightPink;
                            }
                            break;
                        case 5:
                            if (seat_gender == "Male")
                            {
                                button5.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button5.BackColor = Color.LightPink;
                            }
                            break;
                        case 6:
                            if (seat_gender == "Male")
                            {
                                button6.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button6.BackColor = Color.LightPink;
                            }
                            break;
                        case 7:
                            if (seat_gender == "Male")
                            {
                                button7.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button7.BackColor = Color.LightPink;
                            }
                            break;
                        case 8:
                            if (seat_gender == "Male")
                            {
                                button8.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button8.BackColor = Color.LightPink;
                            }
                            break;
                        case 9:
                            if (seat_gender == "Male")
                            {
                                button9.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button9.BackColor = Color.LightPink;
                            }
                            break;
                        case 10:
                            if (seat_gender == "Male")
                            {
                                button10.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button10.BackColor = Color.LightPink;
                            }
                            break;
                        case 11:
                            if (seat_gender == "Male")
                            {
                                button11.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button11.BackColor = Color.LightPink;
                            }
                            break;
                        case 12:
                            if (seat_gender == "Male")
                            {
                                button12.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button12.BackColor = Color.LightPink;
                            }
                            break;
                        case 13:
                            if (seat_gender == "Male")
                            {
                                button13.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button13.BackColor = Color.LightPink;
                            }
                            break;
                        case 14:
                            if (seat_gender == "Male")
                            {
                                button14.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button14.BackColor = Color.LightPink;
                            }
                            break;
                        case 15:
                            if (seat_gender == "Male")
                            {
                                button15.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button15.BackColor = Color.LightPink;
                            }
                            break;
                        case 16:
                            if (seat_gender == "Male")
                            {
                                button16.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button16.BackColor = Color.LightPink;
                            }
                            break;
                        case 17:
                            if (seat_gender == "Male")
                            {
                                button17.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button17.BackColor = Color.LightPink;
                            }
                            break;
                        case 18:
                            if (seat_gender == "Male")
                            {
                                button18.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button18.BackColor = Color.LightPink;
                            }
                            break;
                        case 19:
                            if (seat_gender == "Male")
                            {
                                button19.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button19.BackColor = Color.LightPink;
                            }
                            break;
                        case 20:
                            if (seat_gender == "Male")
                            {
                                button20.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button20.BackColor = Color.LightPink;
                            }
                            break;
                        case 21:
                            if (seat_gender == "Male")
                            {
                                button21.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button21.BackColor = Color.LightPink;
                            }
                            break;
                        case 22:
                            if (seat_gender == "Male")
                            {
                                button22.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button22.BackColor = Color.LightPink;
                            }
                            break;
                        case 23:
                            if (seat_gender == "Male")
                            {
                                button23.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button23.BackColor = Color.LightPink;
                            }
                            break;
                        case 24:
                            if (seat_gender == "Male")
                            {
                                button24.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button24.BackColor = Color.LightPink;
                            }
                            break;
                        case 25:
                            if (seat_gender == "Male")
                            {
                                button25.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button25.BackColor = Color.LightPink;
                            }
                            break;
                        case 26:
                            if (seat_gender == "Male")
                            {
                                button26.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button26.BackColor = Color.LightPink;
                            }
                            break;
                        case 27:
                            if (seat_gender == "Male")
                            {
                                button27.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button27.BackColor = Color.LightPink;
                            }
                            break;
                        case 28:
                            if (seat_gender == "Male")
                            {
                                button28.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button28.BackColor = Color.LightPink;
                            }
                            break;
                        case 29:
                            if (seat_gender == "Male")
                            {
                                button29.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button29.BackColor = Color.LightPink;
                            }
                            break;
                        case 30:
                            if (seat_gender == "Male")
                            {
                                button30.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button30.BackColor = Color.LightPink;
                            }
                            break;
                        case 31:
                            if (seat_gender == "Male")
                            {
                                button31.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button31.BackColor = Color.LightPink;
                            }
                            break;
                        case 32:
                            if (seat_gender == "Male")
                            {
                                button32.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button32.BackColor = Color.LightPink;
                            }
                            break;
                        case 33:
                            if (seat_gender == "Male")
                            {
                                button33.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button33.BackColor = Color.LightPink;
                            }
                            break;
                        case 34:
                            if (seat_gender == "Male")
                            {
                                button34.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button34.BackColor = Color.LightPink;
                            }
                            break;
                        case 35:
                            if (seat_gender == "Male")
                            {
                                button35.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button35.BackColor = Color.LightPink;
                            }
                            break;
                        case 36:
                            if (seat_gender == "Male")
                            {
                                button36.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button36.BackColor = Color.LightPink;
                            }
                            break;
                        case 37:
                            if (seat_gender == "Male")
                            {
                                button37.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button37.BackColor = Color.LightPink;
                            }
                            break;
                        case 38:
                            if (seat_gender == "Male")
                            {
                                button38.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button38.BackColor = Color.LightPink;
                            }
                            break;
                        case 39:
                            if (seat_gender == "Male")
                            {
                                button39.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button39.BackColor = Color.LightPink;
                            }
                            break;
                        case 40:
                            if (seat_gender == "Male")
                            {
                                button40.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button40.BackColor = Color.LightPink;
                            }
                            break;
                        case 41:
                            if (seat_gender == "Male")
                            {
                                button41.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button41.BackColor = Color.LightPink;
                            }
                            break;
                        case 42:
                            if (seat_gender == "Male")
                            {
                                button42.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button42.BackColor = Color.LightPink;
                            }
                            break;
                        case 43:
                            if (seat_gender == "Male")
                            {
                                button43.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button43.BackColor = Color.LightPink;
                            }
                            break;
                        case 44:
                            if (seat_gender == "Male")
                            {
                                button44.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button44.BackColor = Color.LightPink;
                            }
                            break;
                        case 45:
                            if (seat_gender == "Male")
                            {
                                button45.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button45.BackColor = Color.LightPink;
                            }
                            break;
                        case 46:
                            if (seat_gender == "Male")
                            {
                                button46.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button46.BackColor = Color.LightPink;
                            }
                            break;
                        case 47:
                            if (seat_gender == "Male")
                            {
                                button47.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button47.BackColor = Color.LightPink;
                            }
                            break;
                        case 48:
                            if (seat_gender == "Male")
                            {
                                button48.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button48.BackColor = Color.LightPink;
                            }
                            break;
                        case 49:
                            if (seat_gender == "Male")
                            {
                                button49.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button49.BackColor = Color.LightPink;
                            }
                            break;
                        case 50:
                            if (seat_gender == "Male")
                            {
                                button50.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                button50.BackColor = Color.LightPink;
                            }
                            break;
                    } // switch end
                } // for end
            } // if end
            con.Close();
        }

        private void Panel1_Load(object sender, EventArgs e)
        {
            if (login.admin == "admin")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            refform();
            label2.Text = "SALOON " + saloon.saloon_no.ToString();
        }

        private void Panel1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Panel1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            active_seat = 1;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            active_seat = 2;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            active_seat = 3;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            active_seat = 4;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            active_seat = 5;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            active_seat = 6;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            active_seat = 7;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            active_seat = 8;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            active_seat = 9;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            active_seat = 10;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            active_seat = 11;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            active_seat = 12;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            active_seat = 13;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            active_seat = 14;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            active_seat = 15;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            active_seat = 16;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            active_seat = 17;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            active_seat = 18;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            active_seat = 19;
            labelSeat.Text = active_seat.ToString(); 
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            active_seat = 20;
            labelSeat.Text = active_seat.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            saloon saloon = new saloon();
            saloon.Show();
            this.Hide();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            active_seat = 21;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            active_seat = 22;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            active_seat = 23;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            active_seat = 24;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            active_seat = 25;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            active_seat = 26;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            active_seat = 27;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            active_seat = 31;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            active_seat = 32;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            active_seat = 33;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            active_seat = 34;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            active_seat = 35;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            active_seat = 36;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            active_seat = 37;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            active_seat = 38;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            active_seat = 39;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            active_seat = 40;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            active_seat = 41;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            active_seat = 42;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            active_seat = 43;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            active_seat = 44;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            active_seat = 45;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            active_seat = 46;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            active_seat = 47;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            active_seat = 48;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            active_seat = 49;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            active_seat = 50;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            active_seat = 28;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            active_seat = 29;
            labelSeat.Text = active_seat.ToString();
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            active_seat = 30;
            labelSeat.Text = active_seat.ToString();
        }

        void seat_ctrl(int a)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM seats WHERE saloon_no = '"+saloon.saloon_no+"' AND seat_no = '"+a+"'", con);
            int selectedseatcontrol = Convert.ToInt32(cmd.ExecuteScalar());
            if (selectedseatcontrol > 0)
            {
                seatctrl = false;
            }
            else
            {
                seatctrl = true;
            }
            con.Close();
        }

        private void Button51_Click(object sender, EventArgs e)
        {
            refinfo();
            
            if (price <= balance)
            {
                seat_ctrl(active_seat);
                if (login.admin == "admin")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO seats (saloon_no,seat_no,id,gender) VALUES (@p1,@p2,@p3,@p4)", con);
                    cmd.Parameters.AddWithValue("@p1", saloon.saloon_no);
                    cmd.Parameters.AddWithValue("@p2", active_seat);
                    cmd.Parameters.AddWithValue("@p3", login.id);
                    if (radioButton1.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    cmd.Parameters.AddWithValue("@p4", gender);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    refinfo();
                    refform();
                }
                else if (seatctrl == true)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO seats (saloon_no,seat_no,id,gender) VALUES (@p1,@p2,@p3,@p4)", con);
                    cmd.Parameters.AddWithValue("@p1", saloon.saloon_no);
                    cmd.Parameters.AddWithValue("@p2", active_seat);
                    cmd.Parameters.AddWithValue("@p3", login.id);
                    cmd.Parameters.AddWithValue("@p4", gender);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("UPDATE user_info SET balance=balance-" + price + " WHERE id='" + login.id + "'", con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    refinfo();
                    refform();
                }
                else
                {
                    MessageBox.Show("Selected seat is full");
                }
            }
            
            else
            {
                MessageBox.Show("Balance is not enought");
            }
        }
    }
}
