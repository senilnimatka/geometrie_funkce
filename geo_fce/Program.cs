using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo_fce
{
    class Program
    {
        private static double obvodctverce(double a)
        {
            return 4 * a;
        }
        private static double obsahctverce(double a)
        {
            return a * a;
        }
        private static double obvodobdelniku(double a, double b)
        {
            return (2 * a) + (2 * b);
        }
        private static double obsahobdelniku(double a, double b)
        {
            return a * b;
        }
        private static double obvodtrojuhelniku(double a, double b, double c)
        {
            return a + b + c;
        }
        private static double obsahtrojuhelniku(double s, double v)
        {
            return (s * v) / 2;
        }
        private static double obvodkruhu(double r)
        {
            return 2 * Math.PI * r;
        }
        private static double obsahkruhu(double r)
        {
            return Math.PI * r * r;
        }
        //3Ds
        private static double objemkrychle(double a)
        {
            return a * a * a;
        }
        private static double povrchkrychle(double a)
        {
            return 6 * a * a;
        }
        private static double objemkvadru(double a, double c, double b)
        {
            return a * b * c;
        }
        private static double povrchkvadru(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        private static double objemvalce(double r)
        {
            return Math.PI * r * r;
        }
        private static double povrchvalce(double r, double v)
        {
            return (2 * r * v) + (2 * Math.PI * r * r);
        }
        private static double objemjehlanu(double a, double v)
        {
            return (1 / 3) * a * a * v;
        }
        private static double povrchjehlanu(double a, double v)
        {
            return a * (a + Math.Sqrt(4 * v * v + a * a));
        }

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("2D nebo 3D:");
                Console.WriteLine("2 pro 2D, 3 pro 3D");
                int volba = int.Parse(Console.ReadLine());
                switch (volba)
                {
                    case 2:
                        Console.WriteLine("vyberte geometrický tvar");
                        Console.WriteLine("1 pro O čtverce");
                        Console.WriteLine("2 pro S čtverce");
                        Console.WriteLine("3 pro O obdelníku");
                        Console.WriteLine("4 pro S obdelíku");
                        Console.WriteLine("5 pro O trojúhelníku");
                        Console.WriteLine("6 pro S trojúhelníku");
                        Console.WriteLine("7 pro O kruhu");
                        Console.WriteLine("8 pro S kruhu");

                        int volba2 = int.Parse(Console.ReadLine());
                        double vysledek = 0;
                        switch (volba2)
                        {

                            case 1:
                                Console.WriteLine("Zadejte číslo v cm");
                                double x = double.Parse(Console.ReadLine());
                                vysledek = obvodctverce(x);
                                Console.WriteLine("obvod čtverce - " + vysledek + "cm");
                                break;

                            case 2:
                                Console.WriteLine("Zadejte číslo v cm");
                                double a = double.Parse(Console.ReadLine());
                                vysledek = obsahctverce(a);
                                Console.WriteLine("obsah čtverce - " + vysledek + "cm^2");
                                break;

                            case 3:
                                Console.WriteLine("Zadejte 1. číslo v cm");
                                double b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte 2. číslo v cm");
                                double c = double.Parse(Console.ReadLine());
                                vysledek = obvodobdelniku(b, c);
                                Console.WriteLine("obvod obdélníku - " + vysledek + "cm");
                                break;
                            case 4:
                                Console.WriteLine("Zadejte 1. číslo v cm");
                                double d = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte 2. číslo v cm");
                                double e = double.Parse(Console.ReadLine());
                                vysledek = obsahobdelniku(d, e);
                                Console.WriteLine("obsah obdélníku - " + vysledek + "cm^2");
                                break;

                            case 5:
                                Console.WriteLine("Zadejte 1. číslo v cm");
                                double f = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte 2. číslo v cm");
                                double g = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte 3. číslo v cm");
                                double h = double.Parse(Console.ReadLine());
                                vysledek = obvodtrojuhelniku(f, g, h);
                                Console.WriteLine("obvod trojúhelníku - " + vysledek + "cm");
                                break;

                            case 6:
                                Console.WriteLine("zadejte starnu");
                                double i = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte výšku");
                                double j = double.Parse(Console.ReadLine());
                                vysledek = obsahtrojuhelniku(i, j);
                                Console.WriteLine("obsah trojúhelníku - " + vysledek + "cm^2");
                                break;

                            case 7:
                                Console.WriteLine("Zadejte poloměr");
                                double k = double.Parse(Console.ReadLine());
                                vysledek = obvodkruhu(k);
                                Console.WriteLine("obvod kruhu - " + vysledek + "cm");
                                break;

                            case 8:
                                Console.WriteLine("zadejte poloměr");
                                double l = double.Parse(Console.ReadLine());
                                vysledek = obsahkruhu(l);
                                Console.WriteLine("obsah kruhu " + vysledek + "cm^2");
                                break;

                            default:
                                break;
                        }

                        break;

                    case 3:
                        Console.WriteLine("Vyberte geometrický tvar");
                        Console.WriteLine("1 pro V krychle");
                        Console.WriteLine("2 pro S krychle");
                        Console.WriteLine("3 pro V kvádru");
                        Console.WriteLine("4 pro S kvádru");
                        Console.WriteLine("5 pro V válce");
                        Console.WriteLine("6 pro S válce");
                        Console.WriteLine("7 pro V jehlanu");
                        Console.WriteLine("8 pro S jehlanu");
                        int volba3 = int.Parse(Console.ReadLine());
                        double vysledek2 = 0;

                        switch (volba3)
                        {
                            case 1:
                                Console.WriteLine("Zadejte číslo v cm");
                                double m = double.Parse(Console.ReadLine());
                                vysledek2 = povrchkrychle(m);
                                Console.WriteLine("objem krychle - " + vysledek2 + "cm^3");
                                break;

                            case 2:
                                Console.WriteLine("Zaejte číslo v cm");
                                double n = double.Parse(Console.ReadLine());
                                vysledek = objemkrychle(n);
                                Console.WriteLine("povrch krychle - " + vysledek2 + "cm^2");
                                break;

                            case 3:
                                Console.WriteLine("Zadejte 1. číslo v cm");
                                double o = double.Parse(Console.ReadLine());
                                Console.WriteLine("zadejte 2. číslo v cm");
                                double p = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadjet 3. číslo v cm");
                                double q = double.Parse(Console.ReadLine());
                                vysledek2 = povrchkvadru(o, p, q);
                                Console.WriteLine("objem kvádru - " + vysledek2 + "cm^3");
                                break;

                            case 4:
                                Console.WriteLine("Zadejte 1. číslo v cm");
                                double r = double.Parse(Console.ReadLine());
                                Console.WriteLine("zadejte 2. číslo v cm");
                                double s = double.Parse(Console.ReadLine());
                                Console.WriteLine("zadejet 3. číslo v cm");
                                double t = double.Parse(Console.ReadLine());
                                vysledek2 = objemkvadru(r, s, t);
                                Console.WriteLine("povrch kvádru - " + vysledek2 + "cm^2");
                                break;

                            case 5:
                                Console.WriteLine("Zadejte poloměr v cm");
                                double u = double.Parse(Console.ReadLine());
                                vysledek2 = objemvalce(u);
                                Console.WriteLine("objem válce - " + vysledek2 + "cm^3");
                                break;

                            case 6:
                                Console.WriteLine("zadejte 1. číslo v cm");
                                double v = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte 2. číslo v cm");
                                double w = double.Parse(Console.ReadLine());
                                vysledek2 = povrchvalce(v, w);
                                Console.WriteLine("povrch válce - " + vysledek2 + "cm^2");
                                break;

                            case 7:
                                Console.WriteLine("zadejte 1. číslo v cm");
                                double y = double.Parse(Console.ReadLine());
                                Console.WriteLine("zadejte vášku v cm");
                                double z = double.Parse(Console.ReadLine());
                                vysledek2 = objemjehlanu(y, z);
                                Console.WriteLine("objem jehlanu - " + vysledek2 + "cm^3");
                                break;

                            case 8:
                                Console.WriteLine("Zadejte 1. číslo v cm");
                                double aa = double.Parse(Console.ReadLine());
                                Console.WriteLine("Zadejte výšku v cm");
                                double bb = double.Parse(Console.ReadLine());
                                vysledek2 = povrchjehlanu(aa, bb);
                                Console.WriteLine("povrch jehlanu - " + vysledek2 + "cm^2");
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
 
