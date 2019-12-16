using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Logiclayer
    {
        public List<Cauthu> Getplayers()
        {
            var db = new QLCTEntities();
            List<Cauthu> players = db.Cauthu.ToList();

            return players;
        }
        public Cauthu GetPlayer(int id)
        {
            var db = new QLCTEntities();
            var player = db.Cauthu.Find(id);
            return player;
        }
        public void AddPlayer(string TenCauThu, string Gioitinh, DateTime NgaySinh, string Nickname, string Quequan, string ChieuCao, string Vitri, string Soao, string clb)
        {
            var db = new QLCTEntities();
            var player = new Cauthu();

            player.TenCauThu = TenCauThu;
            player.Gioitinh = Gioitinh;
            player.Ngaysinh = NgaySinh;
            player.Nickname = Nickname;
            player.Quequan = Quequan;
            player.Chieucao = ChieuCao;
            player.Vitri = Vitri;
            player.Soao = Soao;
            player.clb = clb;

            db.Cauthu.Add(player);
            db.SaveChanges();
        }
        public Login[] Getlogin()
        {
            var db = new QLCTEntities();
            return db.Login.ToArray();
        }
        public void DeletePlayer(int id)
        {
            var db = new QLCTEntities();
            var player = db.Cauthu.Find(id);

            db.Cauthu.Remove(player);
            db.SaveChanges();
        }
        public void EditPlayer(int id, string TenCauThu, string Gioitinh, DateTime NgaySinh, string Nickname, string Quequan, string ChieuCao, string Vitri, string Soao, string clb)
        {
            var db = new QLCTEntities();
            var currentPlayer = db.Cauthu.Find(id);

            currentPlayer.TenCauThu = TenCauThu;
            currentPlayer.Gioitinh = Gioitinh;
            currentPlayer.Ngaysinh = NgaySinh;
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

