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
    public partial class saloon : Form
    {
        public saloon()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q0CBJCI\\SQLEXPRESS;Initial Catalog=atlas;Integrated Security=True");
        DataSet ds;

        public static string movie1;
        public static string movie2;
        public static string movie3;
        public static string movie4;
        public static string movie5;
        public static string movie6;
        public static string movie7;
        public static string movie8;
        public static string movie9;
        public static bool started1;
        public static bool started2;
        public static bool started3;
        public static bool started4;
        public static bool started5;
        public static bool started6;
        public static bool started7;
        public static bool started8;
        public static bool started9;
        public static int saloon_no=0;
        string mvname = "";
        panel1 seats = new panel1();
        int hour = DateTime.Now.TimeOfDay.Hours;
        int minute = DateTime.Now.TimeOfDay.Minutes;
        int seshour;
        int timenow;
        int slnno;
        string sestime;


        void saloon_status()
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM session", con);
            int sess = Convert.ToInt32(cmd2.ExecuteScalar());
            if (sess > 0)
            {
                SqlDataAdapter adaptr = new SqlDataAdapter("SELECT * FROM session", con);
                ds = new DataSet();
                adaptr.Fill(ds, "sessions");
                for (int i=0;i<sess;i++)
                {
                    slnno  = Convert.ToInt32(ds.Tables["sessions"].Rows[i]["saloon_no"]);
                    sestime = ds.Tables["sessions"].Rows[i]["session"].ToString();
                    seshour = Convert.ToInt32(sestime[0].ToString() + sestime[1].ToString() + sestime[3].ToString() + sestime[4].ToString());
                    if (minute < 10)
                    {
                        timenow = Convert.ToInt32(hour.ToString() + "0" + minute.ToString());
                    }
                    else
                    {
                        timenow = Convert.ToInt32(hour.ToString() + minute.ToString());
                    }
                    if (seshour <= timenow && (seshour + 300) > timenow)
                    {

                        SqlCommand cmd = new SqlCommand("UPDATE session SET ctrl='1' WHERE saloon_no='"+slnno+"'", con);
                        cmd.ExecuteNonQuery();
                        if (slnno == 1)
                        {
                            movie1 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();                         
                            pictureBox12.Visible = true;
                            pictureBox2.Visible = false;
                            saloon1.Enabled = false;
                            pictureBox20.Visible = false;
                        }
                        if (slnno == 2)
                        {
                            movie2 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox13.Visible = true;
                            pictureBox3.Visible = false;
                            saloon2.Enabled = false;
                            started2 = true;
                        }
                        if (slnno == 3)
                        {
                            movie3 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox14.Visible = true;
                            pictureBox4.Visible = false;
                            saloon3.Enabled = false;
                            started3 = true;
                        }
                        if (slnno == 4)
                        {
                            movie4 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox15.Visible = true;
                            pictureBox5.Visible = false;
                            saloon4.Enabled = false;
                            started4 = true;
                        }
                        if (slnno == 5)
                        {
                            movie5 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox16.Visible = true;
                            pictureBox6.Visible = false;
                            saloon5.Enabled = false;
                            started5 = true;
                        }
                        if (slnno == 6)
                        {
                            movie6 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox17.Visible = true;
                            pictureBox7.Visible = false;
                            saloon6.Enabled = false;
                            started6 = true;
                        }
                        if (slnno == 7)
                        {
                            movie7 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox18.Visible = true;
                            pictureBox8.Visible = false;
                            saloon7.Enabled = false;
                            started7 = true;
                        }
                        if (slnno == 8)
                        {
                            movie8 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox19.Visible = true;
                            pictureBox9.Visible = false;
                            saloon8.Enabled = false;
                            started8 = true;
                        }
                        if (slnno == 9)
                        {
                            movie9 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox21.Visible = true;
                            pictureBox10.Visible = false;
                            saloon9.Enabled = false;
                            started9 = true;
                        }
                    }
                    else if (seshour - 100 <= timenow && seshour > timenow)
                    {                      
                        if (slnno == 1)
                        {
                            movie1 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox20.Visible = true;
                            pictureBox12.Visible = false;
                            pictureBox2.Visible = false;
                            saloon1.Enabled = true;
                        }
                        if (slnno == 2)
                        {
                            movie2 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox22.Visible = true;
                            pictureBox13.Visible = false;
                            pictureBox3.Visible = false;
                            saloon2.Enabled = true;
                        }
                        if (slnno == 3)
                        {
                            movie3 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox23.Visible = true;
                            pictureBox14.Visible = false;
                            pictureBox4.Visible = false;
                            saloon3.Enabled = true;
                        }
                        if (slnno == 4)
                        {
                            movie4 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox24.Visible = true;
                            pictureBox15.Visible = false;
                            pictureBox5.Visible = false;
                            saloon4.Enabled = true;
                        }
                        if (slnno == 5)
                        {
                            movie5 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox24.Visible = true;
                            pictureBox16.Visible = false;
                            pictureBox6.Visible = false;
                            saloon5.Enabled = true;
                        }
                        if (slnno == 6)
                        {
                            movie6 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox24.Visible = true;
                            pictureBox17.Visible = false;
                            pictureBox7.Visible = false;
                            saloon6.Enabled = true;
                        }
                        if (slnno == 7)
                        {
                            movie7 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox24.Visible = true;
                            pictureBox18.Visible = false;
                            pictureBox8.Visible = false;
                            saloon7.Enabled = true;
                        }
                        if (slnno == 8)
                        {
                            movie8 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox24.Visible = true;
                            pictureBox19.Visible = false;
                            pictureBox9.Visible = false;
                            saloon8.Enabled = true;
                        }
                        if (slnno == 9)
                        {
                            movie9 = ds.Tables["sessions"].Rows[i]["movie_id"].ToString();
                            pictureBox29.Visible = true;
                            pictureBox21.Visible = false;
                            pictureBox10.Visible = false;
                            saloon9.Enabled = true;
                        }
                    }
                    else
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE saloon_no='"+slnno+"'", con);
                        ds = new DataSet();
                        da.Fill(ds, "ctrl");
                        if (ds.Tables["ctrl"].Rows[0]["ctrl"].ToString() == "1")
                        {
                            stop_mv(slnno);
                            SqlCommand cmd3 = new SqlCommand("UPDATE session SET ctrl='0' WHERE saloon_no='"+slnno+"'", con);
                            cmd3.ExecuteNonQuery();
                        }
                        if (slnno == 1)
                        {
                            movie1 = "-";
                            pictureBox12.Visible = false;
                            pictureBox2.Visible = true;
                            saloon1.Enabled = true;
                            
                        }
                        if (slnno == 2)
                        {
                            movie2 = "-";
                            pictureBox13.Visible = false;
                            pictureBox3.Visible = true;
                            saloon2.Enabled = true;
                           
                        }
                        if (slnno == 3)
                        {
                            movie3 = "-";
                            pictureBox14.Visible = false;
                            pictureBox4.Visible = true;
                            saloon3.Enabled = true;
                            
                        }
                        if (slnno == 4)
                        {
                            movie4 = "-";
                            pictureBox15.Visible = false;
                            pictureBox5.Visible = true;
                            saloon4.Enabled = true;
                            
                        }
                        if (slnno == 5)
                        {
                            movie5 = "-";
                            pictureBox16.Visible = false;
                            pictureBox6.Visible = true;
                            saloon5.Enabled = true;
                           
                        }
                        if (slnno == 6)
                        {
                            movie6 = "-";
                            pictureBox17.Visible = false;
                            pictureBox7.Visible = true;
                            saloon6.Enabled = true;
                            
                        }
                        if (slnno == 7)
                        {
                            movie7 = "-";
                            pictureBox18.Visible = false;
                            pictureBox8.Visible = true;
                            saloon7.Enabled = true;
                           
                        }
                        if (slnno == 8)
                        {
                            movie8 = "-";
                            pictureBox19.Visible = false;
                            pictureBox9.Visible = true;
                            saloon8.Enabled = true;
                        }
                        if (slnno == 9)
                        {
                            movie9 = "-";
                            pictureBox21.Visible = false;
                            pictureBox10.Visible = true;
                            saloon9.Enabled = true;
                        }
                    }
                }
                
                
            }

            con.Close();
        }

        void stop_mv(int a)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM seats WHERE saloon_no='" + a + "'", con);
            cmd.ExecuteNonQuery();
        }

        void list_mv(string a)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM movies WHERE id='" +a+ "'", con);
            cmd.ExecuteNonQuery();
            int list = Convert.ToInt32(cmd.ExecuteScalar());
            if (list > 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM movies WHERE id='" + a + "'", con);
                ds = new DataSet();
                da.Fill(ds, "mv");
                mvname = ds.Tables["mv"].Rows[0]["name"].ToString();
            }
            else
            {
                mvname = "EMPTY";
            }
            con.Close();
        }
        
        void ses_time_view()
        {
            con.Open();
            string mvtime;
            if (label10.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '"+movie1+"'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie1 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label22.Text = mvtime;
                }
            }
            ds.Clear();
            if (label11.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie2 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie2 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label23.Text = mvtime;
                }
            }
            ds.Clear();
            if (label12.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie3 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie3 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label24.Text = mvtime;
                }
            }
            ds.Clear();
            if (label13.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie4 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie4 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label25.Text = mvtime;
                }
            }
            ds.Clear();
            if (label14.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie5 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie5 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label26.Text = mvtime;
                }
            }
            ds.Clear();
            if (label15.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie6 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie6 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label27.Text = mvtime;
                }
            }
            ds.Clear();
            if (label16.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie7 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie7 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label28.Text = mvtime;
                }
            }
            ds.Clear();
            if (label17.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie8 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie8 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label29.Text = mvtime;
                }
            }
            ds.Clear();
            if (label18.Text != "EMPTY")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM session WHERE movie_id = '" + movie9 + "'", con);
                int ses = Convert.ToInt32(cmd2.ExecuteScalar());
                if (ses > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM session WHERE movie_id='" + movie9 + "'", con);
                    ds = new DataSet();
                    da.Fill(ds, "mvt");
                    mvtime = ds.Tables["mvt"].Rows[0]["session"].ToString();
                    label30.Text = mvtime;
                }
            }
            ds.Clear();
            con.Close();
        }

        private void Saloon_Load(object sender, EventArgs e)
        {
            if (login.admin == "admin")
            {
                button4.Visible = true;
                button5.Visible = true;
                button13.Visible = true;
            }
           saloon_status();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM user_info WHERE id='" + login.id + "'", con);
            ds = new DataSet();
            da.Fill(ds, "balance");
            labelBalance.Text = ds.Tables["balance"].Rows[0]["balance"].ToString() + "$";
            da.Dispose();
            con.Close();
            list_mv(movie1);
            label10.Text = mvname;
            list_mv(movie2);
            label11.Text = mvname;
            list_mv(movie3);
            label12.Text = mvname;
            list_mv(movie4);
            label13.Text = mvname;
            list_mv(movie5);
            label14.Text = mvname;
            list_mv(movie6);
            label15.Text = mvname;
            list_mv(movie7);
            label16.Text = mvname;
            list_mv(movie8);
            label17.Text = mvname;
            list_mv(movie9);
            label18.Text = mvname;
            ses_time_view();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = DateTime.Now.ToLongTimeString(); // sadece saat
        }


        private void Saloon1_Click(object sender, EventArgs e)
        {
            saloon_no = 1;
            seats.Show();
            this.Hide();
        }

        private void Saloon2_Click(object sender, EventArgs e)
        {
            saloon_no = 2;
            seats.Show();
            this.Hide();
        }

        private void Saloon3_Click(object sender, EventArgs e)
        {
            saloon_no = 3;
            seats.Show();
            this.Hide();
        }

        private void Saloon4_Click(object sender, EventArgs e)
        {
            saloon_no = 4;
            seats.Show();
            this.Hide();
        }

        private void Saloon5_Click(object sender, EventArgs e)
        {
            saloon_no = 5;
            seats.Show();
            this.Hide();
        }

        private void Saloon6_Click(object sender, EventArgs e)
        {
            saloon_no = 6;
            seats.Show();
            this.Hide();
        }

        private void Saloon7_Click(object sender, EventArgs e)
        {
            saloon_no = 7;
            seats.Show();
            this.Hide();
        }

        private void Saloon8_Click(object sender, EventArgs e)
        {
            saloon_no = 8;
            seats.Show();
            this.Hide();
        }

        private void Saloon9_Click(object sender, EventArgs e)
        {
            saloon_no = 9;
            seats.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(seshour.ToString() + "  " + timenow.ToString());
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            saloon_status();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM user_info WHERE id='"+login.id+"'",con);
            ds = new DataSet();
            da.Fill(ds, "balance");
            labelBalance.Text = ds.Tables["balance"].Rows[0]["balance"].ToString() + "$";
            da.Dispose();
            con.Close();

            list_mv(movie1);
            label10.Text = mvname;
            list_mv(movie2);
            label11.Text = mvname;
            list_mv(movie3);
            label12.Text = mvname;
            list_mv(movie4);
            label13.Text = mvname;
            list_mv(movie5);
            label14.Text = mvname;
            list_mv(movie6);
            label15.Text = mvname;
            list_mv(movie7);
            label16.Text = mvname;
            list_mv(movie8);
            label17.Text = mvname;
            list_mv(movie9);
            label18.Text = mvname;

            ses_time_view();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            addbalance addbalance = new addbalance();
            addbalance.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Visible = true;
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            panel1.Visible = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            dataGridView1.Visible = true;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM movies", con);
            ds = new DataSet();
            da.Fill(ds, "movies");
            da.Dispose();
            dataGridView1.DataSource = ds.Tables["movies"];
            con.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO movies (name,price) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM movies WHERE id='"+textBox3.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM session WHERE session_id='" + textBox8.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();           
            label10.Text = "EMPTY";
            label11.Text = "EMPTY";
            label12.Text = "EMPTY";
            label13.Text = "EMPTY";
            label14.Text = "EMPTY";
            label15.Text = "EMPTY";
            label16.Text = "EMPTY";
            label17.Text = "EMPTY";
            label18.Text = "EMPTY";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO session (saloon_no,movie_id,session,ctrl) VALUES ('" + textBox4.Text + "','" + textBox5.Text + "','"+(textBox6.Text + ":" + textBox7.Text)+"','"+0+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ses_time_view();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            panel3.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            panel3.Visible = true;
        }

        private void PictureBox11_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Saloon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
        }

        private void Timer3_Tick_1(object sender, EventArgs e)
        {
            list_mv(movie1);
            label10.Text = mvname;
            list_mv(movie2);
            label11.Text = mvname;
            list_mv(movie3);
            label12.Text = mvname;
            list_mv(movie4);
            label13.Text = mvname;
            list_mv(movie5);
            label14.Text = mvname;
            list_mv(movie6);
            label15.Text = mvname;
            list_mv(movie7);
            label16.Text = mvname;
            list_mv(movie8);
            label17.Text = mvname;
            list_mv(movie9);
            label18.Text = mvname;
        }
    }
}
