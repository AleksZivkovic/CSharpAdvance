using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Advance.Class01.L1.Interfaces
{
    public interface ITeacher : IUser
    {
        public string Subject { get; set; }

    }
}
