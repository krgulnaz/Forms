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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            О_программе op = new О_программе();
            op.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сообщение s = new Сообщение();
            s.ShowDialog();
           // msg.Text = "Message: " + 
        }
    }
}
