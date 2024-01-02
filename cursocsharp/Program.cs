using cursocsharp.fundamentos;

Console.WriteLine("Hello, World!");
var variable = new Variable();
Variable.Test();
variable.Age();
var nome = variable.Name("Felipe Virissimo Dos Santos");
Console.WriteLine(nome);
const int age = int.MaxValue;
Console.WriteLine(age);

Console.WriteLine("Qual seu nome?");

var name = Console.ReadLine();

Console.WriteLine($"Feliz 2024 {name}");

const double value = 15.157;
Console.WriteLine(value.ToString("F2"));
Console.WriteLine(value.ToString("C"));
Console.WriteLine(value.ToString("P"));