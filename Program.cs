// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140

/*
var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};

var acc1 = Maker();
var acc2 = Maker();

Console.WriteLine(acc1(25));
Console.WriteLine(acc1(25));
Console.WriteLine(acc1(25));
Console.WriteLine(acc2(20));
Console.WriteLine(acc2(20));
Console.WriteLine(acc2(20));


var somma = (int n) => { n++; Console.WriteLine(n); };
somma(10);
*/

//Data una lista di interi, metterli tutti al quadrato
Console.WriteLine("Numeri elevati al quadrato");

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> listSquare = CalcolaQuadrato(list);
foreach (int n in listSquare)
    Console.WriteLine(n);   


List<int> CalcolaQuadrato(List<int> list)
{
    List<int> nSquared = new List<int>();
    foreach (int n in list)
        nSquared.Add(n * n);
    return nSquared;
}

Console.WriteLine("----------------------");

Console.WriteLine("Numeri elevati al cubo");

List<int> listCube = CalcolaCubo(list);
foreach (int n in listCube)
    Console.WriteLine(n);


List<int> CalcolaCubo(List<int> list)
{
    List<int> nCube = new List<int>();
    foreach (int n in list)
        nCube.Add(n * n * n);
    return nCube;
}

Console.WriteLine("----------------------");

List<int> listInt = EseguiCalcolo(list, (n) => n * (n + 1) / 2);
foreach (int n in listInt)
    Console.WriteLine(n);

List<int> EseguiCalcolo(List<int> list, Func<int, int> fun)
{
    List<int> num = new List<int>();
    foreach (int n in list)
        num.Add(n);
    return num;
}


//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "Sei"}
//ordinarla e stamparla in verso decrescente
Console.WriteLine("--------------------");

List<string> listString = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "sei" };
listString.Sort();
listString.Reverse();
foreach (string str in listString)
    Console.WriteLine(str);

Console.WriteLine("--------------------");

SortedSet<string> listSortedSet = new SortedSet<string>();
foreach (string str in listString)
    listSortedSet.Add(str);

foreach (string str in listSortedSet)
    Console.WriteLine(str);

Console.WriteLine("--------------------");

listString = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "sei" };

listString.Sort((string s1, string s2) => -s1.CompareTo(s2));
foreach (string str in listString)
    Console.WriteLine(str);

//Data una lista di coppie <strig, int>, stamparle ordinate rispetto
//alla stringa
List<Tuple<string, int>> listCoppie = new List<Tuple<string, int>>()
{
    new Tuple<string, int>("uno", 1),
    new Tuple<string, int>("due", 26),
    new Tuple<string, int>("otto", 83),
    new Tuple<string, int>("tredici", 139),
    new Tuple<string, int>("venti", 205),
    new Tuple<string, int>("quarantasei", 467),
};

listCoppie.Sort();
listCoppie.ForEach(x => Console.WriteLine(x));

Console.WriteLine("---------------------");

Console.WriteLine(String.Join("\n", listCoppie));
// Console.WriteLine(String.Join("\t", listCoppie));

Console.WriteLine("---------------------");

listCoppie.Sort((t1, t2) => t1.Item2.CompareTo(t2.Item2));
Console.WriteLine(String.Join("\n", listCoppie));

Console.WriteLine("---------------------");

listCoppie.Sort();
listCoppie.Sort((t1, t2) => t1.Item2 - t2.Item2);
Console.WriteLine(String.Join("\n", listCoppie));

List<Tuple<int, int, int>> listTerne = new List<Tuple<int, int, int>>()
{
    new Tuple<int, int, int>(1, 2, 3),
    new Tuple<int, int, int>(5, 5, 2),
    new Tuple<int, int, int>(2, 4, 11),
    new Tuple<int, int, int>(12, 15, 21),
    new Tuple<int, int, int>(55, 45, 32),
    new Tuple<int, int, int>(1, 2, 4),
    new Tuple<int, int, int>(1, 3, 0),
    new Tuple<int, int, int>(5, 5, 1),
};

listTerne.Sort();
Console.WriteLine(String.Join("\n", listTerne));

// Per verificare la velocità di una parte del codice.
/*
double Microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
Console.WriteLine("Microseconds: {0}", Microseconds);
*/