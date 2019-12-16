using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class PlayerView
    {
        public int Id { get; set; }
        public string TenCauThu { get; set; }
        public string Gioitinh { get; set; }
        public System.DateTime Ngaysinh { get; set; }
        public string Nickname { get; set; }
        public string Quequan { get; set; }
        public string Chieucao { get; set; }
        public string Vitri { get; set; }
        public string Soao { get; set; }
        public string clb { get; set; }

        public PlayerView(Cauthu cauthu)
        {
            this.Id = cauthu.Id;
            this.TenCauThu = cauthu.TenCauThu;
            this.Gioitinh = cauthu.Gioitinh;
            this.Ngaysinh = cauthu.Ngaysinh;
            this.Nickname = cauthu.Nickname;
            this.Quequan = cauthu.Quequan;
            this.Chieucao = cauthu.Chieucao;
            this.Vitri = cauthu.Vitri;
            this.Soao = cauthu.Soao;
            this.clb = cauthu.clb;
        }
    }
}
