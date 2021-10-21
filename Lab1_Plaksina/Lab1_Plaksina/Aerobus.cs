using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1_Plaksina
{
    class Aerobus
    {
        private float _startPosX;
        private float _startPosY;

        private int _pictureWidth;
        private int _pictureHeight;

        private readonly int aerWidth = 150;
        private readonly int aerHeight = 66;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Window { private set; get; }
        public bool Floor { private set; get; }

        private DopClass_Illuminators Illuminators = new DopClass_Illuminators();

        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool window, bool floor, int CountIll)

        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Window = window;
            Floor = floor;
            Illuminators.Illuminator = CountIll;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - aerWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - aerHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        //Отрисовка аеробуса
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            // тело
            g.DrawEllipse(pen, _startPosX, _startPosY + 34, 20, 20);
            g.DrawRectangle(pen, _startPosX + 7, _startPosY + 34, 120, 20);
            //черным цветом
            g.DrawEllipse(pen, _startPosX + 37, _startPosY + 40, 70, 7);
            g.DrawEllipse(pen, _startPosX + 5, _startPosY + 31, 25, 8);
            //колеса
            g.DrawEllipse(pen, _startPosX + 41, _startPosY + 62, 4, 4);
            g.DrawEllipse(pen, _startPosX + 34, _startPosY + 62, 4, 4);
            g.DrawEllipse(pen, _startPosX + 118, _startPosY + 62, 4, 4);
            //трегугольники
            g.DrawLine(pen, _startPosX + 7, _startPosY, _startPosX + 7, _startPosY + 35);
            g.DrawLine(pen, _startPosX + 7, _startPosY, _startPosX + 40, _startPosY + 34);
            g.DrawLine(pen, _startPosX + 40, _startPosY + 55, _startPosX + 40, _startPosY + 64);
            g.DrawLine(pen, _startPosX + 120, _startPosY + 55, _startPosX + 120, _startPosY + 62);
            g.DrawLine(pen, _startPosX + 127, _startPosY + 45, _startPosX + 150, _startPosY + 45);
            g.DrawLine(pen, _startPosX + 127, _startPosY + 55, _startPosX + 150, _startPosY + 45);
            g.DrawLine(pen, _startPosX + 127, _startPosY + 35, _startPosX + 150, _startPosY + 45);
            Brush brushmain = new SolidBrush(MainColor);
            g.FillEllipse(brushmain, _startPosX, _startPosY + 34, 20, 20);
            g.FillRectangle(brushmain, _startPosX + 7, _startPosY + 34, 120, 20);
            Brush brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, _startPosX + 37, _startPosY + 40, 70, 7);
            g.FillEllipse(brush, _startPosX + 5, _startPosY + 32, 25, 8);
            g.FillEllipse(brush, _startPosX + 41, _startPosY + 62, 4, 4);
            g.FillEllipse(brush, _startPosX + 34, _startPosY + 62, 4, 4);
            g.FillEllipse(brush, _startPosX + 118, _startPosY + 62, 4, 4);
            // окно
            Brush brushdop = new SolidBrush(DopColor);
            if (Window)
            {
                g.DrawEllipse(pen, _startPosX + 113, _startPosY + 40, 10, 10);
                g.FillEllipse(brushdop, _startPosX + 113, _startPosY + 40, 10, 10);
            }

            // 2 этаж
            if (Floor)
            {
                g.DrawRectangle(pen, _startPosX + 37, _startPosY + 15, 90, 18);
                g.FillRectangle(brushdop, _startPosX + 37, _startPosY + 15, 90, 18);
            }

            Illuminators.DrawIlluminators(g, _startPosX, _startPosY, DopColor);
        }
    }
}


