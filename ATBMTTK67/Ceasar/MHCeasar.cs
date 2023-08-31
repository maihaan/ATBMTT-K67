using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ceasar
{
    public class MHCeasar
    {
        // Đầu vào chung
        public String[] BangChuCai { get; set; }
        public int HSK { get; set; }

        public MHCeasar()
        {
            BangChuCai = new string[] { "a", "d", "c", "h", "0", "m", "v", "w", "g" };
            HSK = 3;
        }

        public String MaHoa(String banRo)
        {
            int chieuDaiBCC = BangChuCai.Length;
            String banMa = "";
            for(int i = 0; i < banRo.Length; i++)
            {
                String kyTuCanMaHoa = banRo[i].ToString();
                int viTriCu = -1;
                for(int j = 0; j < chieuDaiBCC; j++)
                {
                    if(BangChuCai[j].Equals(kyTuCanMaHoa))
                    {
                        viTriCu = j;
                        break;
                    }    
                }    
                if(viTriCu == -1)
                {
                    banMa += kyTuCanMaHoa;
                }    
                else
                {
                    int viTriMoi = (viTriCu + HSK) % chieuDaiBCC;
                    banMa += BangChuCai[viTriMoi].ToString();
                }    
            }
            return banMa;
        }

        public String GiaiMa(String banMa)
        {
            int chieuDaiBCC = BangChuCai.Length;
            String banRo = "";
            for (int i = 0; i < banMa.Length; i++)
            {
                String kyTuCanGiaiMa = banMa[i].ToString();
                int viTriCu = -1;
                for (int j = 0; j < chieuDaiBCC; j++)
                {
                    if (BangChuCai[j].Equals(kyTuCanGiaiMa))
                    {
                        viTriCu = j;
                        break;
                    }
                }
                if (viTriCu == -1)
                {
                    banRo += kyTuCanGiaiMa;
                }
                else
                {
                    int viTriMoi = (viTriCu - HSK + chieuDaiBCC) % chieuDaiBCC;
                    banRo += BangChuCai[viTriMoi].ToString();
                }    
            }
            return banRo;
        }
    }
}
