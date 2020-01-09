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
    public partial class addbalance : Form
    {
        public addbalance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q0CBJCI\\SQLEXPRESS;Initial Catalog=atlas;Integrated Security=True");
        DataSet ds;
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE user_info SET balance=balance+"+textBox5.Text+" WHERE id='"+login.id+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            saloon saloon = new saloon();
            saloon.Show();
            this.Hide();
        }

        private void Addbalance_FormClosing(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            saloon saloon = new saloon();
            saloon.Show();
            this.Hide();
        }
    }
}
