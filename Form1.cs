using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCS2
{
    public partial class Form1 : Form
    {
        int[] mas;
        int[] sortedMas;
        int n = 200000;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int key = (int)numericUpDown1.Value;
            int repeats = 1500;
            int index = -1;

            int StartTime = Environment.TickCount;

            for (int rep = 0; rep < repeats; rep++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (mas[i] == key)
                    {
                        index = i;
                        break;
                    }
                }
            }

            int timeUnopt = Environment.TickCount - StartTime;

            textBox1.Text = timeUnopt.ToString();
            textBox2.Text = (index != -1) ? index.ToString() : "Не найден";

            StartTime = Environment.TickCount;
            mas[n - 1] = key;

            for (int rep = 0; rep < repeats; rep++)
            {
                int i = 0;

                while (mas[i] != key)
                {
                    i++;
                }

                if (i != n - 1)
                {
                    index = i;
                }
                else index = -1;
            }

            int timeOpt = Environment.TickCount - StartTime;

            textBox3.Text = timeOpt.ToString();
            textBox4.Text = (index != -1) ? index.ToString() : "Не найден";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int key = (int)numericUpDown2.Value;
            int repeats = 3000;
            int index = -1;

            int StartTime = Environment.TickCount;
            sortedMas[n - 1] = key;
            int i = 0;
            for (int rep = 0; rep < repeats; rep++)
            {
                i = 0;
                while (sortedMas[i] != key)
                {
                    i++;
                }

                if (i != n - 1)
                {
                    index = i;
                }
                else
                    index = -1;
            }

            int timeUnoptSorted = Environment.TickCount - StartTime;
            textBox5.Text = timeUnoptSorted.ToString();
            textBox6.Text = (index != -1) ? index.ToString() : "Не найдено";

            int k = 0;
            sortedMas[n - 1] = key + 1;
            StartTime = Environment.TickCount;

            for (int rep = 0; rep < repeats; rep++)
            {
                k = 0;
                while (sortedMas[k] < key)
                    k++;
            }

            if (key == sortedMas[k]) index = k;
            else index = -1;

            int timeOptSorted = Environment.TickCount - StartTime;
            textBox7.Text = timeOptSorted.ToString();
            textBox8.Text = (index != -1) ? index.ToString() : "Не найдено";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int key =(int)numericUpDown2.Value;
            Random rnd = new Random();
            mas = new int[n];

            for (int i = 0; i < n; i++)
                mas[i] = rnd.Next(0, n + 1);

            sortedMas = new int[n];

            int minElem = 0;
            for (int i = 0; i < n - 1; i++)
            {
                sortedMas[i] = rnd.Next(minElem + 1, minElem + 4);
                minElem = sortedMas[i];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}