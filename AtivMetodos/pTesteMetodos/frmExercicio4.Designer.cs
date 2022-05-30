namespace pTesteMetodos
{
    partial class frmExercicio4
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
            this.BtnNum = new System.Windows.Forms.Button();
            this.BtnCaracBranco = new System.Windows.Forms.Button();
            this.BtnCaracAlfab = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.rtxtbCaracter = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCaracBranco = new System.Windows.Forms.TextBox();
            this.txtAlfab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnNum
            // 
            this.BtnNum.Location = new System.Drawing.Point(60, 86);
            this.BtnNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNum.Name = "BtnNum";
            this.BtnNum.Size = new System.Drawing.Size(144, 73);
            this.BtnNum.TabIndex = 0;
            this.BtnNum.Text = "Quantos Caracteres Numérico";
            this.BtnNum.UseVisualStyleBackColor = true;
            this.BtnNum.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnCaracBranco
            // 
            this.BtnCaracBranco.Location = new System.Drawing.Point(60, 167);
            this.BtnCaracBranco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCaracBranco.Name = "BtnCaracBranco";
            this.BtnCaracBranco.Size = new System.Drawing.Size(144, 73);
            this.BtnCaracBranco.TabIndex = 1;
            this.BtnCaracBranco.Text = "Primeiro Caracter Branco";
            this.BtnCaracBranco.UseVisualStyleBackColor = true;
            // 
            // BtnCaracAlfab
            // 
            this.BtnCaracAlfab.Location = new System.Drawing.Point(60, 248);
            this.BtnCaracAlfab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCaracAlfab.Name = "BtnCaracAlfab";
            this.BtnCaracAlfab.Size = new System.Drawing.Size(144, 73);
            this.BtnCaracAlfab.TabIndex = 2;
            this.BtnCaracAlfab.Text = "Quantos Caracteres Alfabético ";
            this.BtnCaracAlfab.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(60, 329);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(144, 73);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // rtxtbCaracter
            // 
            this.rtxtbCaracter.Location = new System.Drawing.Point(348, 95);
            this.rtxtbCaracter.Name = "rtxtbCaracter";
            this.rtxtbCaracter.Size = new System.Drawing.Size(466, 253);
            this.rtxtbCaracter.TabIndex = 4;
            this.rtxtbCaracter.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gustavo Rocha";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(211, 111);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(131, 22);
            this.txtNum.TabIndex = 6;
            // 
            // txtCaracBranco
            // 
            this.txtCaracBranco.Location = new System.Drawing.Point(211, 192);
            this.txtCaracBranco.Name = "txtCaracBranco";
            this.txtCaracBranco.Size = new System.Drawing.Size(131, 22);
            this.txtCaracBranco.TabIndex = 7;
            // 
            // txtAlfab
            // 
            this.txtAlfab.Location = new System.Drawing.Point(211, 273);
            this.txtAlfab.Name = "txtAlfab";
            this.txtAlfab.Size = new System.Drawing.Size(131, 22);
            this.txtAlfab.TabIndex = 8;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 612);
            this.Controls.Add(this.txtAlfab);
            this.Controls.Add(this.txtCaracBranco);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtbCaracter);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCaracAlfab);
            this.Controls.Add(this.BtnCaracBranco);
            this.Controls.Add(this.BtnNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNum;
        private System.Windows.Forms.Button BtnCaracBranco;
        private System.Windows.Forms.Button BtnCaracAlfab;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.RichTextBox rtxtbCaracter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCaracBranco;
        private System.Windows.Forms.TextBox txtAlfab;
    }
}