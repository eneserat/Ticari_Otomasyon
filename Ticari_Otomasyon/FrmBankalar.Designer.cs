namespace Ticari_Otomasyon
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.txtBankaId = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaAdı = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaSube = new DevExpress.XtraEditors.TextEdit();
            this.mskTarıh = new System.Windows.Forms.MaskedTextBox();
            this.txtHesapNumarası = new DevExpress.XtraEditors.TextEdit();
            this.txtYetkılı = new DevExpress.XtraEditors.TextEdit();
            this.cmbBankaIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbBankaIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.txtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtFırmaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNumarası.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkılı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankaIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankaIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFırmaId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1031, 712);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.mskTelefon);
            this.groupControl2.Controls.Add(this.labelControl20);
            this.groupControl2.Controls.Add(this.txtFırmaId);
            this.groupControl2.Controls.Add(this.labelControl19);
            this.groupControl2.Controls.Add(this.labelControl18);
            this.groupControl2.Controls.Add(this.txtHesapTuru);
            this.groupControl2.Controls.Add(this.txtIban);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.cmbBankaIlce);
            this.groupControl2.Controls.Add(this.cmbBankaIl);
            this.groupControl2.Controls.Add(this.txtYetkılı);
            this.groupControl2.Controls.Add(this.txtHesapNumarası);
            this.groupControl2.Controls.Add(this.mskTarıh);
            this.groupControl2.Controls.Add(this.txtBankaSube);
            this.groupControl2.Controls.Add(this.txtBankaAdı);
            this.groupControl2.Controls.Add(this.txtBankaId);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.simpleButton6);
            this.groupControl2.Controls.Add(this.simpleButton7);
            this.groupControl2.Controls.Add(this.simpleButton8);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Location = new System.Drawing.Point(1039, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(351, 707);
            this.groupControl2.TabIndex = 22;
            this.groupControl2.Text = "BANKA HESAP BİLGİLERİ";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(19, 48);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(25, 22);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "ID:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(19, 88);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(85, 22);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Banka Adı:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(19, 137);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(17, 22);
            this.labelControl14.TabIndex = 2;
            this.labelControl14.Text = "İl:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(19, 185);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(34, 22);
            this.labelControl13.TabIndex = 3;
            this.labelControl13.Text = "İlçe:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(19, 233);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 22);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Şube:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(19, 278);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 22);
            this.labelControl11.TabIndex = 5;
            this.labelControl11.Text = "İban:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(19, 325);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(145, 22);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "Hesap Numarası : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(19, 370);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 22);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Yetkili:";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.ImageOptions.Image")));
            this.simpleButton8.Location = new System.Drawing.Point(207, 591);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(114, 39);
            this.simpleButton8.TabIndex = 8;
            this.simpleButton8.Text = "Kaydet";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(207, 650);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(114, 37);
            this.simpleButton7.TabIndex = 9;
            this.simpleButton7.Text = "Güncelle";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(19, 593);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(113, 39);
            this.simpleButton6.TabIndex = 10;
            this.simpleButton6.Text = "Sil";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(19, 650);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(113, 37);
            this.simpleButton5.TabIndex = 11;
            this.simpleButton5.Text = "Temizle";
            // 
            // txtBankaId
            // 
            this.txtBankaId.Location = new System.Drawing.Point(170, 50);
            this.txtBankaId.Name = "txtBankaId";
            this.txtBankaId.Size = new System.Drawing.Size(151, 22);
            this.txtBankaId.TabIndex = 12;
            // 
            // txtBankaAdı
            // 
            this.txtBankaAdı.Location = new System.Drawing.Point(170, 90);
            this.txtBankaAdı.Name = "txtBankaAdı";
            this.txtBankaAdı.Size = new System.Drawing.Size(151, 22);
            this.txtBankaAdı.TabIndex = 13;
            // 
            // txtBankaSube
            // 
            this.txtBankaSube.Location = new System.Drawing.Point(170, 235);
            this.txtBankaSube.Name = "txtBankaSube";
            this.txtBankaSube.Size = new System.Drawing.Size(151, 22);
            this.txtBankaSube.TabIndex = 16;
            // 
            // mskTarıh
            // 
            this.mskTarıh.Location = new System.Drawing.Point(170, 449);
            this.mskTarıh.Mask = "00/00/0000";
            this.mskTarıh.Name = "mskTarıh";
            this.mskTarıh.Size = new System.Drawing.Size(151, 23);
            this.mskTarıh.TabIndex = 17;
            this.mskTarıh.ValidatingType = typeof(System.DateTime);
            // 
            // txtHesapNumarası
            // 
            this.txtHesapNumarası.Location = new System.Drawing.Point(170, 327);
            this.txtHesapNumarası.Name = "txtHesapNumarası";
            this.txtHesapNumarası.Size = new System.Drawing.Size(151, 22);
            this.txtHesapNumarası.TabIndex = 18;
            // 
            // txtYetkılı
            // 
            this.txtYetkılı.Location = new System.Drawing.Point(170, 372);
            this.txtYetkılı.Name = "txtYetkılı";
            this.txtYetkılı.Size = new System.Drawing.Size(151, 22);
            this.txtYetkılı.TabIndex = 19;
            // 
            // cmbBankaIl
            // 
            this.cmbBankaIl.Location = new System.Drawing.Point(170, 139);
            this.cmbBankaIl.Name = "cmbBankaIl";
            this.cmbBankaIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBankaIl.Size = new System.Drawing.Size(151, 22);
            this.cmbBankaIl.TabIndex = 20;
            // 
            // cmbBankaIlce
            // 
            this.cmbBankaIlce.Location = new System.Drawing.Point(170, 187);
            this.cmbBankaIlce.Name = "cmbBankaIlce";
            this.cmbBankaIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBankaIlce.Size = new System.Drawing.Size(151, 22);
            this.cmbBankaIlce.TabIndex = 21;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(19, 450);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(52, 22);
            this.labelControl17.TabIndex = 22;
            this.labelControl17.Text = "Tarih :";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(170, 278);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(151, 22);
            this.txtIban.TabIndex = 23;
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(170, 498);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.Size = new System.Drawing.Size(151, 22);
            this.txtHesapTuru.TabIndex = 24;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(19, 501);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(97, 22);
            this.labelControl18.TabIndex = 25;
            this.labelControl18.Text = "Hesap Türü:";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(19, 555);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(74, 22);
            this.labelControl19.TabIndex = 26;
            this.labelControl19.Text = "Firma ID:";
            // 
            // txtFırmaId
            // 
            this.txtFırmaId.Location = new System.Drawing.Point(170, 557);
            this.txtFırmaId.Name = "txtFırmaId";
            this.txtFırmaId.Size = new System.Drawing.Size(151, 22);
            this.txtFırmaId.TabIndex = 27;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(19, 407);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(77, 22);
            this.labelControl20.TabIndex = 28;
            this.labelControl20.Text = "Telefon : ";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(170, 409);
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(151, 23);
            this.mskTelefon.TabIndex = 29;
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 707);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmBankalar";
            this.Text = "FrmBankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNumarası.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkılı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankaIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBankaIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFırmaId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtFırmaId;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtHesapTuru;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBankaIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBankaIl;
        private DevExpress.XtraEditors.TextEdit txtYetkılı;
        private DevExpress.XtraEditors.TextEdit txtHesapNumarası;
        private System.Windows.Forms.MaskedTextBox mskTarıh;
        private DevExpress.XtraEditors.TextEdit txtBankaSube;
        private DevExpress.XtraEditors.TextEdit txtBankaAdı;
        private DevExpress.XtraEditors.TextEdit txtBankaId;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
    }
}