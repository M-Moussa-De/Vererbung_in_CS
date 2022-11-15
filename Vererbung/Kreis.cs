namespace Vererbung
{
    internal class Kreis : Punkt
    {
        private readonly double PI = Math.PI;
        private double radius;

        public Kreis()
        {
            Console.WriteLine("Konstruktor von Kreis");
        }

        public Kreis(int x, int y, double radius) : base(x, y)
        {
            this.radius = radius;
            Console.WriteLine("Konstruktor von Kreis");
        }

        public double GetRadius()
        {
            return this.radius;
        }

        public double BerechnenUmfang()
        {
            return 2 * this.radius * this.PI;
        }

        public override string ToString()
        {
            return base.ToString() + $" Radius: {this.GetRadius()} PI: {this.PI} " +
                   $"Kreisumfang: {this.BerechnenUmfang()}";
        }
    }
}
