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

		private LinkedList<Vehicle> link_list;

		public FormAerodrom()
		{
			InitializeComponent();
			aerodromCollection = new AerodromCollection(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
			link_list = new LinkedList<Vehicle>();
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

		private void buttonAddAir_Click(object sender, EventArgs e)
		{
			var formAerobusConfig = new FormAerobusConfig();
			formAerobusConfig.AddEvent(AddAir);
			formAerobusConfig.Show();
		}

		private void AddAir(Vehicle aer)
		{
			if (aer != null && listBoxAerodrom.SelectedIndex > -1)
			{
				if ((aerodromCollection[listBoxAerodrom.SelectedItem.ToString()]) + aer)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Самолет не удалось поставить");
				}
			}
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
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (aerodromCollection.SaveData(saveFileDialog.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "Результат",
				   MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "Результат",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (aerodromCollection.LoadAerodromCollection(openFileDialog.FileName))
				{
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
				   MessageBoxIcon.Information);
					ReloadLevels();
					Draw();
				}
				else
				{
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
		}

		private void сохранитьОдинАэродромToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (listBoxAerodrom.SelectedIndex > -1)
				{
					if (aerodromCollection.SaveData(saveFileDialog.FileName, listBoxAerodrom.SelectedItem.ToString()))
					{
						MessageBox.Show("Сохранение прошло успешно", "Результат",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Не сохранилось", "Результат",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void загрузитьОдинАэродромToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (aerodromCollection.LoadAerodrom(openFileDialog.FileName))
				{
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
					ReloadLevels();
					Draw();
				}
				else
				{
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
			}
		}
	}
}
