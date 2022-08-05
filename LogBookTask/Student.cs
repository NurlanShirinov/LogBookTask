using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBookTask
{
    public class Student
    {
        public int Id { get; set; }
        public static int StaticId { get; set; }
        public string FullName { get; set; }
        public DateTime EnterMyStatDate { get; set; }=DateTime.Now;
        public Image StudentImage { get; set; }

        public Student()
        {
            Id = ++StaticId;
        }

    }
}
