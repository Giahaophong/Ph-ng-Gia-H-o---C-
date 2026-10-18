using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPTHUCHANH05C
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị chọn bên trái sang phải
            lst_Phai.Items.Add(lst_Trai.SelectedItem);

            // Xóa giá trị chọn bên trái
            lst_Trai.Items.Remove(lst_Trai.SelectedItem);
        }

        private void btnQuaPhaiAll_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị chọn bên trái sang phải
            lst_Phai.Items.AddRange(lst_Trai.Items);
            // Xóa giá trị chọn bên trái
            lst_Trai.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị chọn bên trái sang phải
            lst_Trai.Items.Add(lst_Phai.SelectedItem);
            // Xóa giá trị chọn bên trái
            lst_Phai.Items.Remove(lst_Phai.SelectedItem);
        }

        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị chọn bên trái sang phải
            lst_Trai.Items.AddRange(lst_Phai.Items);
            // Xóa giá trị chọn bên trái
            lst_Phai.Items.Clear();
        }
    }
}
