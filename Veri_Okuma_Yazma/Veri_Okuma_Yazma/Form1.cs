using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static EasyModbus.ModbusClient;

namespace Veri_Okuma_Yazma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}
		ModbusClient modbus;
		private void Form1_Load(object sender, EventArgs e)
		{
			txtVeriAdresi.Enabled = false;
			cmbVeriBoyutu.Enabled = false;
			cmbVeriSiralama.Enabled = false;
			cmbVeriTipi.Enabled = false;
			txtDeger.Enabled = false;
			btnOku.Enabled = false;
			btnYaz.Enabled = false;
		}

		private void btnBaglanti_Click(object sender, EventArgs e)
		{
			if (modbus == null || !modbus.Connected) // Bağlantı yoksa veya kesildiyse yeni bir bağlantı kur
			{
				modbus = new ModbusClient(txtIP.Text.ToString(), Convert.ToInt16(txtPort.Text));
				int slaveId = Convert.ToInt32(txtSlaveId.Text);
				modbus.UnitIdentifier = Convert.ToByte(slaveId);

				modbus.Connect();

				if (modbus.Connected)
				{
					// Bağlantı başarılıysa kontrolleri etkinleştir
					txtVeriAdresi.Enabled = true;
					cmbVeriBoyutu.Enabled = true;
					cmbVeriSiralama.Enabled = true;
					cmbVeriTipi.Enabled = true;
					txtDeger.Enabled = true;
					btnOku.Enabled = true;
					btnYaz.Enabled = true;

					btnBaglanti.BackColor = Color.Green;
					btnBaglanti.Text = "Kop";
				}
			}
			else
			{
				// Bağlantı varsa ve Kop butonuna tıklandıysa bağlantıyı kapat
				modbus.Disconnect();

				// Kontrolleri devre dışı bırak
				txtVeriAdresi.Enabled = false;
				cmbVeriBoyutu.Enabled = false;
				cmbVeriSiralama.Enabled = false;
				cmbVeriTipi.Enabled = false;
				txtDeger.Enabled = false;
				btnOku.Enabled = false;
				btnYaz.Enabled = false;

				btnBaglanti.BackColor = Color.FromArgb(255, 255, 192);
				btnBaglanti.BackColor = Color.Red;
				btnBaglanti.Text = "Bağlan";
			}
		}

		private void btnOku_Click(object sender, EventArgs e)
		{
			try
			{
				int veriAdresi = Convert.ToInt32(txtVeriAdresi.Text);
				int veriBoyutu = Convert.ToInt32(cmbVeriBoyutu.SelectedItem);

				int[] readData = modbus.ReadHoldingRegisters(veriAdresi, veriBoyutu);

				if (cmbVeriTipi.SelectedItem.ToString() == "Integer")
				{
					if (readData != null)
					{
						if (cmbVeriSiralama.SelectedItem.ToString() == "LowHigh")
						{
							Array.Reverse(readData);
						}
						if (cmbVeriSiralama.SelectedItem.ToString() == "HighLow")
						{
							txtDeger.Text = readData[0].ToString();
						}
					}
				}

				else if(cmbVeriTipi.SelectedItem.ToString() == "Float")
				{
					if (readData != null)
					{
						if(cmbVeriSiralama.SelectedItem.ToString() == "LowHigh")
						{
							ModbusClient.RegisterOrder registerOrder = ModbusClient.RegisterOrder.LowHigh;
							double value = ModbusClient.ConvertRegistersToFloat(modbus.ReadHoldingRegisters(veriAdresi, veriBoyutu), registerOrder);
							txtDeger.Text = value.ToString();

						}
						if(cmbVeriSiralama.SelectedItem.ToString() == "HighLow")
						{
							ModbusClient.RegisterOrder registerOrder2 = ModbusClient.RegisterOrder.HighLow;
							double value = ModbusClient.ConvertRegistersToFloat(modbus.ReadHoldingRegisters(veriAdresi, veriBoyutu), registerOrder2);
							txtDeger.Text = value.ToString();
						}

						
					}
				}
			}
			catch(Exception exception)
			{
				MessageBox.Show("Okuma işlemi sırasında bir hata oluştu: " + exception.Message);
			}
		}

		private void btnYaz_Click(object sender, EventArgs e)
		{
			try
			{
				if(cmbVeriTipi.SelectedItem.ToString() == "Integer")
				{
					modbus.WriteSingleRegister(Convert.ToInt16(txtVeriAdresi.Text), Convert.ToInt32(txtDeger.Text));
					MessageBox.Show("Integer türünde yazdırma işleminiz başarıyla gerçekleştirildi.");
				}

				else if(cmbVeriTipi.SelectedItem.ToString() == "Float")
				{
					float floatValue = float.Parse(txtDeger.Text);
					
					int[] registers = ModbusClient.ConvertFloatToRegisters(floatValue); // Float değerini Modbus register'larına dönüştürür.

					modbus.WriteMultipleRegisters(Convert.ToInt16(txtVeriAdresi.Text),registers); // Modbus ile register'ları yazdır

					MessageBox.Show("Float türünde yazdırma işleminiz başarıyla gerçekleştirildi.");
				}

			}
			catch(Exception exception)
			{
				MessageBox.Show("Yazma işlemi sırasında bir hata gerçekleşti: " + exception.Message);
			}
		}
	}
}

//4500 -> 1,4
