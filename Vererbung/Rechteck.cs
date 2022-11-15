namespace Vererbung
{
    internal class Rechteck : Quadrat
    {
        private double b;

        public Rechteck()
        {
            Console.WriteLine("Konstruktor von Rechteck");
        }

        public Rechteck(int x, int y, double a, double b) : base(x, y, a)
        {
            this.b = b;
            Console.WriteLine("Konstruktor von Rechteck");
        }

        public override double BerechenFlächeninhalt()
        {
            return a * b;
        }

        public double BerechnenUmfang()
        {
            return 2 * (a + b);
        }



    }
}
