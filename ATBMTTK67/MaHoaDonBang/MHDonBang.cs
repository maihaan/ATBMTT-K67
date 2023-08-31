using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDonBang
{
    public class MHDonBang
    {
        public int Block = 1024;

        String[] BangChuCai = new string[]
        {
            "a", "e", "o", "p", "h", "i","u", "m", "n", "q", "w", "t",
            "x", "b", "d", "c", "z", "k", "l", "f", "s", "y", "u", "r",
            "0", "2", "5", "8", "9", "3", "1", "6", "7", "4"
        };

        public String MatKhau { get; set; }

        String[,] BangTra;

        public MHDonBang(String matKhau)
        {
            MatKhau = matKhau;
            // Khoi tao bang tra
            BangTra = new String[BangChuCai.Length, BangChuCai.Length];
            for (int i = 0; i < BangChuCai.Length; i++)
                for (int j = 0; j < BangChuCai.Length; j++)
                    BangTra[i, j] = BangChuCai[(i + j) % BangChuCai.Length];
        }

        public String ThucHien(String duLieu)
        {
            if (duLieu.Length > Block)
                return "[ERROR:01]";

            // Sinh mat khau moi
            String matKhauMoi = "";
            for (int i = 0; i < duLieu.Length; i++)
                matKhauMoi += MatKhau[i % MatKhau.Length];

            // Tra bang de lay ket qua
            String ketQua = "";
            for (int i = 0; i < duLieu.Length; i++)
            {
                String kyTu = duLieu[i].ToString();
                String kyTuMK = matKhauMoi[i].ToString();

                int hang = -1, cot = -1;
                // Tim hang trong bang tra
                for (int j = 0; j < BangChuCai.Length; j++)
                {
                    if(BangChuCai[j].Equals(kyTu))
                    {
                        hang = j;
                        break;
                    }    
                }
                if(hang == -1)
                {
                    // Khong ma hoa hoac giai ma
                    ketQua += kyTu;
                }    
                else
                {
                    for(int j = 0; j < BangChuCai.Length; j++)
                    {
                        if(BangTra[hang, j].Equals(kyTuMK))
                        {
                            cot = j;
                            break;
                        }    
                    }    
                    if(cot == -1)
                    {
                        ketQua += kyTu;
                    }    
                    else
                    {
                        ketQua += BangChuCai[cot];
                    }    
                }    
            }
            return ketQua;
        }
    }
}
