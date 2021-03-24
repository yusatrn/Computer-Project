namespace Computer_Sales
{
    partial class Anasayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSatışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teknikServisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılanÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisteOlanÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bekleyen İşler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.ürünSatışıToolStripMenuItem,
            this.teknikServisToolStripMenuItem,
            this.müşteriKayıtToolStripMenuItem,
            this.personelKayıtToolStripMenuItem,
            this.satılanÜrünlerToolStripMenuItem,
            this.servisteOlanÜrünlerToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.yedekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // ürünSatışıToolStripMenuItem
            // 
            this.ürünSatışıToolStripMenuItem.Name = "ürünSatışıToolStripMenuItem";
            this.ürünSatışıToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ürünSatışıToolStripMenuItem.Text = "Ürün Satışı";
            this.ürünSatışıToolStripMenuItem.Click += new System.EventHandler(this.ürünSatışıToolStripMenuItem_Click);
            // 
            // teknikServisToolStripMenuItem
            // 
            this.teknikServisToolStripMenuItem.Name = "teknikServisToolStripMenuItem";
            this.teknikServisToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.teknikServisToolStripMenuItem.Text = "Teknik Servis";
            this.teknikServisToolStripMenuItem.Click += new System.EventHandler(this.teknikServisToolStripMenuItem_Click);
            // 
            // müşteriKayıtToolStripMenuItem
            // 
            this.müşteriKayıtToolStripMenuItem.Name = "müşteriKayıtToolStripMenuItem";
            this.müşteriKayıtToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.müşteriKayıtToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müşteriKayıtToolStripMenuItem.Click += new System.EventHandler(this.müşteriKayıtToolStripMenuItem_Click);
            // 
            // personelKayıtToolStripMenuItem
            // 
            this.personelKayıtToolStripMenuItem.Name = "personelKayıtToolStripMenuItem";
            this.personelKayıtToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelKayıtToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelKayıtToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtToolStripMenuItem_Click);
            // 
            // satılanÜrünlerToolStripMenuItem
            // 
            this.satılanÜrünlerToolStripMenuItem.Name = "satılanÜrünlerToolStripMenuItem";
            this.satılanÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.satılanÜrünlerToolStripMenuItem.Text = "Satılan Ürünler";
            this.satılanÜrünlerToolStripMenuItem.Click += new System.EventHandler(this.satılanÜrünlerToolStripMenuItem_Click);
            // 
            // servisteOlanÜrünlerToolStripMenuItem
            // 
            this.servisteOlanÜrünlerToolStripMenuItem.Name = "servisteOlanÜrünlerToolStripMenuItem";
            this.servisteOlanÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.servisteOlanÜrünlerToolStripMenuItem.Text = "Serviste Olan Ürünler";
            this.servisteOlanÜrünlerToolStripMenuItem.Click += new System.EventHandler(this.servisteOlanÜrünlerToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // yedekToolStripMenuItem
            // 
            this.yedekToolStripMenuItem.Name = "yedekToolStripMenuItem";
            this.yedekToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.yedekToolStripMenuItem.Text = "Yedek";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 550);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSatışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teknikServisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılanÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisteOlanÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedekToolStripMenuItem;
    }
}

