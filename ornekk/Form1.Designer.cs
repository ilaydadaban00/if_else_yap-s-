namespace ornekk
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
            this.btnTıkla = new System.Windows.Forms.Button();
            this.btnRenkdegistir = new System.Windows.Forms.Label();
            this.lblYaz = new System.Windows.Forms.Label();
            this.cbSari = new System.Windows.Forms.CheckBox();
            this.cbMavi = new System.Windows.Forms.CheckBox();
            this.lblYazz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTıkla
            // 
            this.btnTıkla.Location = new System.Drawing.Point(59, 69);
            this.btnTıkla.Name = "btnTıkla";
            this.btnTıkla.Size = new System.Drawing.Size(75, 23);
            this.btnTıkla.TabIndex = 0;
            this.btnTıkla.Text = "tıkla";
            this.btnTıkla.UseVisualStyleBackColor = true;
            this.btnTıkla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRenkdegistir
            // 
            this.btnRenkdegistir.AutoSize = true;
            this.btnRenkdegistir.Location = new System.Drawing.Point(202, 69);
            this.btnRenkdegistir.Name = "btnRenkdegistir";
            this.btnRenkdegistir.Size = new System.Drawing.Size(0, 13);
            this.btnRenkdegistir.TabIndex = 1;
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaz.Location = new System.Drawing.Point(220, 136);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(67, 25);
            this.lblYaz.TabIndex = 2;
            this.lblYaz.Text = "_____";
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Location = new System.Drawing.Point(73, 132);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(42, 17);
            this.cbSari.TabIndex = 3;
            this.cbSari.Text = "sarı";
            this.cbSari.UseVisualStyleBackColor = true;
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Location = new System.Drawing.Point(73, 190);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(48, 17);
            this.cbMavi.TabIndex = 4;
            this.cbMavi.Text = "mavi";
            this.cbMavi.UseVisualStyleBackColor = true;
            // 
            // lblYazz
            // 
            this.lblYazz.AutoSize = true;
            this.lblYazz.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazz.Location = new System.Drawing.Point(66, 280);
            this.lblYazz.Name = "lblYazz";
            this.lblYazz.Size = new System.Drawing.Size(217, 76);
            this.lblYazz.TabIndex = 5;
            this.lblYazz.Text = "_____";
            this.lblYazz.Click += new System.EventHandler(this.lblYazz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblYazz);
            this.Controls.Add(this.cbMavi);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.btnRenkdegistir);
            this.Controls.Add(this.btnTıkla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTıkla;
        private System.Windows.Forms.Label btnRenkdegistir;
        private System.Windows.Forms.Label lblYaz;
        private System.Windows.Forms.CheckBox cbSari;
        private System.Windows.Forms.CheckBox cbMavi;
        private System.Windows.Forms.Label lblYazz;
    }
}

