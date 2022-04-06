using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Advance.Class01.L1.Interfaces
{
    public interface IStudent : IUser
    {
        List<int> Grades { get; set; }

    }
}
