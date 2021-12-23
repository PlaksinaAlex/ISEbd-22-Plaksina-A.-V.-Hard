using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Plaksina
{
	public class AirplaneComparer : IComparer<Vehicle>
	{
		public int Compare(Vehicle x, Vehicle y)
		{
			if (x is Aerobus && y is Aerobus)
			{
				return ComparerAerobus((Aerobus)x, (Aerobus)y);
			}
			if (x is Aerobus && y is Airplane)
			{
				return -1;
			}
			if (x is Airplane && y is Aerobus)
			{
				return 1;
			}
			if (x is Airplane && y is Airplane)
			{
				return ComparerAirplane((Airplane)x, (Airplane)y);
			}
			return 0;
		}
		private int ComparerAirplane(Airplane x, Airplane y)
		{
			if (x.MaxSpeed != y.MaxSpeed)
			{
				return x.MaxSpeed.CompareTo(y.MaxSpeed);
			}
			if (x.Weight != y.Weight)
			{
				return x.Weight.CompareTo(y.Weight);
			}
			if (x.MainColor != y.MainColor)
			{
				return x.MainColor.Name.CompareTo(y.MainColor.Name);
			}
			return 0;
		}

		private int ComparerAerobus(Aerobus x, Aerobus y)
		{
			var res = ComparerAirplane(x, y);
			if (res != 0)
			{
				return res;
			}
			if (x.DopColor != y.DopColor)
			{
				return x.DopColor.Name.CompareTo(y.DopColor.Name);
			}
			if (x.Window != y.Window)
			{
				return x.Window.CompareTo(y.Window);
			}
			if (x.Floor != y.Floor)
			{
				return x.Floor.CompareTo(y.Floor);
			}
			return 0;
		}
	}
}
