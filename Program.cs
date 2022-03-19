String fraseD, frasememe;

Console.Write("Usuário, o que você pensa sobre mim? ");
fraseD = Console.ReadLine()!;

frasememe = $"{fraseD.Remove(10)}... NÃO, PERA.\nTô nervoso";


Console.WriteLine(frasememe);