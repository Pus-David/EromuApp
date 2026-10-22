using EromuApp;

List<Eromu> eromuvek = new List<Eromu>();
int hibasSorokSzama = 0;
string[] eromu;
string[] szelgenerator;

foreach(var sor in File.ReadAllLines("eromuvek.txt").Skip(1))
{
    string [] adatok = sor.Split("|");
    if (adatok.Length != 4)
    {
        hibasSorokSzama++;
        continue;
    }
    if (adatok[0] != "S" || adatok[0] !="Z")
    {
        hibasSorokSzama++;
        continue;
    }
    if (int.TryParse(adatok[2]))
    {

    }
    if (adatok[0] == "S")
    {
        eromu.Append(adatok);
    }
    else
    {
        szelgenerator.Append(adatok);
    }
    eromuvek.Add(adatok);
}

Console.WriteLine("Kiszűrt hibás sorok száma: "+hibasSorokSzama+" db");
Console.WriteLine("Sikeresen beolvasott erőművek: 4 db");
foreach(eromuvek)
{
    Sum(e =>
    e.NapiTermeles(12))
}
