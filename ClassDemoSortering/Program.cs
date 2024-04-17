// See https://aka.ms/new-console-template for more information
using ClassDemoSortering;
/*
Console.WriteLine("Hello, World!");

MinEnum mn = new MinEnum();
mn.IsType = IsTyper.VanillieÍs;


Console.WriteLine(mn);
Console.WriteLine((int)mn.IsType);

mn.IsType = (IsTyper)2;
Console.WriteLine(mn);

mn.IsType = Enum.Parse<IsTyper>("ChokoladeIs");
Console.WriteLine(mn);

*/



DimseRepository repo = new DimseRepository();

UdskrivDimser(repo.SomDenEr(), "Som den er");
UdskrivDimser(repo.SortDefault(), "Default");
UdskrivDimser(repo.SomDenEr(), "Som den er");
UdskrivDimser(repo.SortComparer(), "Comparer");
UdskrivDimser(repo.SomDenEr(), "Som den er");
UdskrivDimser(repo.SortLinq(), "Linq");
UdskrivDimser(repo.SomDenEr(), "Som den er");



static void UdskrivDimser(List<Dims> dimser, string ledeTekst)
{
    Console.WriteLine();
    Console.WriteLine(ledeTekst);
    Console.WriteLine();
    foreach (Dims d in dimser)
    {
        Console.WriteLine(d);
    }
    Console.WriteLine();
}

