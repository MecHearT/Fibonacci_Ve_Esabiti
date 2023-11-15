using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            
            
            int sayi;
            int x = 0;
            int y = 1;
            int z = 0;
            int j = 0;
            string q = "A";
            string w = "B";
            string r = "" ;
            sayi = Convert.ToInt32(textBox1.Text);

            listBox2.Items.Add(x);
            listBox2.Items.Add(y);

            for(int a = 2; a < sayi; a++)
            {
                z = x + y;
                x = y;
                y = z;

                listBox2.Items.Add(z);


            }
            listBox3.Items.Add("#");
            listBox3.Items.Add(q);
            listBox3.Items.Add(w);

            for(int c = 2; c < sayi; c++)
            {
                r = q + w;
                q = w;
                w = r;

                listBox3.Items.Add(r);
            }
            

            for (int b = 0; b <= sayi; b++)
            {
                


                listBox1.Items.Add(j);

                j++;
                
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
