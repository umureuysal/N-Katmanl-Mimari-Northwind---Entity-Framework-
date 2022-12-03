namespace NKatmanlıMimari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxUrunAra = new System.Windows.Forms.TextBox();
            this.cbxKategoriSırala = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBirim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStok = new System.Windows.Forms.TextBox();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUrun = new System.Windows.Forms.TextBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbxUrunAra
            // 
            this.tbxUrunAra.Location = new System.Drawing.Point(711, 21);
            this.tbxUrunAra.Name = "tbxUrunAra";
            this.tbxUrunAra.Size = new System.Drawing.Size(186, 22);
            this.tbxUrunAra.TabIndex = 1;
            this.tbxUrunAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxKategoriSırala
            // 
            this.cbxKategoriSırala.FormattingEnabled = true;
            this.cbxKategoriSırala.Location = new System.Drawing.Point(229, 21);
            this.cbxKategoriSırala.Name = "cbxKategoriSırala";
            this.cbxKategoriSırala.Size = new System.Drawing.Size(186, 24);
            this.cbxKategoriSırala.TabIndex = 2;
            this.cbxKategoriSırala.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 47);
            this.button3.TabIndex = 29;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Birim Adedi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stok Adedi:";
            // 
            // tbxBirim
            // 
            this.tbxBirim.Location = new System.Drawing.Point(142, 381);
            this.tbxBirim.Name = "tbxBirim";
            this.tbxBirim.Size = new System.Drawing.Size(201, 22);
            this.tbxBirim.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(75, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fiyat:";
            // 
            // tbxStok
            // 
            this.tbxStok.Location = new System.Drawing.Point(142, 343);
            this.tbxStok.Name = "tbxStok";
            this.tbxStok.Size = new System.Drawing.Size(201, 22);
            this.tbxStok.TabIndex = 22;
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(142, 305);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(201, 22);
            this.tbxFiyat.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ürün Adı:";
            // 
            // tbxUrun
            // 
            this.tbxUrun.Location = new System.Drawing.Point(140, 223);
            this.tbxUrun.Name = "tbxUrun";
            this.tbxUrun.Size = new System.Drawing.Size(201, 22);
            this.tbxUrun.TabIndex = 19;
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(140, 261);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(203, 24);
            this.cbxKategori.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kategori Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kategoriye Göre Sırala:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(507, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ürün Adına Göre Ara:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 498);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxBirim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxStok);
            this.Controls.Add(this.tbxFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUrun);
            this.Controls.Add(this.cbxKategoriSırala);
            this.Controls.Add(this.tbxUrunAra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxUrunAra;
        private System.Windows.Forms.ComboBox cbxKategoriSırala;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBirim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxStok;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUrun;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

