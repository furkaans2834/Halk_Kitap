﻿
namespace Halk_Kitap.ui
{
    partial class FrmOkuyucu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(239, 22);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADI:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(105, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(239, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYADI:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(105, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(239, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TELEFON:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "GMAİL:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(103, 178);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(239, 22);
            this.txtMail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ADRES:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(105, 216);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(239, 105);
            this.txtAdres.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(105, 140);
            this.txtTel.Mask = "\\0(599) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(239, 22);
            this.txtTel.TabIndex = 3;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(103, 358);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(122, 41);
            this.btnTamam.TabIndex = 6;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(231, 358);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(113, 41);
            this.btnİptal.TabIndex = 7;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmOkuyucu
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOkuyucu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOkuyucu";
            this.Load += new System.EventHandler(this.FrmOkuyucu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}