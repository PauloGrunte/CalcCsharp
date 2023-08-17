Console.WriteLine("Calculadora C#");
Console.WriteLine("Digite o primeiro numero:");
string inpt1 = Console.ReadLine();
double n1;
bool isNumber = double.TryParse(inpt1, out n1);
while (isNumber == false)
{
    Console.WriteLine("Valor inválido");
    Console.WriteLine("Digite o primeiro numero:");
    inpt1 = Console.ReadLine();
    isNumber = double.TryParse(inpt1, out n1);
}
Console.WriteLine("Digite o segundo numero:");
string inpt2 = Console.ReadLine();
double n2;
bool isNumber2 = double.TryParse(inpt2, out n2);
while (isNumber2 == false)
{
    Console.WriteLine("Valor inválido");
    Console.WriteLine("Digite o segundo numero:");
    inpt2 = Console.ReadLine();
    isNumber2 = double.TryParse(inpt2, out n2);
}
Console.WriteLine("Digite a operação ");
Console.WriteLine("1 ou +");
Console.WriteLine("2 ou -");
Console.WriteLine("3 ou /");
Console.WriteLine("4 ou *");
Console.WriteLine("5 ou %");
string operador = Console.ReadLine();
switch (operador)
{
    case "1":
    case "+":
        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        break;
    case "2":
    case "-":
        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        break;
    case "3":
    case "/":
        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        break;
    case "4":
    case "*":
        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
        break;
    case "5":
    case "%":
        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
        break;
    default:
        Console.WriteLine("Operador inválido");
        break;
}
