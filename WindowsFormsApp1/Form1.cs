
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApp1
{
    public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
            
        }
        private void Form_1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form_1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            /*maskclassServer sv_1 = new maskclassServer(
               R_S.Text
               , conf_dir.Text
               , cluster.Text
               , shard.Text
               , TOKEN.Text
               , logbackup.Text
               , execfile.Text
               , offline.Checked
               , (sbyte)int.Parse(maxplayers.Text)
               , (sbyte)int.Parse(TR.Text)
               , "想不到吧");*/

            ;

            Process.Start(execfile.Text,Args());
            //ArgForm ArgForm1 = new ArgForm();
            //ArgForm1.printArg(execfile.Text+Args());
            //MessageBox.Show(execfile.Text+" "+Args());
            classARG ARG = new classARG();
            ARG.ARG
         
        }

        public string Args()
        {
            string str_cmdline = null ;
            if (R_S.Text != "")
                str_cmdline += "-persistent_storage_root " + R_S.Text + " ";

            if (conf_dir.Text != "")
                str_cmdline += "-conf_dir " + conf_dir.Text + " ";

            str_cmdline += "-cluster " + cluster.Text + " ";
            str_cmdline += "-shard " + shard.Text + " ";

            if (logbackup.Text != "")
                str_cmdline += "-backup_logs " + logbackup.Text + " ";

            if (TOKEN.Text != "")
                str_cmdline += "-token " + TOKEN.Text + " ";

            str_cmdline += "-maxplayers " + maxplayers.Text + " ";
            str_cmdline += "-tickrate " + TR.Text+ " ";

            if (offline.Checked)
                str_cmdline += "-offline";

            return str_cmdline;

        }
        
    }
}
