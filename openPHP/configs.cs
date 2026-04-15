using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openPHP
{
    internal class Configs
    {
        public static int fator_type, fator_mode, fator_language, fator_detect;
        public static string collectAdress;
        public static string folderServer;
        public static string url;
        public static string pathSource = @"C:\laragon\www";
        public static OpenFileDialog openfile;
        public static class openFile
        {
            public static void initializationManagerFiles()
            {
                openfile = new OpenFileDialog();
                openfile.InitialDirectory = pathSource;
            }
            public static void initializationManagerFolder()
            {
                using (FolderBrowserDialog openfolder = new FolderBrowserDialog())
                {
                    if (openfolder.ShowDialog() == DialogResult.OK)
                    {
                        pathSource = openfolder.SelectedPath;
                    }
                }
            }
            public static void replaceAdress()
            {
                string pathParallel = collectAdress.Replace(folderServer, "");
                pathParallel = pathParallel.Replace("\\", "/");
                url = "http://localhost/" + pathParallel;
            }
            public static void openInBrowser()
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "chrome.exe",
                    Arguments = Configs.url,
                    UseShellExecute = true
                });
            }
            public static void openInNotepad()
            {
                Process.Start("notepad.exe", collectAdress);
            }
        }
        public static class front
        {
            public static void dark_mode(Control parent)
            { 
                foreach (Control c in parent.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(37, 37, 38);
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                    }

                    if (c.HasChildren)
                        dark_mode(c);
                }
                foreach (Control c in parent.Controls)
                {
                    if (c is Label lbl)
                    {
                        lbl.ForeColor = Color.White;
                    }

                    if (c.HasChildren)
                        dark_mode(c);
                }
            }
            public static void menu_dark_mode(MenuStrip menu)
            {
                menu.BackColor = Color.FromArgb(20, 20, 20);
                menu.ForeColor = Color.White;
                foreach (ToolStripMenuItem item in menu.Items)
                {
                    item.BackColor = Color.FromArgb(20, 20, 20);
                    item.ForeColor = Color.White;
                }
            }

            public static void light_mode(Control parent)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.BackColor = Color.DodgerBlue;
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                    }

                    if (c.HasChildren)
                        light_mode(c);
                }
                foreach (Control c in parent.Controls)
                {
                    if (c is Label lbl)
                    {
                        lbl.ForeColor = Color.Black;
                    }
                    if (c.HasChildren)
                        light_mode(c);
                }
            }
            public static void menu_light_mode(MenuStrip menu)
            {
                menu.BackColor = Control.DefaultBackColor;
                menu.ForeColor = Color.Black;
                foreach (ToolStripMenuItem item in menu.Items)
                {
                    item.BackColor = Control.DefaultBackColor;
                    item.ForeColor = Color.Black;
                }
            }
        }
        public static class errorHandling
        {
            public static void localHostOffline()
            {
                DialogResult question = MessageBox.Show("O Local Host está offline deseja inicia-lo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (question == DialogResult.Yes)
                    {
                        Process.Start(@"C:\laragon\laragon.exe");
                        return;
                    }
            }
            public static void pathSourceNotFound()
            {
                if (!Directory.Exists(pathSource) && fator_language == 0)
                {
                    MessageBox.Show("Atenção a pasta raiz (" + pathSource + ") não foi encontrado", "Erro #1",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Directory.Exists(pathSource) && fator_language == 1)
                {
                    MessageBox.Show("Warning the root folder (" + pathSource + ") not found", "Error #1",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string path = openfile.FileName;
                    string c_final = collectAdress = path;
                }
            }



        }


    }
}
