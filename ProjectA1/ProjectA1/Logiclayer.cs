using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA1
{
    public class Logiclayer
    {
        public List<Cauthu> Getplayers()
        {
            var db = new QLCTEntities1();
            List<Cauthu> players = db.Cauthus.ToList();

            return players;
        }
        public Cauthu GetPlayer(int id)
        {
            var db = new QLCTEntities1();
            var player = db.Cauthus.Find(id);
            return player;
        }
        public void AddPlayer(string TenCauThu, string Gioitinh, DateTime NgaySinh, string Nickname, string Quequan, string ChieuCao, string Vitri, string Soao, string clb)
        {
            var db = new QLCTEntities1();
            var player = new Cauthu();

            player.TenCauThu = TenCauThu;
            player.Gioi_Tinh = Gioitinh;
            player.NgaySinh = NgaySinh;
            player.Nickname = Nickname;
            player.Quequan = Quequan;
            player.Chieucao = ChieuCao;
            player.Vitri = Vitri;
            player.Soao = Soao;
            player.clb = clb;

            db.Cauthus.Add(player);
            db.SaveChanges();
        }
        public Login[] Getlogin()
        {
            var db = new QLCTEntities1();
            return db.Logins.ToArray();
        }
        public void DeletePlayer(int id)
        {
            var db = new QLCTEntities1();
            var player = db.Cauthus.Find(id);

            db.Cauthus.Remove(player);
            db.SaveChanges();
        }
        public void EditPlayer(int id, string TenCauThu, string Gioitinh, DateTime NgaySinh, string Nickname, string Quequan, string ChieuCao, string Vitri, string Soao, string clb)
        {
            var db = new QLCTEntities1();
            var currentPlayer = db.Cauthus.Find(id);

            currentPlayer.TenCauThu = TenCauThu;
            currentPlayer.Gioi_Tinh = Gioitinh;
            currentPlayer.NgaySinh = NgaySinh;
            currentPlayer.Nickname = Nickname;
            currentPlayer.Quequan = Quequan;
            currentPlayer.Chieucao = ChieuCao;
            currentPlayer.Vitri = Vitri;
            currentPlayer.Soao = Soao;
            currentPlayer.clb = clb;

            db.Entry(currentPlayer).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
    }
}
