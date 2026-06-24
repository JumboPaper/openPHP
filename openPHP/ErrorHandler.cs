using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static openPHP.Configs;

namespace openPHP
{
    internal class ErrorHandler
    {
        public static class errorSpecific
        {
            public static void pathSourceNotFound()
            {
                if (!Directory.Exists(pathSource))
                {
                    MessageBox.Show("Atenção a pasta raiz (" + pathSource + ") não foi encontrada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
        }
    }
}
