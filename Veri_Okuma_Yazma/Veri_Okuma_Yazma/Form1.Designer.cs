namespace Veri_Okuma_Yazma
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
			this.txtSlaveId = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtVeriAdresi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbVeriBoyutu = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbVeriSiralama = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbVeriTipi = new System.Windows.Forms.ComboBox();
			this.btnOku = new System.Windows.Forms.Button();
			this.btnYaz = new System.Windows.Forms.Button();
			this.txtDeger = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnBaglanti = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(51, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Slave ID";
			// 
			// txtSlaveId
			// 
			this.txtSlaveId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSlaveId.Location = new System.Drawing.Point(55, 86);
			this.txtSlaveId.Name = "txtSlaveId";
			this.txtSlaveId.Size = new System.Drawing.Size(135, 30);
			this.txtSlaveId.TabIndex = 1;
			// 
			// txtPort
			// 
			this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPort.Location = new System.Drawing.Point(55, 223);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(135, 30);
			this.txtPort.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(51, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port";
			// 
			// txtIP
			// 
			this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtIP.Location = new System.Drawing.Point(55, 153);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(184, 30);
			this.txtIP.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(51, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "IP Adresi";
			// 
			// txtVeriAdresi
			// 
			this.txtVeriAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtVeriAdresi.Location = new System.Drawing.Point(431, 50);
			this.txtVeriAdresi.Name = "txtVeriAdresi";
			this.txtVeriAdresi.Size = new System.Drawing.Size(135, 30);
			this.txtVeriAdresi.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(427, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Veri Adresi";
			// 
			// cmbVeriBoyutu
			// 
			this.cmbVeriBoyutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbVeriBoyutu.FormattingEnabled = true;
			this.cmbVeriBoyutu.Items.AddRange(new object[] {
            "1",
            "2",
            "8",
            "16",
            "32"});
			this.cmbVeriBoyutu.Location = new System.Drawing.Point(431, 129);
			this.cmbVeriBoyutu.Name = "cmbVeriBoyutu";
			this.cmbVeriBoyutu.Size = new System.Drawing.Size(135, 33);
			this.cmbVeriBoyutu.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(427, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Veri Boyutu";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(427, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "Veri Sıralaması";
			// 
			// cmbVeriSiralama
			// 
			this.cmbVeriSiralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbVeriSiralama.FormattingEnabled = true;
			this.cmbVeriSiralama.Items.AddRange(new object[] {
            "HighLow",
            "LowHigh"});
			this.cmbVeriSiralama.Location = new System.Drawing.Point(431, 213);
			this.cmbVeriSiralama.Name = "cmbVeriSiralama";
			this.cmbVeriSiralama.Size = new System.Drawing.Size(135, 33);
			this.cmbVeriSiralama.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(427, 265);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Veri Tipi";
			// 
			// cmbVeriTipi
			// 
			this.cmbVeriTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbVeriTipi.FormattingEnabled = true;
			this.cmbVeriTipi.Items.AddRange(new object[] {
            "Integer",
            "Float"});
			this.cmbVeriTipi.Location = new System.Drawing.Point(431, 288);
			this.cmbVeriTipi.Name = "cmbVeriTipi";
			this.cmbVeriTipi.Size = new System.Drawing.Size(135, 33);
			this.cmbVeriTipi.TabIndex = 14;
			// 
			// btnOku
			// 
			this.btnOku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOku.Location = new System.Drawing.Point(642, 227);
			this.btnOku.Name = "btnOku";
			this.btnOku.Size = new System.Drawing.Size(139, 44);
			this.btnOku.TabIndex = 16;
			this.btnOku.Text = "Oku";
			this.btnOku.UseVisualStyleBackColor = false;
			this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
			// 
			// btnYaz
			// 
			this.btnYaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnYaz.Location = new System.Drawing.Point(642, 277);
			this.btnYaz.Name = "btnYaz";
			this.btnYaz.Size = new System.Drawing.Size(139, 44);
			this.btnYaz.TabIndex = 17;
			this.btnYaz.Text = "Yaz";
			this.btnYaz.UseVisualStyleBackColor = false;
			this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
			// 
			// txtDeger
			// 
			this.txtDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDeger.Location = new System.Drawing.Point(642, 179);
			this.txtDeger.Name = "txtDeger";
			this.txtDeger.Size = new System.Drawing.Size(135, 30);
			this.txtDeger.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(638, 158);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 20);
			this.label8.TabIndex = 20;
			this.label8.Text = "Değer";
			// 
			// btnBaglanti
			// 
			this.btnBaglanti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnBaglanti.Location = new System.Drawing.Point(55, 277);
			this.btnBaglanti.Name = "btnBaglanti";
			this.btnBaglanti.Size = new System.Drawing.Size(312, 44);
			this.btnBaglanti.TabIndex = 21;
			this.btnBaglanti.Text = "BAĞLAN";
			this.btnBaglanti.UseVisualStyleBackColor = false;
			this.btnBaglanti.Click += new System.EventHandler(this.btnBaglanti_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(839, 384);
			this.Controls.Add(this.btnBaglanti);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtDeger);
			this.Controls.Add(this.btnYaz);
			this.Controls.Add(this.btnOku);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbVeriTipi);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbVeriSiralama);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbVeriBoyutu);
			this.Controls.Add(this.txtVeriAdresi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSlaveId);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSlaveId;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtVeriAdresi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbVeriBoyutu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbVeriSiralama;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbVeriTipi;
		private System.Windows.Forms.Button btnOku;
		private System.Windows.Forms.Button btnYaz;
		private System.Windows.Forms.TextBox txtDeger;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnBaglanti;
	}
}

