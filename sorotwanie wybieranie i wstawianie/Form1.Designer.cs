namespace sorotwanie_wybieranie_i_wstawianie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generowanie = new System.Windows.Forms.Button();
            this.SortWyb = new System.Windows.Forms.Button();
            this.SortWs = new System.Windows.Forms.Button();
            this.sortzlcz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // generowanie
            // 
            this.generowanie.Location = new System.Drawing.Point(337, 33);
            this.generowanie.Name = "generowanie";
            this.generowanie.Size = new System.Drawing.Size(75, 23);
            this.generowanie.TabIndex = 2;
            this.generowanie.Text = "generuj";
            this.generowanie.UseVisualStyleBackColor = true;
            this.generowanie.Click += new System.EventHandler(this.generowanie_Click);
            // 
            // SortWyb
            // 
            this.SortWyb.Location = new System.Drawing.Point(157, 194);
            this.SortWyb.Name = "SortWyb";
            this.SortWyb.Size = new System.Drawing.Size(158, 23);
            this.SortWyb.TabIndex = 3;
            this.SortWyb.Text = "Sortowanie przez wybieranie";
            this.SortWyb.UseVisualStyleBackColor = true;
            this.SortWyb.Click += new System.EventHandler(this.SortWyb_Click);
            // 
            // SortWs
            // 
            this.SortWs.Location = new System.Drawing.Point(398, 194);
            this.SortWs.Name = "SortWs";
            this.SortWs.Size = new System.Drawing.Size(181, 23);
            this.SortWs.TabIndex = 4;
            this.SortWs.Text = "sortowanie przez wstawianie";
            this.SortWs.UseVisualStyleBackColor = true;
            this.SortWs.Click += new System.EventHandler(this.SortWs_Click);
            // 
            // sortzlcz
            // 
            this.sortzlcz.Location = new System.Drawing.Point(272, 292);
            this.sortzlcz.Name = "sortzlcz";
            this.sortzlcz.Size = new System.Drawing.Size(171, 23);
            this.sortzlcz.TabIndex = 5;
            this.sortzlcz.Text = "Sortowanie przez zliczanie";
            this.sortzlcz.UseVisualStyleBackColor = true;
            this.sortzlcz.Click += new System.EventHandler(this.sortzlcz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortzlcz);
            this.Controls.Add(this.SortWs);
            this.Controls.Add(this.SortWyb);
            this.Controls.Add(this.generowanie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generowanie;
        private System.Windows.Forms.Button SortWyb;
        private System.Windows.Forms.Button SortWs;
        private System.Windows.Forms.Button sortzlcz;
    }
}

