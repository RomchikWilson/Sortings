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
            else if (radioButton_ShakerSort.Checked)
            {
                ClearAndFillWithInitialData("Shaker sorting");
                ShakerSort();
            }
            else if (radioButton_CombSort.Checked)
            {
                ClearAndFillWithInitialData("Comb sorting");
                CombSort();
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

        private void ShakerSort()
        {
            string str = textBox_IncomingData.Text;

            string[] arr = new string[str.Length];

            for (int k = 0; k < str.Length; k++)
            {
                arr[k] = str[k].ToString();
            }

            bool isSwapped = true;
            int start = 0;
            int end = arr.Length;

            while (isSwapped == true)
            {
                isSwapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        string temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        isSwapped = true;

                        textBox_Console.Text += $@"
{string.Concat(arr)}";
                    }
                }

                if (isSwapped == false)
                    break;

                isSwapped = false;

                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        string temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        isSwapped = true;

                        textBox_Console.Text += $@"
{string.Concat(arr)}";
                    }
                }

                start = start + 1;
            }

            textBox_Answer.Text = string.Concat(arr);
        }

        //CombSort (
        private void CombSort()
        {
            string str = textBox_IncomingData.Text;

            string[] arr = new string[str.Length];

            for (int k = 0; k < str.Length; k++)
            {
                arr[k] = str[k].ToString();
            }

            int length = arr.Length;

            int gap = length;

            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = GetNextGap(gap);

                swapped = false;

                for (int i = 0; i < length - gap; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        string temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;

                        swapped = true;

                        textBox_Console.Text += $@"
{string.Concat(arr)}";
                    }
                }
            }

            textBox_Answer.Text = string.Concat(arr);
        }

        private int GetNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            if (gap < 1)
            {
                return 1;
            }
            return gap;
        }
        // ) CombSort 
    }
}
