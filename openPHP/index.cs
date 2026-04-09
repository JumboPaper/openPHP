using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openPHP
{
    public partial class index : Form
    {
        int fator = 2;
        public index()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string caminho = ofd.FileName;
                string c_final = tb_caminho.Text = caminho;



            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_caminho.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c_final = tb_caminho.Text;

            string pastaServer = @"C:\laragon\www\";
            string caminhoParalelo = c_final.Replace(pastaServer, "");
            caminhoParalelo = caminhoParalelo.Replace("\\", "/");

            string url = "http://localhost/" + caminhoParalelo;



            if (fator == 1)
            {
                Process.Start("notepad.exe", tb_caminho.Text);
            }
            
            if(fator == 2)
            {
                
                Process.Start(new ProcessStartInfo
                {
                    FileName = "chrome.exe",
                    Arguments = url,
                    UseShellExecute = true
                });
            }
            

           

        }

        private void selecionarPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string caminho = ofd.FileName;
                string c_final = tb_caminho.Text = caminho;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void smi_notepad_Click(object sender, EventArgs e)
        {
            smi_notepad.Checked = true;
            smi_navegador.Checked = false;
            fator = 1;
        }

        private void smi_navegador_Click(object sender, EventArgs e)
        {
            smi_navegador.Checked = true;
            smi_notepad.Checked = false;
            fator = 2;
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void smi_darkMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.
        }
    }
}
