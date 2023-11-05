using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssoba_library.Interfaces
{
    public interface IMemory
    {
        public int data { get; set; }
    }
    public interface ICommand
    {
        public int id { get; set; }
        public string name { get; set; }

        void Run();
    }

    public interface IDependencyNode
    {
        public void Run();
    }

    public interface IController
    {
        public IEnumerable<ICommand> commands { get; set; }
    }
}
