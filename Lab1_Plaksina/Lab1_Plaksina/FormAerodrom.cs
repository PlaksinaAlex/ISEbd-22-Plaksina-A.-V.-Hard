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
		private readonly AerodromCollection aerodromCollection;

		private LinkedList<Airplane> link_list;

		public FormAerodrom()
		{
			InitializeComponent();
			aerodromCollection = new AerodromCollection(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
			link_list = new LinkedList<Airplane>();
			Draw();
		}

		private void ReloadLevels()
		{
			int index = listBoxAerodrom.SelectedIndex;
			listBoxAerodrom.Items.Clear();

			for (int i = 0; i < aerodromCollection.Keys.Count; i++)
			{
				listBoxAerodrom.Items.Add(aerodromCollection.Keys[i]);
			}

			if (listBoxAerodrom.Items.Count > 0 && (index == -1 || index >=
		   listBoxAerodrom.Items.Count))
			{
				listBoxAerodrom.SelectedIndex = 0;
			}

			else if (listBoxAerodrom.Items.Count > 0 && index > -1 && index <
		   listBoxAerodrom.Items.Count)
			{
				listBoxAerodrom.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBoxAerodrom.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
				Graphics gr = Graphics.FromImage(bmp);
				aerodromCollection[listBoxAerodrom.SelectedItem.ToString()].Draw(gr);
				pictureBoxAerodrom.Image = bmp;
			};
		}

		private void buttonSetAirplane_Click(object sender, EventArgs e)
		{
			if (listBoxAerodrom.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var airplane = new Airplane(100, 1000, dialog.Color);
					if (aerodromCollection[listBoxAerodrom.SelectedItem.ToString()] + airplane)
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

		private void buttonSetAerobus_Click(object sender, EventArgs e)
		{
			if (listBoxAerodrom.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var airplane = new Aerobus(100, 1000, dialog.Color, dialogDop.Color, true, true, 10, 1);
						if (aerodromCollection[listBoxAerodrom.SelectedItem.ToString()] + airplane)
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
		}

		private void buttonTakeAirplane_Click(object sender, EventArgs e)
		{
			if (listBoxAerodrom.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				var airplane = aerodromCollection[listBoxAerodrom.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
				link_list.AddLast(airplane);
				Draw();
			}
		}
		private void buttonAddAerodrom_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
			{
				MessageBox.Show("Введите название аэродрома", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			aerodromCollection.AddAerodrom(textBoxNewLevelName.Text);
			ReloadLevels();
		}

		private void buttonDelAerodrom_Click(object sender, EventArgs e)
		{
			if (listBoxAerodrom.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить аэродром { listBoxAerodrom.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
				{
					aerodromCollection.DelAerodrom(textBoxNewLevelName.Text);
					ReloadLevels();
				}
			}
		}
		private void listBoxAerodrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}

		private void buttonAddtoLinkedList_Click(object sender, EventArgs e)
		{
			if (link_list.Count > 0)
			{
				var airplane = link_list.Last();
				link_list.RemoveLast();
				if (airplane != null)
				{
					FormAerobus form = new FormAerobus();
					form.SetAir(airplane);
					form.ShowDialog();
				}
			}
			Draw();
		}
	}
}
