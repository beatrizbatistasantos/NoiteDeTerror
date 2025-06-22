int Dianiver, Mesniver;
Console.Clear();

string[] mes = {
    "O Zumbi",
    "O Assassino",
    "O Psicopata",
    "O Alienígena",
    "O Carniceiro",
    "O Matador",
    "O Vampiro",
    "O Maluco",
    "O Vingador",
    "O Monstro",
    "O Bruxo",
    "O Demônio"
};

string[] dia = {
    "Endiabrado",
    "Radioativo",
    "Endemoniado",
    "Vermelho",
    "Possuído",
    "Macabro",
    "Sombrio",
    "Sem Cabeça",
    "Desconhecido",
    "Inconsciente",
    "Oculto",
    "Esquecido",
    "Lúgubre",
    "Invocado",
    "Caído",
    "Costurado",
    "Amaldiçoado",
    "Anormal",
    "Perturbado",
    "Sanguinário",
    "Tenebroso",
    "Imortal",
    "Ressuscitado",
    "do Pântano",
    "da Encruzilhada",
    "do Porão",
    "do Velho Poço",
    "sem Perdão",
    "do Cemitério",
    "da Meia-Noite",
    "da Lua Cheia"
};

Console.WriteLine("== Olá, Seja Bem-vindo a Noite de Terror ==");
while (true)
{
    Console.WriteLine("Venha descobrir qual o monstro irá se tornar seu maior pesadelo!");
        Console.WriteLine("Para começar precisamos saber de alguns dados seus.");

        Thread.Sleep(1000);

        Console.WriteLine("Qual dia você nasceu?(1 a 31)");
        while (!int.TryParse(Console.ReadLine()!, out Dianiver) || Dianiver < 1 || Dianiver > 31)
        {
            Console.WriteLine("Por favor digite um dia válido. Entre 1 e 31");
        }

        Console.WriteLine("Qual mês você nasceu?(1 a 12)");
        while (!int.TryParse(Console.ReadLine()!, out Mesniver) || Mesniver < 1 || Mesniver > 12)
        {
            Console.WriteLine("Por favor digite um mês válido. Entre 1 e 12");
        }
        if (Mesniver == 10 && Dianiver == 24)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\nAhh, é um(a) escorpiano(a) de boas nascido no melhor dia do mundo, pode parar de correr!");
        Console.ResetColor();
        break;
    }

    else
    {
        Console.WriteLine("----- O Momento de terror começou -----");
        Console.WriteLine($"Fique esperto! {mes[Mesniver - 1]}{dia[Dianiver - 1]} está vindo te pegar!");
    }

}
        
