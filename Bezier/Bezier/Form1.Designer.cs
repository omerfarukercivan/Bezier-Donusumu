
namespace Bezier
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKontrolIzo = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 292);
            this.listBox1.TabIndex = 0;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(12, 327);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(230, 50);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Noktaları";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(250, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 292);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(536, 29);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(399, 548);
            this.listBox3.TabIndex = 5;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(941, 29);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(229, 548);
            this.listBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kontrol Noktaları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kontrol Noktaları İZOMETRİK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bezier Y. N. Bulutu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(938, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bezier Y. N. Bulutu İzometrik";
            // 
            // btnKontrolIzo
            // 
            this.btnKontrolIzo.Location = new System.Drawing.Point(250, 327);
            this.btnKontrolIzo.Name = "btnKontrolIzo";
            this.btnKontrolIzo.Size = new System.Drawing.Size(230, 50);
            this.btnKontrolIzo.TabIndex = 11;
            this.btnKontrolIzo.Text = "Kontrol Noktaları İZOMETRİK";
            this.btnKontrolIzo.UseVisualStyleBackColor = true;
            this.btnKontrolIzo.Click += new System.EventHandler(this.btnKontrolIzo_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.Location = new System.Drawing.Point(536, 591);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(634, 50);
            this.btnBezier.TabIndex = 12;
            this.btnBezier.Text = "Bezier Yüzey Nokta Bulutu  //  İZOMETRİK";
            this.btnBezier.UseVisualStyleBackColor = true;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnBezier);
            this.Controls.Add(this.btnKontrolIzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bezier Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKontrolIzo;
        private System.Windows.Forms.Button btnBezier;
    }
}

