using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Advance.Class03.L1.Generic.Enteties.Enteties
{
    public class NonGenericHelper
    {
        public void GoThroughStringList(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }


        public void GetInfoForList(List<string> strings)
        {
            Console.WriteLine($"The list has {strings.Count} and the elments are of type {strings[0].GetType()}");
        }
    }
}
