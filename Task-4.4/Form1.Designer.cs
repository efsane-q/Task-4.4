namespace Task_4._4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpSual = new System.Windows.Forms.GroupBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.lblSual = new System.Windows.Forms.Label();
            this.btnNovbeti = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpSual.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜMUMİ BİLİK TESTİ";
            // 
            // grpSual
            // 
            this.grpSual.Controls.Add(this.progressBar1);
            this.grpSual.Controls.Add(this.btnNovbeti);
            this.grpSual.Controls.Add(this.lblSual);
            this.grpSual.Controls.Add(this.rbD);
            this.grpSual.Controls.Add(this.rbC);
            this.grpSual.Controls.Add(this.rbB);
            this.grpSual.Controls.Add(this.rbA);
            this.grpSual.Location = new System.Drawing.Point(18, 80);
            this.grpSual.Name = "grpSual";
            this.grpSual.Size = new System.Drawing.Size(560, 230);
            this.grpSual.TabIndex = 1;
            this.grpSual.TabStop = false;
            this.grpSual.Text = "Sual 1";
            this.grpSual.Enter += new System.EventHandler(this.grbSual_Enter);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(16, 100);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(71, 20);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "A) Bakı";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(16, 126);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(84, 20);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B) Gəncə";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(16, 152);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(71, 20);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "C) Şəki";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(16, 178);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(78, 20);
            this.rbD.TabIndex = 3;
            this.rbD.TabStop = true;
            this.rbD.Text = "D) Quba";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // lblSual
            // 
            this.lblSual.AutoSize = true;
            this.lblSual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSual.Location = new System.Drawing.Point(13, 44);
            this.lblSual.Name = "lblSual";
            this.lblSual.Size = new System.Drawing.Size(294, 22);
            this.lblSual.TabIndex = 4;
            this.lblSual.Text = "Azərbaycanın paytaxtı hansıdır?";
            // 
            // btnNovbeti
            // 
            this.btnNovbeti.Location = new System.Drawing.Point(369, 114);
            this.btnNovbeti.Name = "btnNovbeti";
            this.btnNovbeti.Size = new System.Drawing.Size(120, 40);
            this.btnNovbeti.TabIndex = 2;
            this.btnNovbeti.Text = "Növbəti -->";
            this.btnNovbeti.UseVisualStyleBackColor = true;
            this.btnNovbeti.Click += new System.EventHandler(this.btnNovbeti_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(454, 201);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.grpSual);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Proqrami";
            this.grpSual.ResumeLayout(false);
            this.grpSual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSual;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label lblSual;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnNovbeti;
    }
}

