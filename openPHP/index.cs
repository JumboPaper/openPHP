using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openPHP
{
    public partial class index : Form
    {
        int fator_type = Configs.fator_type = 0;
        int fator_mode = Configs.fator_mode = 0;
        int fator_detect = Configs.fator_detect = 0;
        

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

            string collectAdress = Configs.collectAdress= tb_path.Text;
            string folderServer = Configs.folderServer = @"C:\laragon\www\";
            if (fator_detect == 1 && fator_type == 0)
            {
                Configs.errorHandling.localHostOffline();
                Configs.openFile.replaceAdress();
            }
            if (fator_type == 0)
            {
                Configs.openFile.openInBrowser(); 
            }
            if (fator_type == 1)
            {
                Configs.openFile.openInNotepad();
            }
        }
        private void bt_clear_Click(object sender, EventArgs e) //Clear
        {
            tb_path.Text = "";
        }
        private void smi_selectFile_Click(object sender, EventArgs e)
        { 
           Configs.openFile.initializationManagerFiles();
           Configs.errorHandling.pathSourceNotFound();
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
        private void smi_light_Click(object sender, EventArgs e)
        {
            fator_mode = 0;
            if (fator_mode == 0)
            {
                Configs.front.light_mode(this);
                Configs.front.menu_light_mode(ms_topMenu);
                this.BackColor = Control.DefaultBackColor;

            }
            smi_dark.Checked = false;
            smi_light.Checked = true;
        }
        private void smi_dark_Click(object sender, EventArgs e)
        {
            fator_mode = 1;
            if (fator_mode == 1)
            {
                Configs.front.dark_mode(this);
                Configs.front.menu_dark_mode(ms_topMenu);   
                this.BackColor = Color.FromArgb(30, 30, 30);
            }
            smi_dark.Checked = true;
            smi_light.Checked = false;

        }
        private void smi_preferences_Click(object sender, EventArgs e)
        {
            var openPreferences = new preferences();
            openPreferences.Show();
        }

        private void timer_localhost_Tick(object sender, EventArgs e)
        {
            bool apacheOn = Process.GetProcessesByName("httpd").Any();

            if (apacheOn)
            {
                lb_statusLH.Text = "Apache: Online";
                lb_statusLH.ForeColor = Color.Green;
                fator_detect = 0;
            }
            else
            {
                lb_statusLH.Text = "Apache: offline";
                lb_statusLH.ForeColor = Color.Red;
                fator_detect = 1;
            }

        }
        private void index_Load(object sender, EventArgs e)
        {
            timer_localhost.Interval = 1000;
            timer_localhost.Start();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pl_file_MouseClick(object sender, MouseEventArgs e)
        {
            Configs.events.mouseDetectRight(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
