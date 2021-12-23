using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Lab1_Plaksina
{
	public class Airplane : Vehicle, IEquatable<Airplane>, IComparable<Airplane>, IEnumerator<object>, IEnumerable<object>
	{

		protected readonly int carWidth = 155;
		protected readonly int carHeight = 66;

		protected readonly char separator = ';';
		private int _currentIndex = -1;
		private object[] myPropertyInfo => Type.GetType("Airplane").GetProperties();
		public object Current => myPropertyInfo[_currentIndex];
		object IEnumerator.Current => myPropertyInfo[_currentIndex];
		public Airplane(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;

		}
		public Airplane(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}
		protected Airplane(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
		}

		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
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
					if (_startPosY + step < _pictureHeight - carHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
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
		}
		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
		}
		public bool Equals(Airplane other)
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
			return true;
		}
		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (!(obj is Airplane airObj))
			{
				return false;

			}
			else
			{
				return Equals(airObj);
			}
		}
		public int CompareTo(Airplane obj)
		{
			if (MaxSpeed != obj.MaxSpeed)
			{
				return MaxSpeed.CompareTo(obj.MaxSpeed);
			}
			if (Weight != obj.Weight)
			{
				return Weight.CompareTo(obj.Weight);
			}
			if (MainColor != obj.MainColor)
			{
				return MainColor.Name.CompareTo(obj.MainColor.Name);
			}
			return 0;
		}
		public void Dispose()
		{

		}
		public bool MoveNext()
		{
			_currentIndex++;
			return _currentIndex < 8;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}

		public IEnumerator<object> GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private void printProp()
		{
			foreach (var prop in this.ToString().Split(separator))
			{
				Console.WriteLine(prop);
			}
		}
	}

}
