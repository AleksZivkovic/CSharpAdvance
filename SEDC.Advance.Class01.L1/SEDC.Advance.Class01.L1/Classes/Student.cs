using SEDC.Advance.Class01.L1.Abstract_class;
using SEDC.Advance.Class01.L1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Advance.Class01.L1.Classes
{
    internal class Student : User, IStudent
    {
        public List<int> Grades { get ; set ; }

        public override void PrintUser()
        {
            base.PrintUser();
            foreach(int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
