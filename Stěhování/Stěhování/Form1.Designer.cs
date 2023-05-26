namespace Stěhování
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_nastehovat = new System.Windows.Forms.Button();
            this.btn_vystehovat = new System.Windows.Forms.Button();
            this.btn_vse = new System.Windows.Forms.Button();
            this.btn_zobrazit = new System.Windows.Forms.Button();
            this.txt_rodina = new System.Windows.Forms.TextBox();
            this.nmr_cislo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nájem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_zobrazrodinu = new System.Windows.Forms.Button();
            this.nmr_najem = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_cislo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_najem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nastehovat
            // 
            this.btn_nastehovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_nastehovat.Location = new System.Drawing.Point(578, 55);
            this.btn_nastehovat.Name = "btn_nastehovat";
            this.btn_nastehovat.Size = new System.Drawing.Size(137, 58);
            this.btn_nastehovat.TabIndex = 0;
            this.btn_nastehovat.Text = "Nastěhovat";
            this.btn_nastehovat.UseVisualStyleBackColor = true;
            this.btn_nastehovat.Click += new System.EventHandler(this.btn_nastehovat_Click);
            // 
            // btn_vystehovat
            // 
            this.btn_vystehovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vystehovat.Location = new System.Drawing.Point(578, 136);
            this.btn_vystehovat.Name = "btn_vystehovat";
            this.btn_vystehovat.Size = new System.Drawing.Size(137, 58);
            this.btn_vystehovat.TabIndex = 1;
            this.btn_vystehovat.Text = "Vystěhovat";
            this.btn_vystehovat.UseVisualStyleBackColor = true;
            this.btn_vystehovat.Click += new System.EventHandler(this.btn_vystehovat_Click);
            // 
            // btn_vse
            // 
            this.btn_vse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vse.Location = new System.Drawing.Point(578, 299);
            this.btn_vse.Name = "btn_vse";
            this.btn_vse.Size = new System.Drawing.Size(137, 58);
            this.btn_vse.TabIndex = 3;
            this.btn_vse.Text = "Zobrazit vše";
            this.btn_vse.UseVisualStyleBackColor = true;
            this.btn_vse.Click += new System.EventHandler(this.btn_vse_Click);
            // 
            // btn_zobrazit
            // 
            this.btn_zobrazit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zobrazit.Location = new System.Drawing.Point(578, 218);
            this.btn_zobrazit.Name = "btn_zobrazit";
            this.btn_zobrazit.Size = new System.Drawing.Size(137, 58);
            this.btn_zobrazit.TabIndex = 2;
            this.btn_zobrazit.Text = "Zobrazit";
            this.btn_zobrazit.UseVisualStyleBackColor = true;
            this.btn_zobrazit.Click += new System.EventHandler(this.btn_zobrazit_Click);
            // 
            // txt_rodina
            // 
            this.txt_rodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txt_rodina.Location = new System.Drawing.Point(175, 152);
            this.txt_rodina.Name = "txt_rodina";
            this.txt_rodina.Size = new System.Drawing.Size(244, 26);
            this.txt_rodina.TabIndex = 4;
            // 
            // nmr_cislo
            // 
            this.nmr_cislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nmr_cislo.Location = new System.Drawing.Point(175, 217);
            this.nmr_cislo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmr_cislo.Name = "nmr_cislo";
            this.nmr_cislo.Size = new System.Drawing.Size(244, 26);
            this.nmr_cislo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(108, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rodina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(89, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Číslo bytu";
            // 
            // btn_nájem
            // 
            this.btn_nájem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_nájem.Location = new System.Drawing.Point(112, 348);
            this.btn_nájem.Name = "btn_nájem";
            this.btn_nájem.Size = new System.Drawing.Size(137, 58);
            this.btn_nájem.TabIndex = 8;
            this.btn_nájem.Text = "Změn nájem";
            this.btn_nájem.UseVisualStyleBackColor = true;
            this.btn_nájem.Click += new System.EventHandler(this.btn_nájem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(108, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nájem";
            // 
            // btn_zobrazrodinu
            // 
            this.btn_zobrazrodinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zobrazrodinu.Location = new System.Drawing.Point(317, 348);
            this.btn_zobrazrodinu.Name = "btn_zobrazrodinu";
            this.btn_zobrazrodinu.Size = new System.Drawing.Size(137, 58);
            this.btn_zobrazrodinu.TabIndex = 11;
            this.btn_zobrazrodinu.Text = "Zobraz rodinu a nájem";
            this.btn_zobrazrodinu.UseVisualStyleBackColor = true;
            this.btn_zobrazrodinu.Click += new System.EventHandler(this.btn_zobrazrodinu_Click);
            // 
            // nmr_najem
            // 
            this.nmr_najem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nmr_najem.Location = new System.Drawing.Point(175, 281);
            this.nmr_najem.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.nmr_najem.Name = "nmr_najem";
            this.nmr_najem.Size = new System.Drawing.Size(244, 26);
            this.nmr_najem.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nmr_najem);
            this.Controls.Add(this.btn_zobrazrodinu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_nájem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmr_cislo);
            this.Controls.Add(this.txt_rodina);
            this.Controls.Add(this.btn_vse);
            this.Controls.Add(this.btn_zobrazit);
            this.Controls.Add(this.btn_vystehovat);
            this.Controls.Add(this.btn_nastehovat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_cislo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_najem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nastehovat;
        private System.Windows.Forms.Button btn_vystehovat;
        private System.Windows.Forms.Button btn_vse;
        private System.Windows.Forms.Button btn_zobrazit;
        private System.Windows.Forms.TextBox txt_rodina;
        private System.Windows.Forms.NumericUpDown nmr_cislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_nájem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_zobrazrodinu;
        private System.Windows.Forms.NumericUpDown nmr_najem;
    }
}

