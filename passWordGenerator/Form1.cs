using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passWordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<char> listachar = new List<char>();
        public List<int> listaint  = new List<int>();
        Random random = new Random(256);
        public int getRandomize(int min, int max)
        { 
           
            int i = random.Next(min, max);
            return i;
        }

        public void randomizeNTimes(int n, int min, int max)
        {
            for (int i = 0; i < n; i++) {
                int x = getRandomize(min, max);
                listaint.Add(x);
                listachar.Add(convertIntToChar(x));
            }
        }
        public void printListaInt(ref List<int> lt, ref TextBox t)
        {
            for (int i = 0; i < lt.Count; i++)
            {
                t.Text += lt[i];
                t.Text += " ; ";
            }
        }
        public void printListaChar(ref List<char> lt, ref TextBox t)
        {
            for (int i = 0; i < lt.Count; i++)
            {
                t.Text += lt[i];
                //t.Text += "";
            }
        }
        public char convertIntToChar(int x) {
            return (Char)x;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            randomizeNTimes(256, 1, 256);
            printListaInt( ref listaint, ref txtBox);
            txtBox.Text += "\r\n";
            printListaChar( ref listachar, ref txtBox);

        }
    }
}
