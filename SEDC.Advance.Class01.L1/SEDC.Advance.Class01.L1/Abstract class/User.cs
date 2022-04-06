using SEDC.Advance.Class01.L1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Advance.Class01.L1.Abstract_class
{
    public abstract class User : IUser
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public string Username { get ; set ; }
        public string Password { get ; set ; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"{Id} {Name} {Username}");
        }
    }
}
