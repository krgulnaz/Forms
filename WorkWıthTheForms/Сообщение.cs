using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWıthTheForms
{
    public partial class Сообщение : Form
    {
        public Сообщение()
        {
            InitializeComponent();
        }
        public string m = String.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            this.m = this.textBox1.Text;
            this.Close();
        }
    }
}
