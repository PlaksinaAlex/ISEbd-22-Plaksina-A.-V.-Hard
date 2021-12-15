using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Plaksina
{
    class AerodromOccupiedPlaceException : Exception
    {
        public AerodromOccupiedPlaceException() : base("Не удалось припарковать")
        { }
    }
}
