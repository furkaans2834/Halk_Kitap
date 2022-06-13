
namespace Halk_Kitap.ui
{
    partial class FrmKitapSatis
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
            this.components = new System.ComponentModel.Container();
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtKitap = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOkuyucu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOkuyucuSeç = new System.Windows.Forms.Button();
            this.btnKitapSeç = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmFiyat
            // 
            this.nmFiyat.Location = new System.Drawing.Point(118, 157);
            this.nmFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(257, 22);
            this.nmFiyat.TabIndex = 3;
            // 
            // txtKitap
            // 
            this.txtKitap.FormattingEnabled = true;
            this.txtKitap.Items.AddRange(new object[] {
            "Bilim Kurgu",
            "Roman",
            "Polisiye",
            "Çizgi Roman",
            "Tarih",
            "Edebiyat",
            "Siyaset Bilimi"});
            this.txtKitap.Location = new System.Drawing.Point(118, 117);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(257, 24);
            this.txtKitap.TabIndex = 2;
            this.txtKitap.TabStop = false;
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(262, 269);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(113, 41);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(118, 269);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(122, 41);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "SATIŞ TARİHİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "FİYAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "KİTAP:";
            // 
            // txtOkuyucu
            // 
            this.txtOkuyucu.Location = new System.Drawing.Point(118, 84);
            this.txtOkuyucu.Name = "txtOkuyucu";
            this.txtOkuyucu.Size = new System.Drawing.Size(257, 22);
            this.txtOkuyucu.TabIndex = 1;
            this.txtOkuyucu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "OKUYUCU:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 45);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(257, 22);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(117, 203);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(258, 22);
            this.dtTarih.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnOkuyucuSeç
            // 
            this.btnOkuyucuSeç.Location = new System.Drawing.Point(427, 69);
            this.btnOkuyucuSeç.Name = "btnOkuyucuSeç";
            this.btnOkuyucuSeç.Size = new System.Drawing.Size(119, 46);
            this.btnOkuyucuSeç.TabIndex = 30;
            this.btnOkuyucuSeç.Text = "Okuyucu Seç";
            this.btnOkuyucuSeç.UseVisualStyleBackColor = true;
            this.btnOkuyucuSeç.Click += new System.EventHandler(this.btnOkuyucuSeç_Click);
            // 
            // btnKitapSeç
            // 
            this.btnKitapSeç.Location = new System.Drawing.Point(427, 133);
            this.btnKitapSeç.Name = "btnKitapSeç";
            this.btnKitapSeç.Size = new System.Drawing.Size(119, 46);
            this.btnKitapSeç.TabIndex = 31;
            this.btnKitapSeç.Text = "Kitap Seç";
            this.btnKitapSeç.UseVisualStyleBackColor = true;
            this.btnKitapSeç.Click += new System.EventHandler(this.btnKitapSeç_Click);
            // 
            // FrmKitapSatis
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(578, 354);
            this.Controls.Add(this.btnKitapSeç);
            this.Controls.Add(this.btnOkuyucuSeç);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOkuyucu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKitapSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmKitapSatis";
            this.Load += new System.EventHandler(this.FrmKitapSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.ComboBox txtKitap;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOkuyucu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnKitapSeç;
        private System.Windows.Forms.Button btnOkuyucuSeç;
    }
}