namespace _8_Linq
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgwResult = new System.Windows.Forms.DataGridView();
            this.btnTumu = new System.Windows.Forms.Button();
            this.btnBay = new System.Windows.Forms.Button();
            this.btnBayan = new System.Windows.Forms.Button();
            this.btnGecen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGecenBayan = new System.Windows.Forms.Button();
            this.btnGecenBayAnonim = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgwResult
            // 
            this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwResult.Location = new System.Drawing.Point(0, 251);
            this.dgwResult.Name = "dgwResult";
            this.dgwResult.RowTemplate.Height = 25;
            this.dgwResult.Size = new System.Drawing.Size(769, 217);
            this.dgwResult.TabIndex = 2;
            // 
            // btnTumu
            // 
            this.btnTumu.Location = new System.Drawing.Point(44, 49);
            this.btnTumu.Name = "btnTumu";
            this.btnTumu.Size = new System.Drawing.Size(132, 23);
            this.btnTumu.TabIndex = 3;
            this.btnTumu.Text = "Tümü";
            this.btnTumu.UseVisualStyleBackColor = true;
            this.btnTumu.Click += new System.EventHandler(this.btnTumu_Click);
            // 
            // btnBay
            // 
            this.btnBay.Location = new System.Drawing.Point(42, 78);
            this.btnBay.Name = "btnBay";
            this.btnBay.Size = new System.Drawing.Size(134, 23);
            this.btnBay.TabIndex = 4;
            this.btnBay.Text = "Baylar";
            this.btnBay.UseVisualStyleBackColor = true;
            this.btnBay.Click += new System.EventHandler(this.btnBay_Click);
            // 
            // btnBayan
            // 
            this.btnBayan.Location = new System.Drawing.Point(44, 106);
            this.btnBayan.Name = "btnBayan";
            this.btnBayan.Size = new System.Drawing.Size(132, 23);
            this.btnBayan.TabIndex = 5;
            this.btnBayan.Text = "Bayanlar";
            this.btnBayan.UseVisualStyleBackColor = true;
            this.btnBayan.Click += new System.EventHandler(this.btnBayan_Click);
            // 
            // btnGecen
            // 
            this.btnGecen.Location = new System.Drawing.Point(44, 135);
            this.btnGecen.Name = "btnGecen";
            this.btnGecen.Size = new System.Drawing.Size(129, 23);
            this.btnGecen.TabIndex = 6;
            this.btnGecen.Text = "Geçenler";
            this.btnGecen.UseVisualStyleBackColor = true;
            this.btnGecen.Click += new System.EventHandler(this.btnGecen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Select Deyimi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Select Deyimi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGecenBayan
            // 
            this.btnGecenBayan.Location = new System.Drawing.Point(44, 162);
            this.btnGecenBayan.Name = "btnGecenBayan";
            this.btnGecenBayan.Size = new System.Drawing.Size(129, 23);
            this.btnGecenBayan.TabIndex = 9;
            this.btnGecenBayan.Text = "Geçen Bayanlar";
            this.btnGecenBayan.UseVisualStyleBackColor = true;
            this.btnGecenBayan.Click += new System.EventHandler(this.btnGecenBayan_Click);
            // 
            // btnGecenBayAnonim
            // 
            this.btnGecenBayAnonim.Location = new System.Drawing.Point(45, 191);
            this.btnGecenBayAnonim.Name = "btnGecenBayAnonim";
            this.btnGecenBayAnonim.Size = new System.Drawing.Size(131, 33);
            this.btnGecenBayAnonim.TabIndex = 10;
            this.btnGecenBayAnonim.Text = "Geçen Baylar Anonim";
            this.btnGecenBayAnonim.UseVisualStyleBackColor = true;
            this.btnGecenBayAnonim.Click += new System.EventHandler(this.btnGecenBayAnonim_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Lambda ifadeleri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 29);
            this.button5.TabIndex = 12;
            this.button5.Text = "Baylar Extension metot ile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(447, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 42);
            this.button6.TabIndex = 13;
            this.button6.Text = "Geçen Baylar Anonim Extension";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(453, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Geçenler Extension";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 468);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGecenBayAnonim);
            this.Controls.Add(this.btnGecenBayan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGecen);
            this.Controls.Add(this.btnBayan);
            this.Controls.Add(this.btnBay);
            this.Controls.Add(this.btnTumu);
            this.Controls.Add(this.dgwResult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView dgwResult;
        private Button btnTumu;
        private Button btnBay;
        private Button btnBayan;
        private Button btnGecen;
        private Button button2;
        private Button button3;
        private Button btnGecenBayan;
        private Button btnGecenBayAnonim;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}