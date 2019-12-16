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

namespace Login
{
    public partial class Form1 : Form
    {
        private Logiclayer Business;
        public Form1()
        {
            InitializeComponent();
            this.Business = new Logiclayer();

            this.btnlogin.Click += btnlogin_Click;
            this.btncancel.Click += btncancel_Click;
            this.cbshowpassword.CheckedChanged += cbshowpassword_CheckedChanged;
        }

        void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See you late");
            this.Close();

        }



        void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\ProjectA\ProjectA\Login\QLCT.mdf;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtaccount.Text;
                string mk = txtpassword.Text;
                string sql = "select * from Login where Taikhoan = '" + tk + "' and Matkhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Login Success");
                    Index index = new Index();
                    this.Hide();
                    index.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Fail Login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro login");
            }
        }
    }
}
