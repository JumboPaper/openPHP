using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace openPHP
{
    internal class Configs
    {
        public static int fator_type;
        public static string rootFolder, collectAdress, folderServer, url, pathSource = @"C:\laragon\www";
        public static OpenFileDialog openfile;
        public static class openFile 
        {
            public static void initializationManagerFiles() //Inicializa o OpenFileDialog
            {
                openfile = new OpenFileDialog();
                openfile.Title = " Selecione um arquivo para abrir no local Host";
                openfile.InitialDirectory = pathSource;
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string path = openfile.FileName;
                    string c_final = collectAdress = path;
                }
            }
            public static void initializationManagerFolder() //Inicializa o FolderBrowserDialog
            {
                using (FolderBrowserDialog openfolder = new FolderBrowserDialog())
                {
                    if (openfolder.ShowDialog() == DialogResult.OK)
                    {
                        pathSource = openfolder.SelectedPath;
                    }
                }
            }
            public static void replaceAdress() // Subistitui o caminho do arquivo selecionado para o formato de URL do localhost
            {
                string pathParallel = collectAdress.Replace(folderServer, "");
                pathParallel = pathParallel.Replace("\\", "/");
                url = "http://localhost/" + pathParallel;
            }
            public static void openInBrowser() //Abre o arquivo selecionado no navegador padrão
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "chrome.exe",
                    Arguments = Configs.url,
                    UseShellExecute = true
                });
            }
            public static void openInNotepad() // Abre o arquivo selecionado no notepad
            {
                Process.Start("notepad.exe", collectAdress);
            }
            public static void pathFolderBase()
            {
                using (FolderBrowserDialog openfolder = new FolderBrowserDialog())
                {
                    if (openfolder.ShowDialog() == DialogResult.OK)
                    {
                        rootFolder = openfolder.SelectedPath;
                    }
                }
            }
        
    }
}}

