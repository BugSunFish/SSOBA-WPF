using ssoba_library.Components;
using ssoba_library.Instruments;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ssoba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Register reg1 = new Register();
            Register reg2 = new Register();
            DependencyNode reg2_reg1 = new DependencyNode(reg1, reg2);

            reg1.data = 5;
            reg2_reg1.Run();
            MessageBox.Show(reg2.ViewData);
        }
    }
}
