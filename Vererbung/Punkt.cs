namespace Vererbung
{
    internal class Punkt
    {
        protected int x, y;

        public Punkt()
        {
            Console.WriteLine("Konstruktor von Punkt");
        }

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Konstruktor von Punkt");
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void Move()
        {
            ++x;
            ++y;
        }

        public virtual void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public override string ToString()
        {
            return $"x: {x} y: {y}";
        }
    }
}
