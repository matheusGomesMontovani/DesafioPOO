using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphones
string nome = Console.ReadLine();
string numero = Console.ReadLine();
string modelo  = Console.ReadLine();
string imei  = Console.ReadLine();
int memoria = int.Parse(Console.ReadLine());

Nokia nokia = new Nokia(nome, numero, modelo, imei, memoria);

Console.WriteLine($"{nokia.Numero}, {nokia.Modelo}, {nokia.Imei}, {nokia.Memoria}");
Console.WriteLine($"{nokia.Ligar}");
Console.WriteLine($"{nokia.ReceberLigacao}");
Console.WriteLine($"{nokia.InstalarAplicativo}");

string nome2 = Console.ReadLine();
string numero2 = Console.ReadLine();
string modelo2 = Console.ReadLine();
string imei2 = Console.ReadLine();
int memoria2 = int.Parse(Console.ReadLine());

Iphone iphone = new Iphone(nome2, numero, modelo, imei, memoria);

Console.WriteLine($"{iphone.Numero}, {iphone.Modelo}, {iphone.Imei}, {iphone.Memoria}");
Console.WriteLine($"{iphone.Ligar}");
Console.WriteLine($"{iphone.ReceberLigacao}");
Console.WriteLine($"{iphone.InstalarAplicativo}");