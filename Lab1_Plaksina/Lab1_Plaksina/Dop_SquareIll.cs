using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_Plaksina
{
	class Dop_SquareIll : Inter_Dop
	{
		private Dop_Perechisl illuminator;

		public int Illuminator { set => illuminator = (Dop_Perechisl)value; }

		public void DrawIlluminators(Graphics g, float _startPosX, float _startPosY, Color color)
		{
			switch (illuminator)
			{
				case Dop_Perechisl.Ten:
					DrawIlluminatorsTen(g, _startPosX, _startPosY, color);
					break;

				case Dop_Perechisl.Twenty:
					DrawIlluminatorsTwenty(g, _startPosX, _startPosY, color);
					break;

				case Dop_Perechisl.Thrity:
					DrawIlluminatorsThrity(g, _startPosX, _startPosY, color);
					break;
			}
		}


		Pen pen = new Pen(Color.Black, 2);

		private void DrawIlluminatorsTen(Graphics g, float _startPosX, float _startPosY, Color color)
		{
			Brush brushdop = new SolidBrush(color);
			for (int i = 0; i < 10; i++)
			{
				g.DrawRectangle(pen, _startPosX + 38 + i * 9, _startPosY + 16, 6, 6);
				g.FillRectangle(brushdop, _startPosX + 38 + i * 9, _startPosY + 16, 6, 6);
			}
		}
		private void DrawIlluminatorsTwenty(Graphics g, float _startPosX, float _startPosY, Color color)
		{
			DrawIlluminatorsTen(g, _startPosX, _startPosY, color);
			Brush brushdop = new SolidBrush(color);
			for (int i = 0; i < 10; i++)
			{
				g.DrawRectangle(pen, _startPosX + 38 + i * 9, _startPosY + 24, 6, 6);
				g.FillRectangle(brushdop, _startPosX + 38 + i * 9, _startPosY + 24, 6, 6);
			}
		}
		private void DrawIlluminatorsThrity(Graphics g, float _startPosX, float _startPosY, Color color)
		{
			Brush brushdop = new SolidBrush(color);
			DrawIlluminatorsTwenty(g, _startPosX, _startPosY, color);
			for (int i = 0; i < 5; i++)
			{
				g.DrawRectangle(pen, _startPosX + 2 + i * 7, _startPosY + 41, 5, 5);
				g.DrawRectangle(pen, _startPosX + 2 + i * 7, _startPosY + 47, 5, 5);
				g.FillRectangle(brushdop, _startPosX + 2 + i * 7, _startPosY + 41, 5, 5);
				g.FillRectangle(brushdop, _startPosX + 2 + i * 7, _startPosY + 47, 5, 5);
			}
		}

	}

}
