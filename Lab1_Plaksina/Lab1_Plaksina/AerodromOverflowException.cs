using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Plaksina
{
	public class AerodromOverflowException : Exception
	{
		public AerodromOverflowException() : base("На аэродроме нет свободных мест")
		{ }
	}
}
