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
    public partial class Edit : Form
    {
        private Logiclayer Business;
        private int PlayerId;
        public Edit(int id)
        {
            InitializeComponent();
            this.Business = new Logiclayer();
            this.PlayerId = id;
            this.Load += Edit_Load;
            this.btnsave.Click += btnsave_Click;
            this.btncancel.Click += btncancel_Click;
        }


        void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnsave_Click(object sender, EventArgs e)
        {
            var business = new Logiclayer();
            var TenCauThu = this.txttencauthu.Text;
            var Gioitinh = this.txtgioitinh.Text;
            var NgaySinh = this.dtpngaysinh.Value;
            var Nickname = this.txtnickname.Text;
            var Quequan = this.txtquequan.Text;
            var ChieuCao = this.txtchieucao.Text;
            var Vitri = this.txtvitri.Text;
            var Soao = this.txtsoao.Text;
            var clb = this.txtclb.Text;
            this.Business.EditPlayer(this.PlayerId, TenCauThu, Gioitinh, NgaySinh, Nickname, Quequan, ChieuCao, Vitri, Soao, clb);
            MessageBox.Show("Edit player Successfully");
            this.Close();

        }



        void Edit_Load(object sender, EventArgs e)
        {
            var business = new Logiclayer();
            var oldPlayer = business.GetPlayer(this.PlayerId);
            this.txttencauthu.Text = oldPlayer.TenCauThu;
            this.txtgioitinh.Text = oldPlayer.Gioi_Tinh;
            this.dtpngaysinh.Value = oldPlayer.NgaySinh;
            this.txtnickname.Text = oldPlayer.Nickname;
            this.txtquequan.Text = oldPlayer.Quequan;
            this.txtchieucao.Text = oldPlayer.Chieucao;
            this.txtvitri.Text = oldPlayer.Vitri;
            this.txtsoao.Text = oldPlayer.Soao;
            this.txtclb.Text = oldPlayer.clb;
        }
    }
}
