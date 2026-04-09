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
            this.tb_caminho = new System.Windows.Forms.TextBox();
            this.bt_abrir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smi_arquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_select = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_abrirCom = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_notepad = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_navegador = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_darkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_caminho
            // 
            this.tb_caminho.Location = new System.Drawing.Point(12, 40);
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.Size = new System.Drawing.Size(366, 20);
            this.tb_caminho.TabIndex = 1;
            // 
            // bt_abrir
            // 
            this.bt_abrir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_abrir.Location = new System.Drawing.Point(12, 66);
            this.bt_abrir.Name = "bt_abrir";
            this.bt_abrir.Size = new System.Drawing.Size(85, 23);
            this.bt_abrir.TabIndex = 2;
            this.bt_abrir.Text = "Executar";
            this.bt_abrir.UseVisualStyleBackColor = true;
            this.bt_abrir.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(103, 66);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(85, 23);
            this.bt_limpar.TabIndex = 4;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_arquivos,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smi_arquivos
            // 
            this.smi_arquivos.BackColor = System.Drawing.SystemColors.Control;
            this.smi_arquivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_select,
            this.smi_abrirCom});
            this.smi_arquivos.Name = "smi_arquivos";
            this.smi_arquivos.Size = new System.Drawing.Size(66, 20);
            this.smi_arquivos.Text = "Arquivos";
            this.smi_arquivos.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // smi_select
            // 
            this.smi_select.Name = "smi_select";
            this.smi_select.Size = new System.Drawing.Size(180, 22);
            this.smi_select.Text = "Selecionar arquivo";
            this.smi_select.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // smi_abrirCom
            // 
            this.smi_abrirCom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_notepad,
            this.smi_navegador});
            this.smi_abrirCom.Name = "smi_abrirCom";
            this.smi_abrirCom.Size = new System.Drawing.Size(180, 22);
            this.smi_abrirCom.Text = "Abrir com...";
            this.smi_abrirCom.Click += new System.EventHandler(this.selecionarPastaToolStripMenuItem_Click);
            // 
            // smi_notepad
            // 
            this.smi_notepad.Name = "smi_notepad";
            this.smi_notepad.Size = new System.Drawing.Size(180, 22);
            this.smi_notepad.Text = "Notepad";
            this.smi_notepad.Click += new System.EventHandler(this.smi_notepad_Click);
            // 
            // smi_navegador
            // 
            this.smi_navegador.Checked = true;
            this.smi_navegador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smi_navegador.Name = "smi_navegador";
            this.smi_navegador.Size = new System.Drawing.Size(180, 22);
            this.smi_navegador.Text = "Navegador";
            this.smi_navegador.Click += new System.EventHandler(this.smi_navegador_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_darkMode});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // smi_darkMode
            // 
            this.smi_darkMode.Name = "smi_darkMode";
            this.smi_darkMode.Size = new System.Drawing.Size(180, 22);
            this.smi_darkMode.Text = "Modo Escuro ☼";
            this.smi_darkMode.Click += new System.EventHandler(this.smi_darkMode_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(440, 104);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_abrir);
            this.Controls.Add(this.tb_caminho);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPHP (1.1 version)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.index_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_caminho;
        private System.Windows.Forms.Button bt_abrir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smi_arquivos;
        private System.Windows.Forms.ToolStripMenuItem smi_select;
        private System.Windows.Forms.ToolStripMenuItem smi_abrirCom;
        private System.Windows.Forms.ToolStripMenuItem smi_notepad;
        private System.Windows.Forms.ToolStripMenuItem smi_navegador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smi_darkMode;
    }
}

