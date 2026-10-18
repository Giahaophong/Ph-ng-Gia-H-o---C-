using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPTHUCHANH05D
{

    public partial class frmdongho : Form
    {
        public frmdongho()
        {
            InitializeComponent();

        }
        private int thoiGian = 3600;//Cho mặc định
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thoiGian > 0) //Thời gian > 0
            {
                thoiGian--;

                int gio = thoiGian / 3600; //Tính giờ
                int phut = (thoiGian % 3600) / 60; //Tính phút
                int giay = thoiGian % 60; //Tính giây

                label1.Text =
                    gio.ToString("00") + ":" +
                    phut.ToString("00") + ":" +
                    giay.ToString("00");
            }
            else
            {
                timer1.Stop();

                label1.Text = "Hết giờ"; //Báo hết giờ

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); //Bắt đầu đếm ngược
        }
    }
}

