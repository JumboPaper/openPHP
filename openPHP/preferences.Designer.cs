namespace openPHP
{
    partial class preferences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_rootFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_selectFolder = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_rootFolder
            // 
            this.tb_rootFolder.Location = new System.Drawing.Point(12, 32);
            this.tb_rootFolder.Multiline = true;
            this.tb_rootFolder.Name = "tb_rootFolder";
            this.tb_rootFolder.Size = new System.Drawing.Size(469, 21);
            this.tb_rootFolder.TabIndex = 0;
            this.tb_rootFolder.TextChanged += new System.EventHandler(this.tb_rootFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasta base:";
            // 
            // bt_selectFolder
            // 
            this.bt_selectFolder.BackColor = System.Drawing.SystemColors.Control;
            this.bt_selectFolder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selectFolder.ForeColor = System.Drawing.Color.Black;
            this.bt_selectFolder.Location = new System.Drawing.Point(487, 32);
            this.bt_selectFolder.Name = "bt_selectFolder";
            this.bt_selectFolder.Size = new System.Drawing.Size(38, 21);
            this.bt_selectFolder.TabIndex = 7;
            this.bt_selectFolder.Text = "...";
            this.bt_selectFolder.UseVisualStyleBackColor = false;
            this.bt_selectFolder.Click += new System.EventHandler(this.bt_selectFolder_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 95);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(52, 28);
            this.bt_save.TabIndex = 11;
            this.bt_save.Text = "Salvar";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_restore
            // 
            this.bt_restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restore.Location = new System.Drawing.Point(70, 95);
            this.bt_restore.Name = "bt_restore";
            this.bt_restore.Size = new System.Drawing.Size(71, 28);
            this.bt_restore.TabIndex = 12;
            this.bt_restore.Text = "Restaurar";
            this.bt_restore.UseVisualStyleBackColor = true;
            // 
            // preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 126);
            this.Controls.Add(this.bt_restore);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_selectFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_rootFolder);
            this.MaximizeBox = false;
            this.Name = "preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPHP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.preferences_FormClosing);
            this.Load += new System.EventHandler(this.preferences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rootFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_selectFolder;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_restore;
    }
}