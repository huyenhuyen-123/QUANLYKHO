using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK.model
{
    internal class CTPhieuNhap
    {
        private string ID;
        private string MA_PN_KHO;
        private string MA_HH;
        private int SOLUONG; // Giả saử SOLUONG là một số nguyên
        private double DONGIA; // Giả sử DONGIA là một số thập phân

        public CTPhieuNhap() { }

        public CTPhieuNhap(string ID, string MA_PN_KHO, string MA_HH, int SOLUONG, double DONGIA)
        {
            this.ID = ID;
            this.MA_PN_KHO = MA_PN_KHO;
            this.MA_HH = MA_HH;
            this.SOLUONG = SOLUONG;
            this.DONGIA = DONGIA;
        }

        public string LayID() { return ID; }
        public string LayMaPnKho() { return MA_PN_KHO; }
        public string LayMaHH() { return MA_HH; }
        public int LaySoLuong() { return SOLUONG; }
        public double LayDonGia() { return DONGIA; }

        public void DatID(string ID) { this.ID = ID; }
        public void DatMaPnKho(string MA_PN_KHO) { this.MA_PN_KHO = MA_PN_KHO; }
        public void DatMaHH(string MA_HH) { this.MA_HH = MA_HH; }
        public void DatSoLuong(int SOLUONG) { this.SOLUONG = SOLUONG; }
        public void DatDonGia(double DONGIA) { this.DONGIA = DONGIA; }

        // Ghi đè phương thức ToString một cách đúng đắn
        public override string ToString()
        {
            return ID + " " + MA_PN_KHO + " " + MA_HH;
        }
    }
}
