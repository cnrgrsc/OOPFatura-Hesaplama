namespace OOPSample
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtSonIndex = new System.Windows.Forms.TextBox();
            this.txtIlkIndex = new System.Windows.Forms.TextBox();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lstMiktar = new System.Windows.Forms.ListBox();
            this.lstFatura = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbHalk = new System.Windows.Forms.RadioButton();
            this.rdbMesken = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Son Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ilk Index:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(256, 66);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(153, 30);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtSonIndex
            // 
            this.txtSonIndex.Location = new System.Drawing.Point(256, 140);
            this.txtSonIndex.Name = "txtSonIndex";
            this.txtSonIndex.Size = new System.Drawing.Size(153, 30);
            this.txtSonIndex.TabIndex = 1;
            // 
            // txtIlkIndex
            // 
            this.txtIlkIndex.Location = new System.Drawing.Point(256, 212);
            this.txtIlkIndex.Name = "txtIlkIndex";
            this.txtIlkIndex.Size = new System.Drawing.Size(153, 30);
            this.txtIlkIndex.TabIndex = 1;
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.ItemHeight = 25;
            this.lstAdSoyad.Location = new System.Drawing.Point(47, 309);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(238, 354);
            this.lstAdSoyad.TabIndex = 2;
            // 
            // lstMiktar
            // 
            this.lstMiktar.FormattingEnabled = true;
            this.lstMiktar.ItemHeight = 25;
            this.lstMiktar.Location = new System.Drawing.Point(446, 309);
            this.lstMiktar.Name = "lstMiktar";
            this.lstMiktar.Size = new System.Drawing.Size(238, 354);
            this.lstMiktar.TabIndex = 2;
            // 
            // lstFatura
            // 
            this.lstFatura.FormattingEnabled = true;
            this.lstFatura.ItemHeight = 25;
            this.lstFatura.Location = new System.Drawing.Point(855, 309);
            this.lstFatura.Name = "lstFatura";
            this.lstFatura.Size = new System.Drawing.Size(238, 354);
            this.lstFatura.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMesken);
            this.groupBox1.Controls.Add(this.rdbHalk);
            this.groupBox1.Location = new System.Drawing.Point(657, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbHalk
            // 
            this.rdbHalk.AutoSize = true;
            this.rdbHalk.Location = new System.Drawing.Point(105, 42);
            this.rdbHalk.Name = "rdbHalk";
            this.rdbHalk.Size = new System.Drawing.Size(123, 29);
            this.rdbHalk.TabIndex = 0;
            this.rdbHalk.TabStop = true;
            this.rdbHalk.Text = "Halka Acık";
            this.rdbHalk.UseVisualStyleBackColor = true;
            // 
            // rdbMesken
            // 
            this.rdbMesken.AutoSize = true;
            this.rdbMesken.Location = new System.Drawing.Point(105, 106);
            this.rdbMesken.Name = "rdbMesken";
            this.rdbMesken.Size = new System.Drawing.Size(100, 29);
            this.rdbMesken.TabIndex = 0;
            this.rdbMesken.TabStop = true;
            this.rdbMesken.Text = "Mesken\r\n";
            this.rdbMesken.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(621, 27);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(157, 38);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 748);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstFatura);
            this.Controls.Add(this.lstMiktar);
            this.Controls.Add(this.lstAdSoyad);
            this.Controls.Add(this.txtIlkIndex);
            this.Controls.Add(this.txtSonIndex);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtSonIndex;
        private System.Windows.Forms.TextBox txtIlkIndex;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.ListBox lstMiktar;
        private System.Windows.Forms.ListBox lstFatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMesken;
        private System.Windows.Forms.RadioButton rdbHalk;
        private System.Windows.Forms.Button btnHesapla;
    }
}

