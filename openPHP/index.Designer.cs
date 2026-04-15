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
            this.bt_selectFile = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.lb_statusLH = new System.Windows.Forms.Label();
            this.timer_localhost = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pl_files = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ms_topMenu.SuspendLayout();
            this.pl_files.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(12, 268);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(645, 20);
            this.tb_path.TabIndex = 1;
            // 
            // bt_execute
            // 
            this.bt_execute.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_execute.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_execute.ForeColor = System.Drawing.Color.White;
            this.bt_execute.Location = new System.Drawing.Point(13, 294);
            this.bt_execute.Name = "bt_execute";
            this.bt_execute.Size = new System.Drawing.Size(85, 23);
            this.bt_execute.TabIndex = 2;
            this.bt_execute.Text = "Abrir";
            this.bt_execute.UseVisualStyleBackColor = false;
            this.bt_execute.Click += new System.EventHandler(this.bt_execute_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_clear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.ForeColor = System.Drawing.Color.White;
            this.bt_clear.Location = new System.Drawing.Point(103, 294);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(94, 23);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "Limpar";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // ms_topMenu
            // 
            this.ms_topMenu.BackColor = System.Drawing.SystemColors.Control;
            this.ms_topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_files,
            this.smi_display});
            this.ms_topMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_topMenu.Name = "ms_topMenu";
            this.ms_topMenu.Size = new System.Drawing.Size(705, 24);
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
            this.smi_darkMode});
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
            this.smi_darkMode.Size = new System.Drawing.Size(180, 22);
            this.smi_darkMode.Text = "◐ Modo Escuro ";
            // 
            // smi_light
            // 
            this.smi_light.Checked = true;
            this.smi_light.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smi_light.Name = "smi_light";
            this.smi_light.Size = new System.Drawing.Size(180, 22);
            this.smi_light.Text = "Claro ⚪";
            this.smi_light.Click += new System.EventHandler(this.smi_light_Click);
            // 
            // smi_dark
            // 
            this.smi_dark.Name = "smi_dark";
            this.smi_dark.Size = new System.Drawing.Size(180, 22);
            this.smi_dark.Text = "Escuro ⚫️";
            this.smi_dark.Click += new System.EventHandler(this.smi_dark_Click);
            // 
            // bt_selectFile
            // 
            this.bt_selectFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_selectFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selectFile.ForeColor = System.Drawing.Color.White;
            this.bt_selectFile.Location = new System.Drawing.Point(663, 268);
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
            this.version.Location = new System.Drawing.Point(610, 321);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(91, 12);
            this.version.TabIndex = 7;
            this.version.Text = "version 1.0.0 (BETA)";
            // 
            // lb_statusLH
            // 
            this.lb_statusLH.AutoSize = true;
            this.lb_statusLH.BackColor = System.Drawing.Color.Transparent;
            this.lb_statusLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statusLH.ForeColor = System.Drawing.Color.Black;
            this.lb_statusLH.Location = new System.Drawing.Point(203, 299);
            this.lb_statusLH.Name = "lb_statusLH";
            this.lb_statusLH.Size = new System.Drawing.Size(50, 12);
            this.lb_statusLH.TabIndex = 8;
            this.lb_statusLH.Text = "Apache: ";
            // 
            // timer_localhost
            // 
            this.timer_localhost.Tick += new System.EventHandler(this.timer_localhost_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(91, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 18);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pl_files
            // 
            this.pl_files.AutoScroll = true;
            this.pl_files.BackColor = System.Drawing.Color.White;
            this.pl_files.Controls.Add(this.label2);
            this.pl_files.Controls.Add(this.panel3);
            this.pl_files.Controls.Add(this.label1);
            this.pl_files.Controls.Add(this.panel1);
            this.pl_files.Location = new System.Drawing.Point(12, 27);
            this.pl_files.Name = "pl_files";
            this.pl_files.Size = new System.Drawing.Size(681, 235);
            this.pl_files.TabIndex = 10;
            this.pl_files.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pl_file_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivos /";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 235);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(625, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "/ Tipo";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(705, 342);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_execute);
            this.Controls.Add(this.lb_statusLH);
            this.Controls.Add(this.version);
            this.Controls.Add(this.bt_selectFile);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.ms_topMenu);
            this.Controls.Add(this.pl_files);
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
            this.pl_files.ResumeLayout(false);
            this.pl_files.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem smi_light;
        private System.Windows.Forms.ToolStripMenuItem smi_dark;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.ToolStripMenuItem smi_preferences;
        private System.Windows.Forms.Label lb_statusLH;
        private System.Windows.Forms.Timer timer_localhost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pl_files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

