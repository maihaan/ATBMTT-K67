using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ceasar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu dau vao
            if(String.IsNullOrEmpty(tbGiaTriCanMaHoa.Text))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần mã hóa");
                tbGiaTriCanMaHoa.Focus();
                return;
            }    

            MHCeasar cs = new MHCeasar();
            tbKetQuaMaHoa.Text = cs.MaHoa(tbGiaTriCanMaHoa.Text);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu dau vao
            if (String.IsNullOrEmpty(tbKetQuaMaHoa.Text))
            {
                MessageBox.Show("Chưa có dữ liệu cần giải mã");
                tbGiaTriCanMaHoa.Focus();
                return;
            }

            MHCeasar cs = new MHCeasar();
            tbKetQuaGiaiMa.Text = cs.GiaiMa(tbKetQuaMaHoa.Text);
        }
    }
}
