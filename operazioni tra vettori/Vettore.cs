using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operazioni_tra_vettori
{
    internal class Vettore
    {
        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }   
        public double Y { get; set; }  
        
        public static Vettore Parse (string s)
        {
            string[] xy = s.Split(';');
            return new Vettore(double.Parse(xy[0]), double.Parse(xy[1]));
        }

        public override string ToString()
        {
           return string.Format("{0},{1}", X,Y);
        }

        public static bool TryParse(string s, out Vettore v)
        {
            try
            {
                v = Vettore.Parse(s);
                return true;
            }
            catch
            {
                v = null;
                return false;
            }
        }

        public static Vettore operator + (Vettore a, Vettore b)
        {
            return new Vettore(a.X+b.X, a.Y+b.Y);
        }

        public static Vettore operator - (Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vettore operator * (Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X * v2.X, v1.Y * v2.Y);
        }

        public static Vettore operator - (Vettore v)
        {
            return new Vettore(-v.X , - v.Y );
        }

        public static Vettore operator + (Vettore v)
        {
            return new Vettore(v.X, v.Y);
        }

        public static Vettore operator * (Vettore v, double s)
        {
            return new Vettore(s*v.X, s *v.Y);
        }

       public static Vettore operator / (Vettore v, double s)
        {
            return new Vettore(s / v.X, s / v.Y);
        }

        public static bool operator == (Vettore v1, Vettore v2)
        {
           if(v1.X == v2.X && v1.Y == v2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Vettore v1, Vettore v2)
        {
            if (!(v1.X == v2.X && v1.Y == v2.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Modulo(Vettore v)
        {
            double risultato = Math.Sqrt(Math.Pow(v.X, 2) + Math.Pow(v.Y, 2));
            return risultato;
        }

    }
}
