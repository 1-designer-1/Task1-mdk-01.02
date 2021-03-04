using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Class1 class1 = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        //Задание 1
        private void Button1_Click(object sender, EventArgs e)
        {
            double numberTask1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = class1.Task1(numberTask1).ToString();
        }

        //Задание 2
        private void Button2_Click(object sender, EventArgs e)
        {
            double numberTask2 = Convert.ToDouble(textBox3.Text);
            textBox4.Text = class1.Task2(numberTask2).ToString();
        }

        //Задание 3
        private void Button3_Click(object sender, EventArgs e)
        {
            int numberTask3 = Convert.ToInt32(textBox5.Text);
            textBox6.Text = class1.Task3(numberTask3).ToString();
        }

        //Задание 5
        private void button9_Click(object sender, EventArgs e)
        {
            int numberOneArray = Convert.ToInt32(textBox9.Text);
            int numbeTwoArray = Convert.ToInt32(textBox10.Text);
            int numberSizeRandom = Convert.ToInt32(textBox11.Text);
            int[] mas = class1.Task5(numberOneArray, numbeTwoArray, numberSizeRandom).ToArray();
            listBox1.Items.Clear();
            for (int i = 0; i < mas.Count(); i++) 
            {
                listBox1.Items.Add(mas[i].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sizeArray = Convert.ToInt32(textBox7.Text);
            int[] mas = class1.Task4(sizeArray).ToArray();
            listBox2.Items.Clear();
            for (int i = 1; i < mas.Length; i++)
            {
                listBox2.Items.Add(mas[i].ToString());

            }

        }
    }
}
