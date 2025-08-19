namespace CalculadoraDeImc
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
            this.lblCalcule = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.bxbCalcular = new System.Windows.Forms.Button();
            this.lblImc = new System.Windows.Forms.Label();
            this.txbIMC = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalcule
            // 
            this.lblCalcule.AutoSize = true;
            this.lblCalcule.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcule.Location = new System.Drawing.Point(123, 62);
            this.lblCalcule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcule.Name = "lblCalcule";
            this.lblCalcule.Size = new System.Drawing.Size(290, 39);
            this.lblCalcule.TabIndex = 0;
            this.lblCalcule.Text = "Calcule Seu IMC";
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Location = new System.Drawing.Point(134, 173);
            this.LblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(45, 20);
            this.LblPeso.TabIndex = 1;
            this.LblPeso.Text = "Peso";
            this.LblPeso.Click += new System.EventHandler(this.LblPeso_Click);
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(243, 173);
            this.txbPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(222, 24);
            this.txbPeso.TabIndex = 2;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(134, 234);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 18);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(243, 230);
            this.txbAltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(222, 24);
            this.txbAltura.TabIndex = 4;
            // 
            // bxbCalcular
            // 
            this.bxbCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bxbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxbCalcular.Location = new System.Drawing.Point(140, 302);
            this.bxbCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bxbCalcular.Name = "bxbCalcular";
            this.bxbCalcular.Size = new System.Drawing.Size(327, 54);
            this.bxbCalcular.TabIndex = 5;
            this.bxbCalcular.Text = "Calcular";
            this.bxbCalcular.UseVisualStyleBackColor = false;
            this.bxbCalcular.Click += new System.EventHandler(this.bxbCalcular_Click);
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImc.Location = new System.Drawing.Point(134, 417);
            this.lblImc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(43, 24);
            this.lblImc.TabIndex = 6;
            this.lblImc.Text = "IMC";
            // 
            // txbIMC
            // 
            this.txbIMC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbIMC.Location = new System.Drawing.Point(223, 417);
            this.txbIMC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIMC.Name = "txbIMC";
            this.txbIMC.Size = new System.Drawing.Size(242, 24);
            this.txbIMC.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Red;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(140, 544);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbIMC);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.bxbCalcular);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.lblCalcule);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalcule;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Button bxbCalcular;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.TextBox txbIMC;
        private System.Windows.Forms.Label lblResultado;
    }
}

