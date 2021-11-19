using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Plaksina
{
	public class AerodromCollection
	{
		readonly Dictionary<string, Aerodrom<Vehicle, Dop_CircleIll>> aerodromStages;
		public List<string> Keys => aerodromStages.Keys.ToList();

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		public AerodromCollection(int pictureWidth, int pictureHeight)
		{
			aerodromStages = new Dictionary<string, Aerodrom<Vehicle, Dop_CircleIll>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		public void AddAerodrom(string name)
		{
			if (aerodromStages.ContainsKey(name))
			{
				return;
			}
			aerodromStages.Add(name, new Aerodrom<Vehicle, Dop_CircleIll>(pictureWidth, pictureHeight));
		}

		public void DelAerodrom(string name)
		{
			if (aerodromStages.ContainsKey(name))
			{
				aerodromStages.Remove(name);
			}
		}

		public Aerodrom<Vehicle, Dop_CircleIll> this[string ind]
		{
			get
			{
				if (aerodromStages.ContainsKey(ind))
				{
					return aerodromStages[ind];
				}
				else
				{
					return null;
				}
			}
		}
		public Vehicle this[string ind, int ind2]
		{
			get
			{
				if ((aerodromStages.ContainsKey(ind)) && ((ind2 > 0 && ind2 < aerodromStages[ind].length)))
				{
					return aerodromStages[ind][ind2];
				}
				else
				{
					return null;
				}
			}
		}

	}
}
