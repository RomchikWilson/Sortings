using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortings
{
    public partial class Sortings : Form
    {
        public Sortings()
        {
            InitializeComponent();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (radioButton_BubbleSort.Checked) 
            {
                ClearAndFillWithInitialData("Bubble sorting");
                BubbleSort();
            }
        }

        private void ClearAndFillWithInitialData(string typeSorting)
        {
            textBox_Console.Clear();
            textBox_Answer.Clear();

            string textMsg = $@"╔═══════════════════START═══════════════════╗
║ Input:                                                     ║
║    Incoming data: {textBox_IncomingData.Text}           
║    Type sorting: {typeSorting}                         
╚════════════════════════════════════════════╝";
            textBox_Console.Text = textMsg;
        }

        private void BubbleSort()
        {
            string str = textBox_IncomingData.Text;

            string[] arr = new string[str.Length];

            for (int k = 0; k < str.Length; k++) 
            {
                arr[k] = str[k].ToString();
            }

            int n = arr.Length;

            String temp;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        textBox_Console.Text += $@"
{string.Concat(arr)}";
                    }
                }
            }

            textBox_Answer.Text = string.Concat(arr);
        }
    }
}
