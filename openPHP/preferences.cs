using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openPHP
{
    public partial class preferences : Form
    {
        public preferences()
        {
            InitializeComponent();
        }
        
        private void preferences_FormClosing(object sender, FormClosingEventArgs e)
        { 
            DialogResult exit = MessageBox.Show("Deseja salvar suas alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (exit == DialogResult.Yes)
            {
               
                
                Application.Exit();
            }
            if (exit == DialogResult.No)
            {
                Application.Exit();
            }
            
        }

        private void preferences_Load(object sender, EventArgs e)
        {
            label3.Text = Configs.adress.collectAdress;
        }
    }
}
