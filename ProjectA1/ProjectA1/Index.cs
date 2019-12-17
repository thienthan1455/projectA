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

namespace ProjectA1
{
    public partial class Index : Form
    {
        private Logiclayer Business;
        private Edit edit;
        public Index()
            
        {
            InitializeComponent();
            this.Business = new Logiclayer();
            this.Load += Index_Load;
            this.btnadd.Click += btnadd_Click;
            this.btndelete.Click += btndelete_Click;
            this.grdplayer.DoubleClick += grdplayer_DoubleClick;
            LoadAllPlayer();
            this.btnsearch.Click += btnsearch_Click;
            
        }

        void btnsearch_Click(object sender, EventArgs e)
        {
            var name = this.txttimkiem.Text;
            var item = this.Business.GetPlayerr(name);

            new ProjectA1.FindPlayer(name).ShowDialog();
        }




      

        void grdplayer_DoubleClick(object sender, EventArgs e)
        {
            if (grdplayer.SelectedRows.Count == 1)
            {
                var player = (Cauthu)this.grdplayer.SelectedRows[0].DataBoundItem;
                var edit = new Edit(player.Id);
                edit.ShowDialog();
                this.LoadAllPlayer();
            }
        }



        void btndelete_Click(object sender, EventArgs e)
        {
            if (this.grdplayer.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var player = (Cauthu)this.grdplayer.SelectedRows[0].DataBoundItem;
                    this.Business.DeletePlayer(player.Id);
                    this.LoadAllPlayer();
                }
            }
        }

        private void LoadAllPlayer()
        {
            var players = this.Business.Getplayers();
            this.grdplayer.DataSource = players;
        }

        void btnadd_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
            this.LoadAllPlayer();
        }

        void Index_Load(object sender, EventArgs e)
        {
            this.LoadAllPlayer();

        }
       
    }
}
