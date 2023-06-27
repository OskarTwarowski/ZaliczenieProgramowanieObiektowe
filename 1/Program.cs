using Zad_1;

Osoba osoba = new("Oskar Twarowski")
{
    DataUrodzenia = new DateTime(2001, 8, 16),
    DataŚmierci = new DateTime(2023, 6, 10)
};
Console.WriteLine("Zadanie 1 \n");
Console.WriteLine($"imię: {osoba.Imię}, ");
Console.WriteLine($"nazwisko: {osoba.nazwisko}, ");
Console.WriteLine($"Imię i nazwisko: {osoba.ImięNazwisko}, ");
Console.WriteLine($"Data urodzenia: {osoba.DataUrodzenia}, ");
Console.WriteLine($"Data śmierci: {osoba.DataŚmierci},  ");
Console.WriteLine($"wiek: {osoba.Wiek.Value.Days / 365} lat ");
Console.WriteLine($"wiek w dniach: {osoba.Wiek.Value.Days} dni \n\n");

Console.WriteLine("Wyjątki właściwości Imię:");
osoba.Imię = "null";  //jeśli zostawimy samo null wyrzuci nam błąd ArgumentNullException ponieważ value == null 
Console.WriteLine(osoba.Imię);