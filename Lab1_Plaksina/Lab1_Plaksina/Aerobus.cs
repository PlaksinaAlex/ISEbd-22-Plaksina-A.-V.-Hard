using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1_Plaksina
{
    public class Aerobus : Airplane
    {
       
        public Color DopColor { private set; get; }
        public bool Window { private set; get; }
        public bool Floor { private set; get; }

        private Inter_Dop InD;

        public Aerobus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool window, bool floor, int CountIll, int TypeIll)
            : base(maxSpeed, weight, mainColor, 155, 66)
        {

            DopColor = dopColor;
            Window = window;
            Floor = floor;
           switch (TypeIll)
			{
                case 0:
                    InD = new Dop_CircleIll();
                    break;
                case 1:
                    InD = new Dop_SquareIll();
                    break;
                case 2:
                    InD = new Dop_StripIll();
                    break;
            }

            InD.Illuminator = CountIll;
        }
        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = new Pen(Color.Black);
            Brush brushdop = new SolidBrush(DopColor);
            if (Window)
            {
                g.DrawEllipse(pen, _startPosX + 113, _startPosY + 40, 10, 10);
                g.FillEllipse(brushdop, _startPosX + 113, _startPosY + 40, 10, 10);

            }
            // 2 этаж
            if (Floor)
            {
                g.DrawRectangle(pen, _startPosX + 36, _startPosY + 13, 91, 19);
                g.FillRectangle(brushdop, _startPosX + 36, _startPosY + 13, 91, 19);
            }

            InD.DrawIlluminators(g, _startPosX, _startPosY, DopColor);
        }
    }
}


