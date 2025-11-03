namespace zad1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lblczas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn.Location = new System.Drawing.Point(154, 360);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(117, 56);
            this.btn.TabIndex = 0;
            this.btn.Text = "Start";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            this.btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(13, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "0";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lblczas
            // 
            this.lblczas.AutoSize = true;
            this.lblczas.Location = new System.Drawing.Point(65, 10);
            this.lblczas.Name = "lblczas";
            this.lblczas.Size = new System.Drawing.Size(13, 15);
            this.lblczas.TabIndex = 2;
            this.lblczas.Text = "0";
            this.lblczas.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 475);
            this.Controls.Add(this.lblczas);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn;
        private Label lbl;
        private System.Windows.Forms.Timer timer4;
        private Label lblczas;
    }
}