
namespace DeliciariaDoChupeto
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDeTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaDoÍmovelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(776, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaToolStripMenuItem,
            this.conversorDeTemperaturaToolStripMenuItem,
            this.áreaDoÍmovelToolStripMenuItem});
            this.programasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.tabuadaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // conversorDeTemperaturaToolStripMenuItem
            // 
            this.conversorDeTemperaturaToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.conversorDeTemperaturaToolStripMenuItem.Name = "conversorDeTemperaturaToolStripMenuItem";
            this.conversorDeTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.conversorDeTemperaturaToolStripMenuItem.Text = "Conversor de Temperatura";
            this.conversorDeTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.conversorDeTemperaturaToolStripMenuItem_Click);
            // 
            // áreaDoÍmovelToolStripMenuItem
            // 
            this.áreaDoÍmovelToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.áreaDoÍmovelToolStripMenuItem.Name = "áreaDoÍmovelToolStripMenuItem";
            this.áreaDoÍmovelToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.áreaDoÍmovelToolStripMenuItem.Text = "Área do Ímovel";
            this.áreaDoÍmovelToolStripMenuItem.Click += new System.EventHandler(this.áreaDoÍmovelToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeliciariaDoChupeto.Properties.Resources.cfa88be68fb86a1517e5eed7a0657ae6_transformed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 447);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliciariaDosChupetos";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDeTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaDoÍmovelToolStripMenuItem;
    }
}

