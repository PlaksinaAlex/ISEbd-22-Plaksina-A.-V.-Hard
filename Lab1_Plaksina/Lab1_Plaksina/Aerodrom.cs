using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1_Plaksina
{
    public class Aerodrom<T, P>

        where T : class, ITransport
        where P : Inter_Dop
    {

        private readonly List<T> _places;
        public int length => _places.Count;

        private readonly int pictureWidth;

        private readonly int _maxCount;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 300;

        private readonly int _placeSizeHeight = 80;

        public int index = -1;

        public Aerodrom(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }

        public static bool operator +(Aerodrom<T, P> p, T aer)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new AerodromOverflowException();
            }
            p._places.Add(aer);
            return true;
        }

        public static T operator -(Aerodrom<T, P> p, int index)
        {
            if (index < -1 || index >= p._places.Count)
            {
                throw new AerodromNotFoundException(index);
            }
            T aer = p._places[index];
            p._places.RemoveAt(index);
            return aer;
        }


        public static bool operator ==(Aerodrom<T, P> p, double p2)
        {
            double x = p._places.Count;
            if (x == p2) return true;
            return false;
        }

        public static bool operator !=(Aerodrom<T, P> p, double p2)
        {
            double x = p._places.Count;
            if (x != p2) return true;
            return false;
        }


        public void Draw(Graphics g)
        {
            int width = pictureWidth / _placeSizeWidth;
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(i % width * _placeSizeWidth + 10,
                i / width * _placeSizeHeight + 10, pictureWidth,
                pictureHeight);
                _places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {

                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (ind > -1 && ind < _places.Count)
                    return _places[ind];
                return null;
            }
        }
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        public void ClearPlaces()
        {
            _places.Clear();
        }
    }
}