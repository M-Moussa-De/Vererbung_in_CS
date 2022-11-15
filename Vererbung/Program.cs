using Vererbung;
using Vererbung.Frage_9;

Punkt p = new Punkt(2, 3);
Quadrat q = new Quadrat(2, 3, 5);
Rechteck r = new Rechteck(2, 3, 5, 3);

Punkt[] arr = new Punkt[3];
arr[0] = p;
arr[1] = q;
arr[2] = r;

//foreach(Punkt item in arr)
//{
//  Console.WriteLine(item.ToString());
//}

//Console.WriteLine(r.BerechnenUmfang());

p.Move(5,6);
//Console.WriteLine(p);

q.Move(4,2);
//Console.WriteLine(q);

Kreis k = new Kreis(2, 3, 2.5);
//Console.WriteLine(k);

// ========================= Frage 9 =========================
Säugetier hund = new Hund();
Säugetier katze = new Katze();

Console.WriteLine("Geben Sie die Länge Ihres Arrays ein");
int len;

while(!int.TryParse(Console.ReadLine(), out len))
{
    Console.WriteLine("Geben Sie bitte ein Integer ein");
}

Säugetier[] tiere = new Säugetier[len];

int cnt = 0;

for(int i = 0; i < len; i++)
{
    Console.WriteLine($"Welches Tier möchten Sie zum Array hinzufügen? [{Tierart.Hund}, {Tierart.Katze}]");

    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim();
        input = char.ToUpper(input[0]) + input.Substring(1).ToLower();

        switch (input)
        {
            case "Hund":
                tiere[cnt] = new Hund();
                cnt++;
                break;

            case "Katze":
                tiere[cnt] = new Katze();
                cnt++;
                break;

            default:
                Console.WriteLine("Sorry, das von Ihnen gewünschte Tier haben wir momentan leider nicht");
                break;
        }

        if (cnt > len)
        {
            Console.WriteLine($"Ihr Array hat noch {len} frei Platz/Plätze");
        }

    }
    else
    {
        Console.WriteLine($"Welches Tier möchten Sie zum Array hinzufügen? [{Tierart.Hund}, {Tierart.Katze}]");
    }
}

foreach (Säugetier tier in tiere)
{
    tier.Sprich();
}