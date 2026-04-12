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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bt_execute = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.ms_topMenu = new System.Windows.Forms.MenuStrip();
            this.smi_files = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_selectFile = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_openWith = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_notepad = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_browser = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_display = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_darkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_light = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_dark = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_language = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_ptBR = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_enUSA = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_selectFile = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.lb_localHost = new System.Windows.Forms.Label();
            this.timer_localhost = new System.Windows.Forms.Timer(this.components);
            this.ms_topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(12, 30);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(366, 20);
            this.tb_path.TabIndex = 1;
            // 
            // bt_execute
            // 
            this.bt_execute.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_execute.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_execute.ForeColor = System.Drawing.Color.White;
            this.bt_execute.Location = new System.Drawing.Point(12, 56);
            this.bt_execute.Name = "bt_execute";
            this.bt_execute.Size = new System.Drawing.Size(85, 23);
            this.bt_execute.TabIndex = 2;
            this.bt_execute.Text = "Executar";
            this.bt_execute.UseVisualStyleBackColor = false;
            this.bt_execute.Click += new System.EventHandler(this.bt_execute_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_clear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.ForeColor = System.Drawing.Color.White;
            this.bt_clear.Location = new System.Drawing.Point(103, 56);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(94, 23);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "Limpar";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // ms_topMenu
            // 
            this.ms_topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_files,
            this.smi_display});
            this.ms_topMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_topMenu.Name = "ms_topMenu";
            this.ms_topMenu.Size = new System.Drawing.Size(440, 24);
            this.ms_topMenu.TabIndex = 5;
            this.ms_topMenu.Text = "menuStrip1";
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
            this.smi_files.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.smi_openWith.Click += new System.EventHandler(this.smi_openWith_Click);
            // 
            // smi_notepad
            // 
            this.smi_notepad.Name = "smi_notepad";
            this.smi_notepad.Size = new System.Drawing.Size(154, 22);
            this.smi_notepad.Text = "Bloco de Notas";
            this.smi_notepad.Click += new System.EventHandler(this.smi_notepad_Click);
            // 
            // smi_browser
            // 
            this.smi_browser.Checked = true;
            this.smi_browser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smi_browser.Name = "smi_browser";
            this.smi_browser.Size = new System.Drawing.Size(154, 22);
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
            // smi_display
            // 
            this.smi_display.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_darkMode,
            this.smi_language});
            this.smi_display.Name = "smi_display";
            this.smi_display.Size = new System.Drawing.Size(48, 20);
            this.smi_display.Text = "Exibir";
            // 
            // smi_darkMode
            // 
            this.smi_darkMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_light,
            this.smi_dark});
            this.smi_darkMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smi_darkMode.Name = "smi_darkMode";
            this.smi_darkMode.Size = new System.Drawing.Size(189, 22);
            this.smi_darkMode.Text = "◐ Modo Escuro ";
            this.smi_darkMode.Click += new System.EventHandler(this.smi_darkMode_Click);
            // 
            // smi_light
            // 
            this.smi_light.Checked = true;
            this.smi_light.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smi_light.Name = "smi_light";
            this.smi_light.Size = new System.Drawing.Size(124, 22);
            this.smi_light.Text = "Claro ⚪";
            this.smi_light.Click += new System.EventHandler(this.smi_light_Click);
            // 
            // smi_dark
            // 
            this.smi_dark.Name = "smi_dark";
            this.smi_dark.Size = new System.Drawing.Size(124, 22);
            this.smi_dark.Text = "Escuro ⚫️";
            this.smi_dark.Click += new System.EventHandler(this.smi_dark_Click);
            // 
            // smi_language
            // 
            this.smi_language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_ptBR,
            this.smi_enUSA});
            this.smi_language.Name = "smi_language";
            this.smi_language.Size = new System.Drawing.Size(189, 22);
            this.smi_language.Text = "🌎 Idioma / Language";
            // 
            // smi_ptBR
            // 
            this.smi_ptBR.Checked = true;
            this.smi_ptBR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smi_ptBR.Name = "smi_ptBR";
            this.smi_ptBR.Size = new System.Drawing.Size(116, 22);
            this.smi_ptBR.Text = "PT-BR";
            this.smi_ptBR.Click += new System.EventHandler(this.smi_ptBR_Click);
            // 
            // smi_enUSA
            // 
            this.smi_enUSA.Name = "smi_enUSA";
            this.smi_enUSA.Size = new System.Drawing.Size(116, 22);
            this.smi_enUSA.Text = "EN-USA";
            this.smi_enUSA.Click += new System.EventHandler(this.smi_enUSA_Click);
            // 
            // bt_selectFile
            // 
            this.bt_selectFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_selectFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selectFile.ForeColor = System.Drawing.Color.White;
            this.bt_selectFile.Location = new System.Drawing.Point(383, 30);
            this.bt_selectFile.Name = "bt_selectFile";
            this.bt_selectFile.Size = new System.Drawing.Size(38, 23);
            this.bt_selectFile.TabIndex = 6;
            this.bt_selectFile.Text = "...";
            this.bt_selectFile.UseVisualStyleBackColor = false;
            this.bt_selectFile.Click += new System.EventHandler(this.smi_selectFile_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(349, 92);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(91, 12);
            this.version.TabIndex = 7;
            this.version.Text = "version 1.0.0 (BETA)";
            // 
            // lb_localHost
            // 
            this.lb_localHost.AutoSize = true;
            this.lb_localHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_localHost.Location = new System.Drawing.Point(-2, 92);
            this.lb_localHost.Name = "lb_localHost";
            this.lb_localHost.Size = new System.Drawing.Size(50, 12);
            this.lb_localHost.TabIndex = 8;
            this.lb_localHost.Text = "Apache: ";
            // 
            // timer_localhost
            // 
            this.timer_localhost.Tick += new System.EventHandler(this.timer_localhost_Tick);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(440, 104);
            this.Controls.Add(this.lb_localHost);
            this.Controls.Add(this.version);
            this.Controls.Add(this.bt_selectFile);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_execute);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.ms_topMenu);
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
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.MenuStrip ms_topMenu;
        private System.Windows.Forms.ToolStripMenuItem smi_files;
        private System.Windows.Forms.ToolStripMenuItem smi_selectFile;
        private System.Windows.Forms.ToolStripMenuItem smi_openWith;
        private System.Windows.Forms.ToolStripMenuItem smi_notepad;
        private System.Windows.Forms.ToolStripMenuItem smi_browser;
        private System.Windows.Forms.Button bt_selectFile;
        private System.Windows.Forms.ToolStripMenuItem smi_display;
        private System.Windows.Forms.ToolStripMenuItem smi_darkMode;
        private System.Windows.Forms.ToolStripMenuItem smi_language;
        private System.Windows.Forms.ToolStripMenuItem smi_ptBR;
        private System.Windows.Forms.ToolStripMenuItem smi_enUSA;
        private System.Windows.Forms.ToolStripMenuItem smi_light;
        private System.Windows.Forms.ToolStripMenuItem smi_dark;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.ToolStripMenuItem smi_preferences;
        private System.Windows.Forms.Label lb_localHost;
        private System.Windows.Forms.Timer timer_localhost;
    }
}

