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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan difference;
            int max = 0;
            int counter = 0;
            string[] pole;
            int Index = 0;
            string date;



            string[] text = textBox1.Lines;
            try
            {
               
                foreach (string Radek in text)
                {
                    pole = Radek.Split(';');

                    date = pole[2];
                    date = date.Trim();
                    date = date.Replace(" ", "");

                    difference = DateTime.Now - DateTime.Parse(date);

                    if (max < difference.Days)
                    {
                        max = difference.Days;
                        Index = counter;
                    }

                    counter++;
                }
                label1.Text = "Nejstarší člověk: " + text[Index].Replace(";"," ");
            }
            catch
            {
                MessageBox.Show("Nespravný tvar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
