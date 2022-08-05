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
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            guna2Panel1.BackColor = Color.FromArgb(227, 246, 255);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(39, 181, 246);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(39, 181, 246);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(39, 181, 246);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(39, 181, 246);
            guna2HtmlLabel6.ForeColor = Color.FromArgb(39, 181, 246);
            guna2HtmlLabel7.ForeColor = Color.FromArgb(39, 181, 246);
            guna2Panel1.BorderColor = Color.FromArgb(144, 219, 253);
            guna2PictureBox2.BackColor = Color.FromArgb(227, 246, 255);
            guna2Panel1.BorderColor = Color.FromArgb(39, 181, 246);




            students.Add(new Student
            {
                FullName = "Nurlan Shirinov",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic
            });

            students.Add(new Student
            {
                FullName = "Bayramov Mehemmed",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });
            students.Add(new Student
            {
                FullName = "Ahmedov Ali",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });

            students.Add(new Student
            {
                FullName = "Suleymanov İlkin",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });

            students.Add(new Student
            {
                FullName = "Ahmedzade Ayxan",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });
            students.Add(new Student
            {
                FullName = "Abbasov Huseyn",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });

            students.Add(new Student
            {
                FullName = "Zaidov Alirza",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });
            students.Add(new Student
            {
                FullName = "Gulmammadli Joshgun",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });
            students.Add(new Student
            {
                FullName = "Cavanshirli Omer",
                EnterMyStatDate = DateTime.Now,
                StudentImage = Properties.Resources.ProfilePic

            });
            int x = 30;
            int y = 0;
            foreach (var item in students)
            {
                UserControl1 uc = new UserControl1();
                AllStudentPanel.Controls.Add(uc);
                uc.Location = new Point(x, y);
                y += uc.Height;

                uc.FullName = item.FullName;
                uc.UCid = item.Id;
                uc.UcImage = item.StudentImage;
                uc.MystatDateTime = item.EnterMyStatDate.ToShortDateString();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

            guna2GroupBox1.Enabled = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel8.Text = guna2TextBox1.Text;
            guna2GroupBox1.Enabled = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel8.Text = string.Empty;
            guna2TextBox1.Text = string.Empty;
        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton3.Checked)
            {
                foreach (var item in guna2Panel1.Controls)
                {
                    if (item is UserControl1 Uc)
                    {
                        foreach (var item2 in Uc.Controls)
                        {
                            if (item2 is Guna.UI2.WinForms.Guna2Panel pn)
                            {
                                foreach (var item3 in pn.Controls)
                                {
                                    if (item3 is GroupBox gb)
                                    {
                                        foreach (var item4 in gb.Controls)
                                        {
                                            if (item4 is RadioButton rb)
                                            {
                                                if (rb.Name == "guna2RadioButton1")
                                                {
                                                    rb.Checked = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
