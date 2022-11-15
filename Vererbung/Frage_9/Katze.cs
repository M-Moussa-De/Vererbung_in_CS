namespace Vererbung.Frage_9
{
    internal class Katze : Säugetier
    {
        public override void Sprich()
        {
            Console.WriteLine($"{this.GetType().Name} macht mewwwo Geräusche");
        }
    }
}
