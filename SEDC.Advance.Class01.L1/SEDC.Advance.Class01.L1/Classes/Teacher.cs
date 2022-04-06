using SEDC.Advance.Class01.L1.Abstract_class;
using SEDC.Advance.Class01.L1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Advance.Class01.L1.Classes
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get ; set ; }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine(Subject);
        }
    }
}
