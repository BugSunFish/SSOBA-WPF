using ssoba_library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssoba_library.Instruments
{
    public class DependencyNode : IDependencyNode
    {
        private readonly IMemory Input;
        private readonly IMemory Next;
        public DependencyNode(IMemory Input, IMemory Next)
        {
            this.Input = Input;
            this.Next = Next;
        }
        public void Run()
        {
            Next.data = Input.data;
        }
    }
}
