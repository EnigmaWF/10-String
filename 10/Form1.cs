using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
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
            string t = Convert.ToString(textBox1.Text);
            t = t.Remove(t.LastIndexOf(";")+1);
            t = t.Remove(0, t.IndexOf(";"));
            label1.Text = "" + t;
            /*10.  Дана строка, содержащая по крайней мере две ;. 
             * Получить новую строку путем вычеркивания всех символов, стоящих до первой ; и после последней ;.*/
        }
    }
}
