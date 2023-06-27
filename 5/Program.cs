using Zad_5;

Macierz<int> m1 = new Macierz<int>(2, 2);
m1[0, 0] = 0;
m1[0, 1] = 3;
m1[1, 0] = 5;
m1[1, 1] = 6;

Macierz<int> m2 = new Macierz<int>(2, 2);
m2[0, 0] = 0;
m2[0, 1] = 3;
m2[1, 0] = 5;
m2[1, 1] = 6;

Macierz<int> m3 = new Macierz<int>(2, 2);
m3[0, 0] = 2;
m3[0, 1] = 1;
m3[1, 0] = 1;
m3[1, 1] = 2;
Macierz<int> m4 = new Macierz<int>(2, 2);
m4[0, 0] = 3;
m4[0, 1] = 4;
m4[1, 0] = 5;
m4[1, 1] = 6;


Console.WriteLine($"Czy Macierz M1 jest taka sama jak macierz M2 : \n {(m1 == m2)} \n"  );
Console.WriteLine($"Czy Macierz M1 jest taka sama jak macierz M3 : \n{(m1 == m3)}\n");
Console.WriteLine($"Czy Macierz M1 jest taka sama jak macierz M4 : \n{(m1 == m4)}\n");
Console.WriteLine($"Czy Macierz M1 różni się od macierzy M3 : \n{(m1 != m3)}\n");
Console.WriteLine($"Czy Macierz M2 różni się od macierzy M3 : \n{(m2 != m3)}\n");
Console.WriteLine($"Czy Macierz M2 jest taka sama jak macierz M3 : \n{(m2 == m3)}\n");
Console.WriteLine($"Czy Macierz M1 jest taka sama jak macierz M4 : \n{(m1 == m4)}\n\n\n");
Console.WriteLine($"Czy Macierz M1 jest taka sama jak macierz M1 : \n{(m1 == m1)}");  //wyjątek porównanie tej samej macierzy

