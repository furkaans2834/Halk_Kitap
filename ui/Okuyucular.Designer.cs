namespace Halk_Kitap.ui
{
    partial class Okuyucular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okuyucular));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bntOkuyucuEkle = new System.Windows.Forms.ToolStripButton();
            this.btnOkuyucuDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnOkuyucuSil = new System.Windows.Forms.ToolStripButton();
            this.btnOkuyucuBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 458);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCansel);
            this.tabPage1.Controls.Add(this.btnOK);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OKUYUCULAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntOkuyucuEkle,
            this.btnOkuyucuDüzenle,
            this.btnOkuyucuSil,
            this.btnOkuyucuBul,
            this.toolStripTextBox1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bntOkuyucuEkle
            // 
            this.bntOkuyucuEkle.Image = global::Halk_Kitap.Properties.Resources.add_group;
            this.bntOkuyucuEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntOkuyucuEkle.Name = "bntOkuyucuEkle";
            this.bntOkuyucuEkle.Size = new System.Drawing.Size(120, 28);
            this.bntOkuyucuEkle.Text = "Okuyucu Ekle";
            this.bntOkuyucuEkle.Click += new System.EventHandler(this.bntOkuyucuEkle_Click);
            // 
            // btnOkuyucuDüzenle
            // 
            this.btnOkuyucuDüzenle.Image = global::Halk_Kitap.Properties.Resources.edit;
            this.btnOkuyucuDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOkuyucuDüzenle.Name = "btnOkuyucuDüzenle";
            this.btnOkuyucuDüzenle.Size = new System.Drawing.Size(147, 28);
            this.btnOkuyucuDüzenle.Text = "Okuyucu Düzenle";
            this.btnOkuyucuDüzenle.Click += new System.EventHandler(this.btnOkuyucuDüzenle_Click);
            // 
            // btnOkuyucuSil
            // 
            this.btnOkuyucuSil.Image = global::Halk_Kitap.Properties.Resources.rubbish;
            this.btnOkuyucuSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOkuyucuSil.Name = "btnOkuyucuSil";
            this.btnOkuyucuSil.Size = new System.Drawing.Size(109, 28);
            this.btnOkuyucuSil.Text = "Okuyucu Sil";
            this.btnOkuyucuSil.Click += new System.EventHandler(this.btnOkuyucuSil_Click);
            // 
            // btnOkuyucuBul
            // 
            this.btnOkuyucuBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOkuyucuBul.Image = global::Halk_Kitap.Properties.Resources.search;
            this.btnOkuyucuBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOkuyucuBul.Name = "btnOkuyucuBul";
            this.btnOkuyucuBul.Size = new System.Drawing.Size(54, 28);
            this.btnOkuyucuBul.Text = "Bul";
            this.btnOkuyucuBul.Click += new System.EventHandler(this.btnOkuyucuBul_Click_1);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 28);
            this.toolStripButton4.Text = "Ara";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 37);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(788, 350);
            this.dataGridView2.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(614, 393);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "TAMAM";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCansel.Location = new System.Drawing.Point(704, 393);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(84, 28);
            this.btnCansel.TabIndex = 8;
            this.btnCansel.Text = "İPTAL";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // Okuyucular
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCansel;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "Okuyucular";
            this.Text = "Okuyucular";
            this.Load += new System.EventHandler(this.Okuyucular_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bntOkuyucuEkle;
        private System.Windows.Forms.ToolStripButton btnOkuyucuDüzenle;
        private System.Windows.Forms.ToolStripButton btnOkuyucuSil;
        private System.Windows.Forms.ToolStripButton btnOkuyucuBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnOK;
    }
}