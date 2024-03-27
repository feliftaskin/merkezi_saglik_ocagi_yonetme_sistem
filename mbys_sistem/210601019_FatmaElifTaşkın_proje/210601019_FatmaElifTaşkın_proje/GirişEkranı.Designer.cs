
namespace _210601019_FatmaElifTaşkın_proje
{
    partial class GirişEkranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisSifre_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.YetkiliGirisi_button = new System.Windows.Forms.Button();
            this.GirisAd_textBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(137, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // GirisSifre_textBox
            // 
            this.GirisSifre_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.GirisSifre_textBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisSifre_textBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.GirisSifre_textBox.Location = new System.Drawing.Point(143, 321);
            this.GirisSifre_textBox.Multiline = true;
            this.GirisSifre_textBox.Name = "GirisSifre_textBox";
            this.GirisSifre_textBox.ShortcutsEnabled = false;
            this.GirisSifre_textBox.Size = new System.Drawing.Size(214, 39);
            this.GirisSifre_textBox.TabIndex = 11;
            this.GirisSifre_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giris Yap!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 100);
            this.panel2.TabIndex = 13;
            // 
            // YetkiliGirisi_button
            // 
            this.YetkiliGirisi_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YetkiliGirisi_button.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YetkiliGirisi_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.YetkiliGirisi_button.Location = new System.Drawing.Point(173, 382);
            this.YetkiliGirisi_button.Name = "YetkiliGirisi_button";
            this.YetkiliGirisi_button.Size = new System.Drawing.Size(158, 56);
            this.YetkiliGirisi_button.TabIndex = 7;
            this.YetkiliGirisi_button.Text = "Yetkili Girisi";
            this.YetkiliGirisi_button.UseVisualStyleBackColor = false;
            this.YetkiliGirisi_button.Click += new System.EventHandler(this.YetkiliGirisi_button_Click);
            // 
            // GirisAd_textBox
            // 
            this.GirisAd_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.GirisAd_textBox.ForeColor = System.Drawing.Color.White;
            this.GirisAd_textBox.Location = new System.Drawing.Point(146, 236);
            this.GirisAd_textBox.Multiline = true;
            this.GirisAd_textBox.Name = "GirisAd_textBox";
            this.GirisAd_textBox.Size = new System.Drawing.Size(214, 37);
            this.GirisAd_textBox.TabIndex = 12;
            this.GirisAd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GirişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(512, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.YetkiliGirisi_button);
            this.Controls.Add(this.GirisAd_textBox);
            this.Controls.Add(this.GirisSifre_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirişEkranı";
            this.Text = "Giriş Ekranı";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GirisSifre_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button YetkiliGirisi_button;
        private System.Windows.Forms.TextBox GirisAd_textBox;
    }
}

