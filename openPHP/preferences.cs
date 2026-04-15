using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openPHP
{
    public partial class preferences : Form
    {
        public static string pathSource;
        public preferences()
        {
            InitializeComponent();
        }
        
        private void preferences_FormClosing(object sender, FormClosingEventArgs e)
        { 
            this.Hide();
        }

        private void preferences_Load(object sender, EventArgs e)
        {
            tb_rootFolder.Text = Configs.pathSource;
        }
        private void tb_rootFolder_TextChanged(object sender, EventArgs e)
        {
           Configs.pathSource = tb_rootFolder.Text;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }

        private void bt_selectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openfolder = new FolderBrowserDialog())
            {
                if (openfolder.ShowDialog() == DialogResult.OK)
                {
                    tb_rootFolder.Text = openfolder.SelectedPath;
                }
            }
        }
    }
}
