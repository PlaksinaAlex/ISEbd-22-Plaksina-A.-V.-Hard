using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Plaksina
{
	public partial class FormAerodrom : Form
	{
		private readonly Aerodrom<Airplane, Inter_Dop> aerodrom;

		public FormAerodrom()
		{
			InitializeComponent();
			aerodrom = new Aerodrom<Airplane, Inter_Dop>(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
			Draw();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
			Graphics gr = Graphics.FromImage(bmp);
			aerodrom.Draw(gr);
			pictureBoxAerodrom.Image = bmp;
		}

		private void buttonSetAirplane_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var airplane = new Airplane(100, 1000, dialog.Color);
				if (aerodrom + airplane != -1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Аэродром переполнен");
				}
			}
		}

		private void buttonSetAerobus_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var airplane = new Aerobus(100, 1000, dialog.Color, dialogDop.Color, true, true, 10, 1);
					if (aerodrom + airplane != -1)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Аэродром переполнен");
					}
				}
			}
		}

		private void buttonTakeAirplane_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var airplane = aerodrom - Convert.ToInt32(maskedTextBox.Text);
				if (airplane != null)
				{
					FormAerobus form = new FormAerobus();
					form.SetAir(airplane);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
