namespace pTesteMetodos
{
    partial class frmExercicio3
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
            this.BtnRemove1 = new System.Windows.Forms.Button();
            this.BtnRemove2 = new System.Windows.Forms.Button();
            this.BtnInverte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRemove1
            // 
            this.BtnRemove1.Location = new System.Drawing.Point(68, 259);
            this.BtnRemove1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnRemove1.Name = "BtnRemove1";
            this.BtnRemove1.Size = new System.Drawing.Size(224, 95);
            this.BtnRemove1.TabIndex = 0;
            this.BtnRemove1.Text = "Remove Ocorrências ";
            this.BtnRemove1.UseVisualStyleBackColor = true;
            this.BtnRemove1.Click += new System.EventHandler(this.BtnRemove1_Click);
            // 
            // BtnRemove2
            // 
            this.BtnRemove2.Location = new System.Drawing.Point(375, 259);
            this.BtnRemove2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnRemove2.Name = "BtnRemove2";
            this.BtnRemove2.Size = new System.Drawing.Size(206, 95);
            this.BtnRemove2.TabIndex = 1;
            this.BtnRemove2.Text = "Remove Ocorrências (replace)";
            this.BtnRemove2.UseVisualStyleBackColor = true;
            this.BtnRemove2.Click += new System.EventHandler(this.BtnRemove2_Click);
            // 
            // BtnInverte
            // 
            this.BtnInverte.Location = new System.Drawing.Point(649, 259);
            this.BtnInverte.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnInverte.Name = "BtnInverte";
            this.BtnInverte.Size = new System.Drawing.Size(218, 95);
            this.BtnInverte.TabIndex = 2;
            this.BtnInverte.Text = "Inverte (reverse)";
            this.BtnInverte.UseVisualStyleBackColor = true;
            this.BtnInverte.Click += new System.EventHandler(this.BtnInverte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(228, 53);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(291, 29);
            this.txtPalavra1.TabIndex = 5;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(228, 143);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(291, 29);
            this.txtPalavra2.TabIndex = 6;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(628, 66);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(215, 106);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar as Palavras";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 489);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnInverte);
            this.Controls.Add(this.BtnRemove2);
            this.Controls.Add(this.BtnRemove1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRemove1;
        private System.Windows.Forms.Button BtnRemove2;
        private System.Windows.Forms.Button BtnInverte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button BtnLimpar;
    }
}