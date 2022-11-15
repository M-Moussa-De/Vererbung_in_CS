namespace Vererbung.Frage_9
{
    public enum Tierart { Hund = 1, Katze}

    internal class Säugetier
    {
        public virtual void Sprich()
        {
            Console.WriteLine("Säugetier macht Geräusche");
        }

    }
}
