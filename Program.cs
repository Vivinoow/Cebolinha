string fraseDigitada, fraseComDislalia;

Console.Write("Digite uma flase: ");
fraseDigitada = Console.ReadLine()!;

fraseComDislalia = fraseDigitada
        .Replace("r", "1")
        .Replace("R", "L");

Console.WriteLine(fraseComDislalia);

