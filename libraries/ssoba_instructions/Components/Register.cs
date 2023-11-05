using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssoba_library.Components
{
    internal class Register
    {
        public string ViewData { get { return Convert.ToString(data, 2); } }
        public int data{ get;set; }
    }
}
