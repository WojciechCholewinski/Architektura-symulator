using System;
using System.Windows;
using System.Windows.Controls;

namespace Architektura___PROJEKT
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ResetAll();
        }

        private void RandomInput_Click(object sender, RoutedEventArgs e)
        {
            //Random rnd = new Random();
            //INPUT.Text = rnd.Next(100).ToString();        //random decimal number

            Random random = new Random();
            var bytes0 = new Byte[2];
            random.NextBytes(bytes0);
            var hexArray0 = Array.ConvertAll(bytes0, x => x.ToString("X2"));
            var hexStr0 = String.Concat(hexArray0);
            INPUT.Text = hexStr0;
        }

        private void RandomRegisters_Click(object sender, RoutedEventArgs e)
        {
            //this.BXAX.Tag = new Action<int>((a) => {
            //}); 

            Random random = new Random();
            var bytes0 = new Byte[2];
            var bytes1 = new Byte[2];
            var bytes2 = new Byte[2];
            var bytes3 = new Byte[2];
            random.NextBytes(bytes0);
            random.NextBytes(bytes1);
            random.NextBytes(bytes2);
            random.NextBytes(bytes3);
            var hexArray0 = Array.ConvertAll(bytes0, x => x.ToString("X2"));
            var hexArray1 = Array.ConvertAll(bytes1, x => x.ToString("X2"));
            var hexArray2 = Array.ConvertAll(bytes2, x => x.ToString("X2"));
            var hexArray3 = Array.ConvertAll(bytes3, x => x.ToString("X2"));
            var hexStr0 = String.Concat(hexArray0);
            var hexStr1 = String.Concat(hexArray1);
            var hexStr2 = String.Concat(hexArray2);
            var hexStr3 = String.Concat(hexArray3);

            printAX.Text = hexStr0;
            printBX.Text = hexStr1;
            printCX.Text = hexStr2;
            printDX.Text = hexStr3;

            //Random rnd = new Random();
            //printAX.Text = rnd.Next(100).ToString();
            //printBX.Text = rnd.Next(100).ToString();          //random decimal number
            //printCX.Text = rnd.Next(100).ToString();
            //printDX.Text = rnd.Next(100).ToString();
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
            char[] chars = { 'X' };
            string XX = qq.TrimEnd(chars);

            if (XX[XX.Length - 1] == 'A')
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
            string zrodlo = "default";
            var button = sender as Button;


            //Action<int> tag = (Action<int>)button.Tag;
            //tag.Invoke(1);


            string XX = button.Name;
            if (XX[XX.Length - 2] == 'A')
            {
                zrodlo = printAX.Text;
            }
            if (XX[XX.Length - 2] == 'B')
            {
                zrodlo = printBX.Text;
            }
            if (XX[XX.Length - 2] == 'C')
            {
                zrodlo = printCX.Text;
            }
            if (XX[XX.Length - 2] == 'D')
            {
                zrodlo = printDX.Text;
            }

            if (XX[XX.Length - 4] == 'A')
            {
                printAX.Text = zrodlo;
            }
            if (XX[XX.Length - 4] == 'B')
            {
                printBX.Text = zrodlo;
            }
            if (XX[XX.Length - 4] == 'C')
            {
                printCX.Text = zrodlo;
            }
            if (XX[XX.Length - 4] == 'D')
            {
                printDX.Text = zrodlo;
            }

        }
        private void ResetAll()
        {
            INPUT.Text = string.Empty;
            printAX.Text = string.Empty;
            printBX.Text = string.Empty;
            printCX.Text = string.Empty;
            printDX.Text = string.Empty;
        }

        private void XCHG_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string tmp = "default";

            //Action<int> tag = (Action<int>)button.Tag;
            //tag.Invoke(1);

            string XX = button.Name;
            if (XX.Contains("AX") && XX.Contains("BX"))
            {
                tmp = printAX.Text;
                printAX.Text = printBX.Text;
                printBX.Text = tmp;
            }
            if (XX.Contains("AX") && XX.Contains("CX"))
            {
                tmp = printAX.Text;
                printAX.Text = printCX.Text;
                printCX.Text = tmp;
            }
            if (XX.Contains("AX") && XX.Contains("DX"))
            {
                tmp = printAX.Text;
                printAX.Text = printDX.Text;
                printDX.Text = tmp;
            }
            if (XX.Contains("BX") && XX.Contains("CX"))
            {
                tmp = printBX.Text;
                printBX.Text = printCX.Text;
                printCX.Text = tmp;
            }
            if (XX.Contains("BX") && XX.Contains("DX"))
            {
                tmp = printBX.Text;
                printBX.Text = printDX.Text;
                printDX.Text = tmp;
            }
            if (XX.Contains("CX") && XX.Contains("DX"))
            {
                tmp = printCX.Text;
                printCX.Text = printDX.Text;
                printDX.Text = tmp;
            }
        }

        
    }
}
