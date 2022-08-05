using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBookTask
{
    public partial class UserControl1 : UserControl
    {
        //List<string> rates = new List<string> {"-", "1", "2", "3", "4", "5", "6","7","8", "9", "10", "11", "12" };
        //List<string> rates2 = new List<string> {"-", "1", "2", "3", "4", "5", "6","7","8", "9", "10", "11", "12" };

        public UserControl1()
        {
            InitializeComponent();
            guna2Panel1.BorderColor = Color.FromArgb(149, 221, 253);
            RəyLbl.ForeColor = Color.FromArgb(39, 181, 246);

            //guna2ComboBox1.DataSource=rates;
           // guna2ComboBox2.DataSource=rates2;
        }
        public int UCid
        {
            get
            {
                return int.Parse(guna2Panel1.Text);
            }
            set
            {
                ucIDlbl.Text = value.ToString();
            }
        }
        public string FullName
        {
            get
            {
                return UcFullNameLbl.Text;
            }
            set
            {
                UcFullNameLbl.Text = value;
            }
        }
        public Image UcImage
        {
            get
            {
                return UcImagePicterBox.Image;
            }
            set
            {
                UcImagePicterBox.Image = value;
            }
        }

        public string MystatDateTime
        {
            get
            {
                return UcEnterDateLbl.Text;
            }
            set
            {
                UcEnterDateLbl.Text = value;
            }
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            guna2GroupBox4.Visible = true;
        }

        //private void guna2PictureBox5_DoubleClick(object sender, EventArgs e)
        //{
        //    guna2GroupBox4
           
        //}

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2GroupBox4.Enabled = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Properties.Resources.dimond2;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources.dimond2;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            guna2PictureBox3.Image = Properties.Resources.dimond2;
        }

        private void guna2PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Properties.Resources._0f4d4f86_ebb3_441f_ad59_422b51aa79d3;
        }

        private void guna2PictureBox2_DoubleClick(object sender, EventArgs e)
        {
            guna2PictureBox2.Image = Properties.Resources._0f4d4f86_ebb3_441f_ad59_422b51aa79d3;
        }

        private void guna2PictureBox3_DoubleClick(object sender, EventArgs e)
        {
            guna2PictureBox3.Image = Properties.Resources._0f4d4f86_ebb3_441f_ad59_422b51aa79d3;
        }

        private void guna2PictureBox5_DoubleClick(object sender, EventArgs e)
        {
            guna2GroupBox4.Enabled = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2GroupBox4.Visible = false;
        }
    }
}
