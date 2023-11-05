using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ssoba_library.Components
{
    internal class Operational_Block
    {
        public string ViewData { get { return Convert.ToString(result, 2); } }
        public int x
        {
            get; set;
        }

        public int y
        {
            get; set;
        }

        public int result = 0x00000000;

        public void Run(int x, int y, bool is_add)
        {
            if (is_add)
            {
                result = x + y;
            }
            result = x - y;
        }
    }
}
