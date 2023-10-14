using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_điểm_sinh_viên
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text != "" && txtHoten.Text !="" && cbGioitinh.Text !="" && txtLop.Text != "" && txtQuequan.Text != "")
            {
                try
                {
                    double van = Convert.ToDouble(txtDiemvan.Text);
                    double toan = Convert.ToDouble(txtDiemtoan.Text);
                    double anh = Convert.ToDouble(txtDiemAnh.Text);
                    if(van>=0 && van<=10 && toan>=0 && toan<=10 && anh>=0 && anh <= 10)
                    {
                        dataGridViewSV.Rows.Add(txtMaSV.Text, txtHoten.Text, dateTimePicker1.Text, cbGioitinh.Text, txtLop.Text,
                            txtQuequan.Text, txtDiemvan.Text, txtDiemtoan.Text, txtDiemAnh.Text);
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu điểm phải nằm trong khoảng 0 đến 10")
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai dữ liệu điểm");
                }
            }
            else
            {
                MessageBox.Show("chưa nhập đầy đủ thông tin sv");
            }
        }
    }
}
