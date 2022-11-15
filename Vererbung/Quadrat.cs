namespace Vererbung
{
    internal class Quadrat : Punkt
    {
        protected double a;
        public Quadrat()
        {
            Console.WriteLine("Konstruktor von Quadrat");
        }

        public Quadrat(int x, int y, double a) : base(x, y)
        {
            this.a = a;
            Console.WriteLine("Konstruktor von Quadrat");
        }

        public virtual double BerechenFlächeninhalt()
        {
            return a * a;
        }

        public override void Move(int x, int y)
        {
            base.x += x + 1;
            base.y += y + 1;
        }

        public override string ToString() 
        {
            return base.ToString() + $" Flächeninhalt: {BerechenFlächeninhalt()}";
        }
    }
}
