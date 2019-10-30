namespace Atividade4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.configMenu = new System.Windows.Forms.MenuStrip();
            this.configStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altoContrasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliadoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.configMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // configMenu
            // 
            this.configMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.configMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configStripMenuItem});
            this.configMenu.Location = new System.Drawing.Point(10, 0);
            this.configMenu.Name = "configMenu";
            this.configMenu.Size = new System.Drawing.Size(780, 24);
            this.configMenu.TabIndex = 0;
            this.configMenu.Text = "menuStrip1";
            // 
            // configStripMenuItem
            // 
            this.configStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altoContrasteMenuItem,
            this.ampliadoMenuItem});
            this.configStripMenuItem.Name = "configStripMenuItem";
            this.configStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configStripMenuItem.Text = "Configurações";
            // 
            // altoContrasteMenuItem
            // 
            this.altoContrasteMenuItem.Name = "altoContrasteMenuItem";
            this.altoContrasteMenuItem.Size = new System.Drawing.Size(181, 22);
            this.altoContrasteMenuItem.Text = "Modo alto contraste";
            this.altoContrasteMenuItem.Click += new System.EventHandler(this.modoAltoContrasteToolStripMenuItem_Click);
            // 
            // ampliadoMenuItem
            // 
            this.ampliadoMenuItem.Name = "ampliadoMenuItem";
            this.ampliadoMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ampliadoMenuItem.Text = "Modo ampliado";
            this.ampliadoMenuItem.Click += new System.EventHandler(this.modoAmpliadoToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(10, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(780, 416);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.configMenu);
            this.MainMenuStrip = this.configMenu;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "TDGI - Atividade 4";
            this.configMenu.ResumeLayout(false);
            this.configMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip configMenu;
        private System.Windows.Forms.ToolStripMenuItem configStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altoContrasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliadoMenuItem;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}

