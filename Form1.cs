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
            else if (radioButton_InsertionSort.Checked)
            {
                ClearAndFillWithInitialData("Insertion sorting");
                InsertionSort();
            }
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            string symbols = "";

            if (checkBox_Letters.Checked) symbols += "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";

            if (checkBox_Numbers.Checked) symbols += "1111222233334444555566667777888899990000";

            if (String.IsNullOrWhiteSpace(symbols)) return;

            textBox_IncomingData.Text = GenRandomString(symbols, textBox_IncomingData.MaxLength);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)((ButtonBase)sender)).Checked) return;

            pictureBox_Visualizator.Image = (Image)Properties.Resources.ResourceManager.GetObject(((ButtonBase)sender).Text);
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

        private string GenRandomString(string Alphabet, int Length)
        {
            Random rnd = new Random();

            StringBuilder sb = new StringBuilder(Length - 1);

            int Position = 0;

            for (int i = 0; i < Length; i++)
            {
                Position = rnd.Next(0, Alphabet.Length - 1);
                sb.Append(Alphabet[Position]);
            }

            return sb.ToString();
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

        private void InsertionSort()
        {
            string str = textBox_IncomingData.Text;

            string[] arr = new string[str.Length];

            int length = arr.Length;

            for (int k = 0; k < length; k++)
            {
                arr[k] = str[k].ToString();
            }

            for (int i = 1; i < length; ++i)
            {
                string currentValue = arr[i];
                int pointer = i - 1;

                while (pointer >= 0 && arr[pointer].CompareTo(currentValue) > 0) 
                {
                    arr[pointer + 1] = arr[pointer];
                    pointer = pointer - 1;
                }
                arr[pointer + 1] = currentValue;

                textBox_Console.Text += $@"
{string.Concat(arr)}";
            }

            textBox_Answer.Text = string.Concat(arr);
        }
    }
}
