using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA1
{
    public partial class FindPlayer : Form
    {
        private Logiclayer business;
        private string PlayerName;
        public FindPlayer(string name)
        {
            InitializeComponent();
            this.Load += FindPlayer_Load;
            this.btncancel.Click += btncancel_Click;
            PlayerName = name;
            business = new Logiclayer();
        }

        void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FindPlayer_Load(object sender, EventArgs e)
        {
            var player = this.business.GetPlayerr(this.PlayerName);
            this.txttencauthu.Text = player[0].TenCauThu.ToString();
            this.txtgioitinh.Text = player[0].Gioi_Tinh.ToString();
            this.dtpngaysinh.Value = player[0].NgaySinh;
            this.txtnickname.Text = player[0].Nickname.ToString();
            this.txtquequan.Text = player[0].Quequan.ToString();
            this.txtchieucao.Text = player[0].Quequan.ToString();
            this.txtchieucao.Text = player[0].Chieucao.ToString();
            this.txtvitri.Text = player[0].Vitri.ToString();
            this.txtsoao.Text = player[0].Soao.ToString();
            this.txtclb.Text = player[0].clb.ToString();
        }
    }
}
