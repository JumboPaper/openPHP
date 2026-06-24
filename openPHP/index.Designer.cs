namespace openPHP
{
    partial class index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bt_execute = new System.Windows.Forms.Button();
            this.ms_topMenu = new System.Windows.Forms.MenuStrip();
            this.smi_files = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_selectFile = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_openWith = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_notepad = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_browser = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_selectFile = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rootFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_selectFolder = new System.Windows.Forms.Button();
            this.bt_restore = new System.Windows.Forms.Button();
            this.ms_topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_path
            // 
            this.tb_path.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_path.Location = new System.Drawing.Point(12, 92);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(560, 20);
            this.tb_path.TabIndex = 1;
            // 
            // bt_execute
            // 
            this.bt_execute.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_execute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_execute.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_execute.Location = new System.Drawing.Point(12, 130);
            this.bt_execute.Name = "bt_execute";
            this.bt_execute.Size = new System.Drawing.Size(84, 24);
            this.bt_execute.TabIndex = 2;
            this.bt_execute.Text = "Abrir";
            this.bt_execute.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_execute.UseVisualStyleBackColor = false;
            this.bt_execute.Click += new System.EventHandler(this.bt_execute_Click);
            // 
            // ms_topMenu
            // 
            this.ms_topMenu.BackColor = System.Drawing.SystemColors.Control;
            this.ms_topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_files});
            this.ms_topMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_topMenu.Name = "ms_topMenu";
            this.ms_topMenu.Size = new System.Drawing.Size(629, 24);
            this.ms_topMenu.TabIndex = 5;
            this.ms_topMenu.Text = "ms_topMenu";
            // 
            // smi_files
            // 
            this.smi_files.BackColor = System.Drawing.SystemColors.Control;
            this.smi_files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_selectFile,
            this.smi_openWith,
            this.smi_preferences});
            this.smi_files.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smi_files.Name = "smi_files";
            this.smi_files.Size = new System.Drawing.Size(66, 20);
            this.smi_files.Text = "Arquivos";
            // 
            // smi_selectFile
            // 
            this.smi_selectFile.Name = "smi_selectFile";
            this.smi_selectFile.Size = new System.Drawing.Size(180, 22);
            this.smi_selectFile.Text = "Novo Arquivo";
            this.smi_selectFile.Click += new System.EventHandler(this.smi_selectFile_Click);
            // 
            // smi_openWith
            // 
            this.smi_openWith.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_notepad,
            this.smi_browser});
            this.smi_openWith.Name = "smi_openWith";
            this.smi_openWith.Size = new System.Drawing.Size(180, 22);
            this.smi_openWith.Text = "Abrir com...";
            // 
            // smi_notepad
            // 
            this.smi_notepad.Name = "smi_notepad";
            this.smi_notepad.Size = new System.Drawing.Size(180, 22);
            this.smi_notepad.Text = "Bloco de Notas";
            this.smi_notepad.Click += new System.EventHandler(this.smi_notepad_Click);
            // 
            // smi_browser
            // 
            this.smi_browser.Checked = true;
            this.smi_browser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smi_browser.Name = "smi_browser";
            this.smi_browser.Size = new System.Drawing.Size(180, 22);
            this.smi_browser.Text = "Navegador";
            this.smi_browser.Click += new System.EventHandler(this.smi_browser_Click);
            // 
            // smi_preferences
            // 
            this.smi_preferences.Name = "smi_preferences";
            this.smi_preferences.Size = new System.Drawing.Size(180, 22);
            this.smi_preferences.Text = "Prefêrencias";
            this.smi_preferences.Click += new System.EventHandler(this.smi_preferences_Click);
            // 
            // bt_selectFile
            // 
            this.bt_selectFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_selectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selectFile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_selectFile.Location = new System.Drawing.Point(579, 92);
            this.bt_selectFile.Name = "bt_selectFile";
            this.bt_selectFile.Size = new System.Drawing.Size(38, 24);
            this.bt_selectFile.TabIndex = 6;
            this.bt_selectFile.Text = "...";
            this.bt_selectFile.UseVisualStyleBackColor = false;
            this.bt_selectFile.Click += new System.EventHandler(this.smi_selectFile_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(556, 142);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(61, 12);
            this.version.TabIndex = 7;
            this.version.Text = "version 1.0.0 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Caminho base:\r\n";
            // 
            // tb_rootFolder
            // 
            this.tb_rootFolder.Location = new System.Drawing.Point(12, 49);
            this.tb_rootFolder.Name = "tb_rootFolder";
            this.tb_rootFolder.Size = new System.Drawing.Size(560, 20);
            this.tb_rootFolder.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pasta base:";
            // 
            // bt_selectFolder
            // 
            this.bt_selectFolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_selectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selectFolder.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_selectFolder.Location = new System.Drawing.Point(579, 49);
            this.bt_selectFolder.Name = "bt_selectFolder";
            this.bt_selectFolder.Size = new System.Drawing.Size(38, 24);
            this.bt_selectFolder.TabIndex = 12;
            this.bt_selectFolder.Text = "...";
            this.bt_selectFolder.UseVisualStyleBackColor = false;
            this.bt_selectFolder.Click += new System.EventHandler(this.bt_selectFolder_Click);
            // 
            // bt_restore
            // 
            this.bt_restore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restore.Location = new System.Drawing.Point(102, 130);
            this.bt_restore.Name = "bt_restore";
            this.bt_restore.Size = new System.Drawing.Size(89, 25);
            this.bt_restore.TabIndex = 13;
            this.bt_restore.Text = "Restaurar";
            this.bt_restore.UseVisualStyleBackColor = true;
            this.bt_restore.Click += new System.EventHandler(this.bt_restore_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(629, 158);
            this.Controls.Add(this.bt_restore);
            this.Controls.Add(this.bt_selectFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_rootFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_execute);
            this.Controls.Add(this.version);
            this.Controls.Add(this.bt_selectFile);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.ms_topMenu);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_topMenu;
            this.MaximizeBox = false;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPHP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.index_FormClosing);
            this.Load += new System.EventHandler(this.index_Load);
            this.ms_topMenu.ResumeLayout(false);
            this.ms_topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button bt_execute;
        private System.Windows.Forms.MenuStrip ms_topMenu;
        private System.Windows.Forms.ToolStripMenuItem smi_files;
        private System.Windows.Forms.ToolStripMenuItem smi_selectFile;
        private System.Windows.Forms.ToolStripMenuItem smi_openWith;
        private System.Windows.Forms.ToolStripMenuItem smi_notepad;
        private System.Windows.Forms.ToolStripMenuItem smi_browser;
        private System.Windows.Forms.Button bt_selectFile;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.ToolStripMenuItem smi_preferences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rootFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_selectFolder;
        private System.Windows.Forms.Button bt_restore;
    }
}

