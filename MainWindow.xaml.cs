using System;
using System.Collections.Generic;
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

namespace Architektura___PROJEKT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string AX;
        string BX;
        string CX;
        string DX;

        public MainWindow()
        {
            InitializeComponent();
            ResetAll();


        }

        private void RandomInput_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            INPUT.Text = rnd.Next(100).ToString();
        }

        private void RandomRegisters_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            printAX.Text = rnd.Next(100).ToString();
            printBX.Text = rnd.Next(100).ToString();
            printCX.Text = rnd.Next(100).ToString();
            printDX.Text = rnd.Next(100).ToString();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();
        }

        private void InputTo_Click(object sender, RoutedEventArgs e)
        {
            if (INPUT.Text == string.Empty)
                return;

            var button = sender as Button;
            var currentNumber = INPUT.Text;
            string qq = button.Name;
            char[] chars = {'X'};
            string XX = qq.TrimEnd(chars);

            if (XX[XX.Length-1] == 'A')
            {
                printAX.Text = currentNumber;
            }
            if (XX[XX.Length - 1] == 'B')
            {
                printBX.Text = currentNumber;
            }
            if (XX[XX.Length - 1] == 'C')
            {
                printCX.Text = currentNumber;
            }
            if (XX[XX.Length - 1] == 'D')
            {
                printDX.Text = currentNumber;
            }
            INPUT.Text = string.Empty;
        }

        private void XTOx_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ResetAll()
        {
            INPUT.Text = string.Empty;
            printAX.Text = string.Empty;
            printBX.Text = string.Empty;
            printCX.Text = string.Empty;
            printDX.Text = string.Empty;
        }
    }
}
