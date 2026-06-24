using System;
using Newtonsoft.Json;
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
using System.Text.Json.Serialization;

namespace openPHP
{
    public partial class index : Form
    {
        int fator_type = Configs.fator_type = 0;


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
            Configs.openFile.replaceAdress();
            if (fator_type == 0)
            {
                Configs.openFile.openInBrowser(); 
            }
            if (fator_type == 1)
            {
                Configs.openFile.openInNotepad();
            }
        }
        private void smi_selectFile_Click(object sender, EventArgs e)
        { 
           Configs.openFile.initializationManagerFiles();
           ErrorHandler.errorSpecific.pathSourceNotFound();
           tb_path.Text = Configs.collectAdress;
        }
        private void smi_notepad_Click(object sender, EventArgs e)
        {
            smi_notepad.Checked = true;
            smi_browser.Checked = false;
            fator_type = 1;
        }
        private void smi_browser_Click(object sender, EventArgs e)
        {
            smi_browser.Checked = true;
            smi_notepad.Checked = false;
            fator_type = 0;
        }     
    
        private void smi_preferences_Click(object sender, EventArgs e)
        {
            var openPreferences = new preferences();
            openPreferences.Show();
        }

        private void index_Load(object sender, EventArgs e)
        {
          tb_rootFolder.Text = @"C:\laragon\www";

        }
        private void bt_selectFolder_Click(object sender, EventArgs e)
        {
            Configs.openFile.pathFolderBase();
            tb_rootFolder.Text = Configs.rootFolder;
        }
        private void bt_restore_Click(object sender, EventArgs e)
        {
            tb_rootFolder.Text = @"C:\laragon\www";
        }
    }
}
