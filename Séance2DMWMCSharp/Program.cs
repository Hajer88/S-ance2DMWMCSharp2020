using System;

namespace Séance2DMWMCSharp
{
    public struct Moyenne 
    {
        public int x;
        public int y;
        public Moyenne(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void CalculerMoyenne()
        {
            Console.WriteLine(x + y);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            dynamic name = "HEllo";
            name = 10;
            dynamic a = 10;
            dynamic b = 10;
            var c = a+b;
            Moyenne m = new Moyenne(9, 7);
            m.CalculerMoyenne();
            //Configurer les propriétés manuellement à partir du constructeur 
            //par défaut
            Point p = new Point();
            p.X = 10;
            p.Y = 10;
            p.Display();
            //Contruire le point avec le constructeur personnalisé
            Point p1= new Point(10, 10, PointColors.Gold);
            p1.Display();
            Console.WriteLine("Hello World!");
            //Init syntax
            Point P2 = new Point { X = 10, Y = 10 };
            CompteEnBanque compte= new CompteEnBanque();
            compte.credit(100);
            compte.debit(200);
            Console.WriteLine(c.LireSolde());

        }
    }
}
