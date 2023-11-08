
namespace DeliciariaDoChupeto
{
    partial class frmconversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconversor));
            this.btncomandop = new System.Windows.Forms.Button();
            this.lblcomando = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.txttemp1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.btncalculare = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcularr = new System.Windows.Forms.Button();
            this.btncalcularp = new System.Windows.Forms.Button();
            this.btncomandoe = new System.Windows.Forms.Button();
            this.btncomandor = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncomandop
            // 
            this.btncomandop.BackColor = System.Drawing.Color.White;
            this.btncomandop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomandop.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomandop.Location = new System.Drawing.Point(632, 304);
            this.btncomandop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncomandop.Name = "btncomandop";
            this.btncomandop.Size = new System.Drawing.Size(100, 32);
            this.btncomandop.TabIndex = 27;
            this.btncomandop.Text = "Para";
            this.btncomandop.UseVisualStyleBackColor = false;
            this.btncomandop.Click += new System.EventHandler(this.btncomandop_Click);
            // 
            // lblcomando
            // 
            this.lblcomando.AutoSize = true;
            this.lblcomando.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomando.Location = new System.Drawing.Point(574, 161);
            this.lblcomando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcomando.Name = "lblcomando";
            this.lblcomando.Size = new System.Drawing.Size(193, 16);
            this.lblcomando.TabIndex = 26;
            this.lblcomando.Text = "Clique para alterar o comando:";
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(299, 161);
            this.txtresult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(157, 239);
            this.txtresult.TabIndex = 25;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(249, 121);
            this.lblresult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(246, 22);
            this.lblresult.TabIndex = 24;
            this.lblresult.Text = "Os valores de Conversão são:";
            // 
            // txttemp1
            // 
            this.txttemp1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttemp1.Location = new System.Drawing.Point(433, 78);
            this.txttemp1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttemp1.Name = "txttemp1";
            this.txttemp1.Size = new System.Drawing.Size(114, 25);
            this.txttemp1.TabIndex = 23;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(187, 78);
            this.lblnum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(242, 22);
            this.lblnum1.TabIndex = 22;
            this.lblnum1.Text = "Digite a temperatura em °C:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(201, 12);
            this.lblnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(348, 37);
            this.lblnome.TabIndex = 21;
            this.lblnome.Text = "Conversor do Geladeiro ";
            // 
            // btncalculare
            // 
            this.btncalculare.BackColor = System.Drawing.Color.White;
            this.btncalculare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculare.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculare.Location = new System.Drawing.Point(207, 432);
            this.btncalculare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncalculare.Name = "btncalculare";
            this.btncalculare.Size = new System.Drawing.Size(97, 32);
            this.btncalculare.TabIndex = 20;
            this.btncalculare.Text = "Calcular";
            this.btncalculare.UseVisualStyleBackColor = false;
            this.btncalculare.Click += new System.EventHandler(this.btncalculare_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.White;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(446, 432);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(79, 32);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcularr
            // 
            this.btncalcularr.BackColor = System.Drawing.Color.White;
            this.btncalcularr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcularr.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularr.Location = new System.Drawing.Point(207, 432);
            this.btncalcularr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncalcularr.Name = "btncalcularr";
            this.btncalcularr.Size = new System.Drawing.Size(97, 32);
            this.btncalcularr.TabIndex = 18;
            this.btncalcularr.Text = "Calcular";
            this.btncalcularr.UseVisualStyleBackColor = false;
            this.btncalcularr.Visible = false;
            this.btncalcularr.Click += new System.EventHandler(this.btncalcularr_Click);
            // 
            // btncalcularp
            // 
            this.btncalcularp.BackColor = System.Drawing.Color.White;
            this.btncalcularp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcularp.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularp.Location = new System.Drawing.Point(207, 432);
            this.btncalcularp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncalcularp.Name = "btncalcularp";
            this.btncalcularp.Size = new System.Drawing.Size(97, 32);
            this.btncalcularp.TabIndex = 17;
            this.btncalcularp.Text = "Calcular";
            this.btncalcularp.UseVisualStyleBackColor = false;
            this.btncalcularp.Visible = false;
            this.btncalcularp.Click += new System.EventHandler(this.btncalcularp_Click);
            // 
            // btncomandoe
            // 
            this.btncomandoe.BackColor = System.Drawing.Color.White;
            this.btncomandoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomandoe.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomandoe.Location = new System.Drawing.Point(632, 248);
            this.btncomandoe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncomandoe.Name = "btncomandoe";
            this.btncomandoe.Size = new System.Drawing.Size(100, 32);
            this.btncomandoe.TabIndex = 16;
            this.btncomandoe.Text = "Enquanto";
            this.btncomandoe.UseVisualStyleBackColor = false;
            this.btncomandoe.Click += new System.EventHandler(this.btncomandoe_Click);
            // 
            // btncomandor
            // 
            this.btncomandor.BackColor = System.Drawing.Color.White;
            this.btncomandor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomandor.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomandor.Location = new System.Drawing.Point(632, 196);
            this.btncomandor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncomandor.Name = "btncomandor";
            this.btncomandor.Size = new System.Drawing.Size(100, 32);
            this.btncomandor.TabIndex = 15;
            this.btncomandor.Text = "Repita";
            this.btncomandor.UseVisualStyleBackColor = false;
            this.btncomandor.Click += new System.EventHandler(this.btncomandor_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.White;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Montserrat Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(19, 12);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(79, 32);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmconversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(791, 475);
            this.Controls.Add(this.btncomandop);
            this.Controls.Add(this.lblcomando);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txttemp1);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btncalculare);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcularr);
            this.Controls.Add(this.btncalcularp);
            this.Controls.Add(this.btncomandoe);
            this.Controls.Add(this.btncomandor);
            this.Controls.Add(this.btnvoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmconversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura do Geladeiro";
            this.Load += new System.EventHandler(this.frmconversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncomandop;
        private System.Windows.Forms.Label lblcomando;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txttemp1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btncalculare;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcularr;
        private System.Windows.Forms.Button btncalcularp;
        private System.Windows.Forms.Button btncomandoe;
        private System.Windows.Forms.Button btncomandor;
        private System.Windows.Forms.Button btnvoltar;
    }
}