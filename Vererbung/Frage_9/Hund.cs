namespace Vererbung.Frage_9
{
    internal class Hund : Säugetier
    {
        public override void Sprich()
        {
            Console.WriteLine($"{this.GetType().Name} macht Woof wooof Geräusche");
        }
    }
}
