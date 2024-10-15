using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_QuanLyNhaHang_DTO
{
    public class BanDTO
    {
        string _maban;
        int _soghe;
        string _trangthai;

        public string Maban { get => _maban; set => _maban = value; }
        public int Soghe { get => _soghe; set => _soghe = value; }
        public string Trangthai { get => _trangthai; set => _trangthai = value; }

        public BanDTO() { }
        public BanDTO(string maban, int soghe, string trangthai)
        {
            Maban = maban;
            Soghe = soghe;
            Trangthai = trangthai;
        }
    }
}
