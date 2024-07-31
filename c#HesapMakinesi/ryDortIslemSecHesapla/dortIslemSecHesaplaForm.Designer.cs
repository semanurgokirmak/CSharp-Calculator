namespace ryDortIslemSecHesapla
{
    partial class dortIslemSecHesaplaForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbSayi1 = new System.Windows.Forms.TextBox();
            this.tbSayi2 = new System.Windows.Forms.TextBox();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "İşlem Türü :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSayi1
            // 
            this.tbSayi1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSayi1.Location = new System.Drawing.Point(119, 24);
            this.tbSayi1.Margin = new System.Windows.Forms.Padding(0);
            this.tbSayi1.MaxLength = 5;
            this.tbSayi1.Name = "tbSayi1";
            this.tbSayi1.Size = new System.Drawing.Size(121, 24);
            this.tbSayi1.TabIndex = 4;
            this.tbSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSayi2
            // 
            this.tbSayi2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSayi2.Location = new System.Drawing.Point(119, 60);
            this.tbSayi2.Margin = new System.Windows.Forms.Padding(0);
            this.tbSayi2.MaxLength = 5;
            this.tbSayi2.Name = "tbSayi2";
            this.tbSayi2.Size = new System.Drawing.Size(121, 24);
            this.tbSayi2.TabIndex = 5;
            this.tbSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbIslem
            // 
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "Toplama",
            "Çıkarma",
            "Çarpma",
            "Bölme"});
            this.cmbIslem.Location = new System.Drawing.Point(119, 104);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(121, 24);
            this.cmbIslem.TabIndex = 7;
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.Window;
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Location = new System.Drawing.Point(119, 149);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(156, 23);
            this.lblSonuc.TabIndex = 10;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::ryDortIslemSecHesapla.Properties.Resources.kapat;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(274, 24);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(48, 48);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackgroundImage = global::ryDortIslemSecHesapla.Properties.Resources.hesapMakinesi;
            this.btnHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapla.Location = new System.Drawing.Point(274, 91);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(48, 48);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // dortIslemSecHesaplaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 187);
            this.ControlBox = false;
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.tbSayi2);
            this.Controls.Add(this.tbSayi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dortIslemSecHesaplaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÖRT İŞLEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSayi1;
        private System.Windows.Forms.TextBox tbSayi2;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblSonuc;
    }
}

