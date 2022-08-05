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
            guna2Panel1.BorderColor= Color.FromArgb(39, 181, 246);




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
                uc.MystatDateTime=item.EnterMyStatDate.ToShortDateString();
            }
        }

    }
}
