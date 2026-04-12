using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openPHP
{
    public partial class index : Form
    {
        int fator_type = 0, fator_mode = 1, fator_language = 0, fator_detect = 0;
       
        public index()
        {
            InitializeComponent();
        }
       

        private void index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_execute_Click(object sender, EventArgs e) //Execute
        {
            var collectAdress = Configs.adress.collectAdress= tb_path.Text;
            var folderServer = Configs.adress.folderServer = @"C:\laragon\www\";
            if (fator_type == 1)
            {
                Process.Start("notepad.exe", tb_path.Text);
            }

            if (fator_detect == 1 && fator_type == 0)
            {
                DialogResult question = MessageBox.Show("O Local Host está offline deseja inicia-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    Process.Start(@"C:\laragon\laragon.exe");
                    return;
                }

                string pathParallel = collectAdress.Replace(folderServer, "");
                pathParallel = pathParallel.Replace("\\", "/");
                string url = "http://localhost/" + pathParallel;

                if (fator_type == 0)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "chrome.exe",
                        Arguments = url,
                        UseShellExecute = true
                    });
                }
            }
            else
            {
                string pathParallel = collectAdress.Replace(folderServer, "");
                pathParallel = pathParallel.Replace("\\", "/");
                string url = "http://localhost/" + pathParallel;

                if (fator_type == 0)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "chrome.exe",
                        Arguments = url,
                        UseShellExecute = true
                    });
                }
            }
        }
        private void bt_clear_Click(object sender, EventArgs e) //Clear
        {
            tb_path.Text = "";
        }
        private void smi_selectFile_Click(object sender, EventArgs e)
        { 
            OpenFileDialog open = new OpenFileDialog();
            string laragon = @"C:\laragon\www";
            open.InitialDirectory = laragon;
            if (!Directory.Exists(laragon) && fator_language == 0)
            {
                MessageBox.Show("Atenção o diretório (" + laragon + ") não foi encontrado", "Erro #1", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(laragon) && fator_language == 1)
            {
                MessageBox.Show("Warning the directory (" + laragon + ") not found", "Error #1",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                string c_final = tb_path.Text = path;
            }
        }
        private void smi_notepad_Click(object sender, EventArgs e)
        {
            smi_notepad.Checked = true;
            smi_browser.Checked = false;
            fator_type = 1;
        }
        private void smi_browser_Click(object sender, EventArgs e)
        {
            smi_dark.Checked = true;
            smi_notepad.Checked = false;
            fator_type = 0;
        }     
        private void smi_darkMode_Click(object sender, EventArgs e)
        {
           
        }
        private void smi_light_Click(object sender, EventArgs e)
        {
            fator_mode = 1;
            if (fator_mode == 1)
            {
                ms_topMenu.BackColor = Color.White; ms_topMenu.ForeColor = Color.Black;
                this.BackColor = Color.White; this.ForeColor = Color.White;
                bt_execute.BackColor = Color.DodgerBlue; bt_clear.BackColor = Color.DodgerBlue;
                bt_selectFile.BackColor = Color.DodgerBlue; 
                version.ForeColor = Color.Black;

                smi_files.BackColor = Color.White; smi_files.ForeColor = Color.Black;
                smi_selectFile.BackColor = Color.White; smi_selectFile.ForeColor = Color.Black;
                smi_browser.BackColor = Color.White; smi_browser.ForeColor = Color.Black;
                smi_notepad.BackColor = Color.White; smi_notepad.ForeColor = Color.Black;
                smi_openWith.BackColor = Color.White; smi_openWith.ForeColor = Color.Black;
                smi_display.BackColor = Color.White; smi_display.ForeColor = Color.Black;
                smi_darkMode.BackColor = Color.White; smi_darkMode.ForeColor = Color.Black;
                smi_dark.BackColor = Color.White; smi_dark.ForeColor = Color.Black;
                smi_light.BackColor = Color.White; smi_light.ForeColor = Color.Black;
                smi_language.BackColor = Color.White; smi_language.ForeColor = Color.Black;
                smi_ptBR.BackColor = Color.White; smi_ptBR.ForeColor = Color.Black;
                smi_enUSA.BackColor = Color.White; smi_enUSA.ForeColor = Color.Black;
                smi_preferences.BackColor = Color.White; smi_preferences.ForeColor = Color.Black;
                lb_localHost.BackColor = Color.White; lb_localHost.ForeColor = Color.Black;

            }
            smi_dark.Checked = false;
            smi_light.Checked = true;
        }
        private void smi_dark_Click(object sender, EventArgs e)
        {
            fator_mode = 0;
            if (fator_mode == 0)
            {
                ms_topMenu.BackColor = Color.Black; ms_topMenu.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(30, 30, 30); this.ForeColor = Color.White;
                bt_execute.BackColor = Color.DarkViolet; bt_clear.BackColor = Color.DarkViolet;
                bt_selectFile.BackColor = Color.DarkViolet;
                version.ForeColor = Color.White;
                ms_topMenu.BackColor = Color.FromArgb(45, 45, 48); ms_topMenu.ForeColor = Color.White;
                smi_files.BackColor = Color.FromArgb(45, 45, 48); smi_files.ForeColor = Color.White;
                smi_selectFile.BackColor = Color.FromArgb(45, 45, 48); smi_selectFile.ForeColor = Color.White;
                smi_browser.BackColor = Color.FromArgb(45, 45, 48); smi_browser.ForeColor = Color.White;
                smi_notepad.BackColor = Color.FromArgb(45, 45, 48); smi_notepad.ForeColor = Color.White;
                smi_openWith.BackColor = Color.FromArgb(45, 45, 48); smi_openWith.ForeColor = Color.White;
                smi_display.BackColor = Color.FromArgb(45, 45, 48); smi_display.ForeColor = Color.White;
                smi_darkMode.BackColor = Color.FromArgb(45, 45, 48); smi_darkMode.ForeColor = Color.White;
                smi_dark.BackColor = Color.FromArgb(45, 45, 48); smi_dark.ForeColor = Color.White;
                smi_light.BackColor = Color.FromArgb(45, 45, 48); smi_light.ForeColor = Color.White;
                smi_language.BackColor = Color.FromArgb(45, 45, 48); smi_language.ForeColor = Color.White;
                smi_ptBR.BackColor = Color.FromArgb(45, 45, 48); smi_ptBR.ForeColor = Color.White;
                smi_enUSA.BackColor = Color.FromArgb(45, 45, 48); smi_enUSA.ForeColor = Color.White;
                smi_preferences.BackColor = Color.FromArgb(45, 45, 48); smi_preferences.ForeColor = Color.White;
                lb_localHost.BackColor = Color.FromArgb(30, 30, 30); lb_localHost.ForeColor = Color.White;
            }
            smi_dark.Checked = true;
            smi_light.Checked = false;

        }
        private void smi_openWith_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void smi_ptBR_Click(object sender, EventArgs e)
        {
            fator_language = 0;
            if(fator_language == 0)
            {
                bt_execute.Text = "Executar";
                bt_clear.Text = "Limpar";
                smi_selectFile.Text = "Novo Arquivo";
                smi_files.Text = "Arquivos";
                smi_browser.Text = "Navegador";
                smi_notepad.Text = "Bloco de notas";
                smi_openWith.Text = "Abrir com...";
                smi_display.Text = "Exibir";
                smi_preferences.Text = "Preferências";
                smi_darkMode.Text = "◐ Modo Escuro";
                smi_dark.Text = "Escuro ⚫️";
                smi_light.Text = "Claro ⚪";
            }
            smi_ptBR.Checked = true;
            smi_enUSA.Checked = false;
        }

        private void smi_enUSA_Click(object sender, EventArgs e)
        {
            fator_language = 1;
            if (fator_language == 1)
            {
                bt_execute.Text = "Run";
                bt_clear.Text = "Clear All";
                smi_selectFile.Text = "New File";
                smi_files.Text = "Files";
                smi_browser.Text = "Browser";
                smi_notepad.Text = "Notepad";
                smi_openWith.Text = "Open With...";
                smi_display.Text = "Display";
                smi_preferences.Text = "Preferences";
                smi_darkMode.Text = "◐ Dark Mode";
                smi_dark.Text = "Dark ⚫️ ";
                smi_light.Text = "Light ⚪";
            }
            smi_ptBR.Checked = false;
            smi_enUSA.Checked = true;
        }

        private void smi_preferences_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openPreferences = new preferences();
            openPreferences.Show();
        }

        private void timer_localhost_Tick(object sender, EventArgs e)
        {
            bool apacheOn = Process.GetProcessesByName("httpd").Any();

            if (apacheOn)
            {
                lb_localHost.Text = "Apache: Online";
                fator_detect = 0;
            }
            else
            {
                lb_localHost.Text = "Apache: offline";
                fator_detect = 1;
            }
        }
        private void index_Load(object sender, EventArgs e)
        {
            
            timer_localhost.Interval = 1000;
            timer_localhost.Start();
            bt_execute.FlatStyle = FlatStyle.Flat; bt_execute.FlatAppearance.BorderSize = 0;
            bt_clear.FlatStyle = FlatStyle.Flat; bt_clear.FlatAppearance.BorderSize = 0;
            bt_selectFile.FlatStyle = FlatStyle.Flat; bt_selectFile.FlatAppearance.BorderSize = 0;
        }
        


    }
}
