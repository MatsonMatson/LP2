namespace pTesteMetodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.BtnTestarIguais = new System.Windows.Forms.Button();
            this.BtnInserirTexto = new System.Windows.Forms.Button();
            this.BtnInserirAsteriscos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(353, 50);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(166, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(353, 95);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(166, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // BtnTestarIguais
            // 
            this.BtnTestarIguais.Location = new System.Drawing.Point(192, 186);
            this.BtnTestarIguais.Name = "BtnTestarIguais";
            this.BtnTestarIguais.Size = new System.Drawing.Size(116, 78);
            this.BtnTestarIguais.TabIndex = 2;
            this.BtnTestarIguais.Text = "Testar Iguais ";
            this.BtnTestarIguais.UseVisualStyleBackColor = true;
            this.BtnTestarIguais.Click += new System.EventHandler(this.BtnTestarIguais_Click);
            // 
            // BtnInserirTexto
            // 
            this.BtnInserirTexto.Location = new System.Drawing.Point(324, 186);
            this.BtnInserirTexto.Name = "BtnInserirTexto";
            this.BtnInserirTexto.Size = new System.Drawing.Size(116, 78);
            this.BtnInserirTexto.TabIndex = 3;
            this.BtnInserirTexto.Text = "Inserir Texto 1 no Texto 2";
            this.BtnInserirTexto.UseVisualStyleBackColor = true;
            this.BtnInserirTexto.Click += new System.EventHandler(this.BtnInserirTexto_Click);
            // 
            // BtnInserirAsteriscos
            // 
            this.BtnInserirAsteriscos.Location = new System.Drawing.Point(457, 186);
            this.BtnInserirAsteriscos.Name = "BtnInserirAsteriscos";
            this.BtnInserirAsteriscos.Size = new System.Drawing.Size(116, 78);
            this.BtnInserirAsteriscos.TabIndex = 4;
            this.BtnInserirAsteriscos.Text = "Inserir Asteristicos no Texto 1";
            this.BtnInserirAsteriscos.UseVisualStyleBackColor = true;
            this.BtnInserirAsteriscos.Click += new System.EventHandler(this.BtnInserirAsteriscos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Palavra 2";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(588, 186);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(116, 78);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 576);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnInserirAsteriscos);
            this.Controls.Add(this.BtnInserirTexto);
            this.Controls.Add(this.BtnTestarIguais);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button BtnTestarIguais;
        private System.Windows.Forms.Button BtnInserirTexto;
        private System.Windows.Forms.Button BtnInserirAsteriscos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpar;
    }
}