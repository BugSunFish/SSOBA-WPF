using ssoba_library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssoba_library.Components
{
    public class RAM
    {
        public string ViewData { get { return Convert.ToString(data, 2); } }
        public int data {
            get { return ram[adress]; }
            set { ram[adress] = value; }
        }
        public int adress;
        public int[] ram = new int[32];
    }
}
