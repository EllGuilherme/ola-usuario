string nome;

Console.WriteLine("digite seu nome: ");
nome = Console.ReadLine()!;

Console.ForegroundColor=ConsoleColor.Blue;
Console.WriteLine($"olá, {nome}"!);
Console.ResetColor();
