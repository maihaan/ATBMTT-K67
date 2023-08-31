using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MaHoaDonBang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbTep.Text = od.FileName;
            }    
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu dau vao
            if (rbMaHoa.Checked == false && rbGiaiMa.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn chức năng cần thực hiện");
                rbMaHoa.Focus();
                return;
            }    

            if(tbTep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tệp tin cần Mã hóa hoặc giải mã.");
                btTim.Focus();
                return;
            }    

            if(!File.Exists(tbTep.Text))
            {
                MessageBox.Show("Không tìm thấy tệp tin mà bạn chọn. Hãy chọn lại tệp tin!");
                btTim.Focus();
                return;
            }

            if(tbMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!");
                tbMatKhau.Focus();
                return;
            }    

            if(tbMatKhau.Text.Trim().Replace(" ", "").Length < 8)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu có độ dài tối thiểu là 8 ký tự không bao gồm dấu cách!");
                tbMatKhau.Focus();
                return;
            } 
            
            // Ma hoa hoac giai ma

        }
    }
}
