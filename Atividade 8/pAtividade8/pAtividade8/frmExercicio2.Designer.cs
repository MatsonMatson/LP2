namespace pAtividade8
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
            this.btnGerarH = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerarH
            // 
            this.btnGerarH.Location = new System.Drawing.Point(434, 232);
            this.btnGerarH.Name = "btnGerarH";
            this.btnGerarH.Size = new System.Drawing.Size(141, 44);
            this.btnGerarH.TabIndex = 0;
            this.btnGerarH.Text = "Gerar H";
            this.btnGerarH.UseVisualStyleBackColor = true;
            this.btnGerarH.Click += new System.EventHandler(this.btnGerarH_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(434, 186);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(141, 22);
            this.txtNum.TabIndex = 1;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 552);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnGerarH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarH;
        private System.Windows.Forms.TextBox txtNum;
    }
}