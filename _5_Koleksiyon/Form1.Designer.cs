namespace _5_Koleksiyon
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lboxIsımler = new System.Windows.Forms.ListBox();
            this.brnEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(63, 36);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 23);
            this.txtIsim.TabIndex = 0;
            // 
            // lboxIsımler
            // 
            this.lboxIsımler.FormattingEnabled = true;
            this.lboxIsımler.ItemHeight = 15;
            this.lboxIsımler.Location = new System.Drawing.Point(207, 168);
            this.lboxIsımler.Name = "lboxIsımler";
            this.lboxIsımler.Size = new System.Drawing.Size(120, 94);
            this.lboxIsımler.TabIndex = 1;
            // 
            // brnEkle
            // 
            this.brnEkle.Location = new System.Drawing.Point(64, 70);
            this.brnEkle.Name = "brnEkle";
            this.brnEkle.Size = new System.Drawing.Size(99, 23);
            this.brnEkle.TabIndex = 2;
            this.brnEkle.Text = "Ekle";
            this.brnEkle.UseVisualStyleBackColor = true;
            this.brnEkle.Click += new System.EventHandler(this.brnEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(63, 99);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(99, 23);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Koleksiyon Detaylı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.brnEkle);
            this.Controls.Add(this.lboxIsımler);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIsim;
        private ListBox lboxIsımler;
        private Button brnEkle;
        private Button btnGoster;
        private Button button1;
    }
}