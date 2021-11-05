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
    public partial class FormAerobus : Form
    {

        private ITransport aer;

        public FormAerobus()
        {
            InitializeComponent();
        }

        public void SetAir(ITransport aer)
        {
            this.aer = aer;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAerobus.Width, pictureBoxAerobus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aer.DrawTransport(gr);
            pictureBoxAerobus.Image = bmp;
        }

        private void buttonCreateAerobus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aer = new Aerobus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.BlueViolet, Color.Aquamarine, true, true, Convert.ToInt32(count_ill.SelectedItem), type_ill.SelectedIndex);
            aer.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAerobus.Width, pictureBoxAerobus.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    aer.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    aer.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    aer.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    aer.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

	}
}
