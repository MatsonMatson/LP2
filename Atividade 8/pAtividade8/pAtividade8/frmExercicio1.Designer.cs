namespace pAtividade8
{
    partial class frmExercicio1
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
            this.BtnEspacBranco = new System.Windows.Forms.Button();
            this.BtnLetraR = new System.Windows.Forms.Button();
            this.BtnLetraPar = new System.Windows.Forms.Button();
            this.txtEspacBranco = new System.Windows.Forms.TextBox();
            this.txtLetraR = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnEspacBranco
            // 
            this.BtnEspacBranco.Location = new System.Drawing.Point(150, 178);
            this.BtnEspacBranco.Name = "BtnEspacBranco";
            this.BtnEspacBranco.Size = new System.Drawing.Size(176, 63);
            this.BtnEspacBranco.TabIndex = 0;
            this.BtnEspacBranco.Text = "Espaços em Brano";
            this.BtnEspacBranco.UseVisualStyleBackColor = true;
            this.BtnEspacBranco.Click += new System.EventHandler(this.BtnEspacBranco_Click);
            // 
            // BtnLetraR
            // 
            this.BtnLetraR.Location = new System.Drawing.Point(150, 261);
            this.BtnLetraR.Name = "BtnLetraR";
            this.BtnLetraR.Size = new System.Drawing.Size(176, 63);
            this.BtnLetraR.TabIndex = 1;
            this.BtnLetraR.Text = "Ocorrências da letra \\\"R\\\" ou \\\"r\"\\";
            this.BtnLetraR.UseVisualStyleBackColor = true;
            // 
            // BtnLetraPar
            // 
            this.BtnLetraPar.Location = new System.Drawing.Point(150, 346);
            this.BtnLetraPar.Name = "BtnLetraPar";
            this.BtnLetraPar.Size = new System.Drawing.Size(176, 63);
            this.BtnLetraPar.TabIndex = 2;
            this.BtnLetraPar.Text = "Ocorrências de um mesmo par de letras";
            this.BtnLetraPar.UseVisualStyleBackColor = true;
            // 
            // txtEspacBranco
            // 
            this.txtEspacBranco.Location = new System.Drawing.Point(369, 207);
            this.txtEspacBranco.Name = "txtEspacBranco";
            this.txtEspacBranco.Size = new System.Drawing.Size(168, 22);
            this.txtEspacBranco.TabIndex = 3;
            // 
            // txtLetraR
            // 
            this.txtLetraR.Location = new System.Drawing.Point(369, 290);
            this.txtLetraR.Name = "txtLetraR";
            this.txtLetraR.Size = new System.Drawing.Size(168, 22);
            this.txtLetraR.TabIndex = 4;
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(369, 366);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(168, 22);
            this.txtPares.TabIndex = 5;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(573, 207);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(306, 181);
            this.txtTexto.TabIndex = 6;
            this.txtTexto.Text = "";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 551);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.txtLetraR);
            this.Controls.Add(this.txtEspacBranco);
            this.Controls.Add(this.BtnLetraPar);
            this.Controls.Add(this.BtnLetraR);
            this.Controls.Add(this.BtnEspacBranco);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEspacBranco;
        private System.Windows.Forms.Button BtnLetraR;
        private System.Windows.Forms.Button BtnLetraPar;
        private System.Windows.Forms.TextBox txtEspacBranco;
        private System.Windows.Forms.TextBox txtLetraR;
        private System.Windows.Forms.TextBox txtPares;
        private System.Windows.Forms.RichTextBox txtTexto;
    }
}