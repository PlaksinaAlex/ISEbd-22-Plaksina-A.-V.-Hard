using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_Plaksina
{
	public interface Inter_Dop
	{
		int Illuminator { set; }
		void DrawIlluminators(Graphics g, float _startPosX, float _startPosY, Color color);
	}
}
