﻿Console.WriteLine("Vítejte v kalkulačce");
Console.WriteLine("Zadejte první číslo:");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Zadejte druhé číslo:");
float b = float.Parse(Console.ReadLine());
float soucet = a + b;
float rozdil = a - b;
float soucin = a * b;
float podil = a / b;
Console.WriteLine("Součet: " + soucet);
Console.WriteLine("Rozdil: " + rozdil);
Console.WriteLine("Soucin: " + soucin);
Console.WriteLine("Podíl: " + podil);
Console.WriteLine("Děkuji za použití kalkulačky.");
Console.ReadKey();