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
    public partial class Add : Form
    {
        private Logiclayer Business;
        public Add()
        {
            InitializeComponent();
            this.Business = new Logiclayer();
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
            this.Business.AddPlayer(TenCauThu, Gioitinh, NgaySinh, Nickname, Quequan, ChieuCao, Vitri, Soao, clb);
            MessageBox.Show("Create player Successfully");
            this.Close();
        }
    }
}
