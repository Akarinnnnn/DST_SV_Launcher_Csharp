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
    public partial class ArgForm : Form
    {
        

        public ArgForm(string g_str_svARG)
        {
            InitializeComponent();
            printArg(g_str_svARG);
        }

        private void ArgForm_Load(object sender, EventArgs e)
        {

        }
        public void printArg(string strInputArg)
        {
            textBox1.Text = strInputArg;

        }
    }
}
