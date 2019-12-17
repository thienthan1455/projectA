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
        private int PlayerId;
        public FindPlayer(int id)
        {
            InitializeComponent();
            this.Load += FindPlayer_Load;
            this.btncancel.Click += btncancel_Click;
            PlayerId = id;
            business = new Logiclayer();
        }

        void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FindPlayer_Load(object sender, EventArgs e)
        {
            var player = this.business.GetPlayer(this.PlayerId);
            this.txttencauthu.Text = player.TenCauThu.ToString();
            this.txtgioitinh.Text = player.Gioi_Tinh.ToString();
            this.dtpngaysinh.Value = player.NgaySinh;
            this.txtnickname.Text = player.Nickname.ToString();
            this.txtquequan.Text = player.Quequan.ToString();
            this.txtchieucao.Text = player.Quequan.ToString();
            this.txtchieucao.Text = player.Chieucao.ToString();
            this.txtvitri.Text = player.Vitri.ToString();
            this.txtsoao.Text = player.Soao.ToString();
            this.txtclb.Text = player.clb.ToString();
        }
    }
}
