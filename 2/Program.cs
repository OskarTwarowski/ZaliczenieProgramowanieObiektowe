using Zad_2;

// Program wypisujący nasze długości papieru
Prostokat prostokat = Prostokat.ArkuszPapieru("A1"); 
Console.WriteLine($"Długość boku A(wysokość): {prostokat.BokA} mm");
Console.WriteLine($"Długość boku B(szerokość): {prostokat.BokB} mm");
Console.WriteLine($"Wymiary: {prostokat.BokB}x{prostokat.BokA} mm");

