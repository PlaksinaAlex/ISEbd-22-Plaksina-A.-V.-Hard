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

        public string IDopName => InD.GetType().Name;
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
        public Aerobus(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Window = Convert.ToBoolean(strs[4]);
                Floor = Convert.ToBoolean(strs[5]);
                if (strs[6] == "Dop_CircleIll")
                {
                    InD = new Dop_CircleIll();
                }
                else if (strs[6] == "Dop_SquareIll")
                {
                    InD = new Dop_SquareIll();
                }
                else if (strs[6] == "Dop_StripIll")
                {
                    InD = new Dop_StripIll();
                }
                InD.Illuminator = 10;
            }
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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public void SetTypesIll(Inter_Dop type)
        {
            this.InD = type;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Window}{separator}{Floor}{separator}{InD.GetType().Name}";
        }
        public bool Equals(Aerobus other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Window != other.Window)
            {
                return false;
            }
            if (Floor != other.Floor)
            {
                return false;
            }
            if (IDopName != other.IDopName)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Aerobus airObj))
            {
                return false;
            }
            else
            {
                return Equals(airObj);
            }
        }
        public int CompareTo(Object obj)
        {
            if (obj == null)
            {
                return -1;
            }
            if (!(obj is Aerobus aerObj))
            {
                return -1;
            }
            else
            {
                return CompareTo(aerObj);
            }
        }
        public int CompareTo(Aerobus obj)
        {

            var res = base.CompareTo(obj);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != obj.DopColor)
            {
                return DopColor.Name.CompareTo(obj.DopColor.Name);
            }
            if (Floor != obj.Floor)
            {
                return Floor.CompareTo(obj.Floor);
            }
            if (Window != obj.Window)
            {
                return Window.CompareTo(obj.Window);
            }
            if (IDopName != obj.IDopName)
            {
                return IDopName.CompareTo(obj.IDopName);
            }
            return 0;
        }
        private void printProp()
        {
            foreach (var str in this.ToString().Split(separator))
            {
                Console.WriteLine(str);
            }
        }

    }
}


