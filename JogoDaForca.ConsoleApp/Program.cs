using System.Security.Cryptography;

string[] palavras = [
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
];

int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

string palavraSecreta = palavras[indiceAleatorio];

char[] letrasCorretas = new char[palavraSecreta.Length];

for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

int contadorErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

while (true)
{
    Console.Clear();
    Console.WriteLine(" ____________________________");
    Console.WriteLine("|                            |");
    Console.WriteLine("|        Jogo da forca       |");
    Console.WriteLine("| Erros cometidos: " + contadorErros + " erros.  |");
    Console.Write("| Chutes: ");

    for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }

    //Perdão a gambi kkkk
    Console.Write("            |");

    if (contadorErros == 0)
    {
        Console.WriteLine();
        Console.WriteLine(@"|  ___________               |");
        Console.WriteLine(@"|  |/        |               |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"| _|____                     |");
        Console.WriteLine("|____________________________|");
    }
    else if (contadorErros == 1)
    {
        Console.WriteLine();
        Console.WriteLine(@"|  ___________               |");
        Console.WriteLine(@"|  |/        |               |");
        Console.WriteLine(@"|  |         o               |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"| _|____                     |");
        Console.WriteLine("|____________________________|");

    }
    else if (contadorErros == 2)
    {
        Console.WriteLine();
        Console.WriteLine(@"|  ___________               |");
        Console.WriteLine(@"|  |/        |               |");
        Console.WriteLine(@"|  |         o               |");
        Console.WriteLine(@"|  |         |               |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"| _|____                     |");
        Console.WriteLine("|____________________________|");

    }
    else if (contadorErros == 3)
    {
        Console.WriteLine();
        Console.WriteLine(@"|  ___________               |");
        Console.WriteLine(@"|  |/        |               |");
        Console.WriteLine(@"|  |         o               |");
        Console.WriteLine(@"|  |        /|               |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"| _|____                     |");
        Console.WriteLine("|____________________________|");

    }

    else if (contadorErros == 4)
    {
        Console.WriteLine();
        Console.WriteLine(@"|  ___________               |");
        Console.WriteLine(@"|  |/        |               |");
        Console.WriteLine(@"|  |         o               |");
        Console.WriteLine(@"|  |        /|\              |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"| _|____                     |");
        Console.WriteLine("|____________________________|");

    }

    else if (contadorErros == 5)
    {
        Console.WriteLine();
        Console.WriteLine(@"|  ___________               |");
        Console.WriteLine(@"|  |/        |               |");
        Console.WriteLine(@"|  |         o               |");
        Console.WriteLine(@"|  |        /|\              |");
        Console.WriteLine(@"|  |        / \              |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"| _|____                     |");
        Console.WriteLine("|____________________________|");
    }

    else if (contadorErros == 6)
    {
        Console.WriteLine();
        Console.WriteLine(@"|  ___________               |");
        Console.WriteLine(@"|  |/        |               |");
        Console.WriteLine(@"|  |         o               |");
        Console.WriteLine(@"|  |        /|\              |");
        Console.WriteLine(@"|  |        / \              |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"|  |                         |");
        Console.WriteLine(@"| _|____                     |");
        Console.WriteLine("|____________________________|");
    }

    if (jogadorAcertou)
    {
        Console.WriteLine(" ____________________________");
        Console.WriteLine("|                            |");
        Console.WriteLine($"| Parabéns, você acertou!    |");
        Console.WriteLine("|____________________________|");
        break;
    }
    else if (jogadorPerdeu)
    {
        Console.WriteLine(" _______________________________________________");
        Console.WriteLine("|                                               |");
        Console.WriteLine($"| Que pena, você errou! A palavra era: {palavraSecreta} |");
        Console.WriteLine("|_______________________________________________|");

        break;
    }

    Console.Write("\nDigite uma letra: ");
    char chute = Convert.ToChar(Console.ReadLine().ToUpper());

    bool letraFoiEncontrada = false;

    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraSecreta.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraSecreta[contadorPalavraSecreta];

        if (chute == letraSecretaAtual)
        {
            letrasCorretas[contadorPalavraSecreta] = chute;
            letraFoiEncontrada = true;
        }
    }

    if (!letraFoiEncontrada)
        contadorErros++;

    string letrasCorretasCompleta = string.Join("", letrasCorretas);

    if (palavraSecreta == letrasCorretasCompleta)
    {
        jogadorAcertou = true;
        Console.WriteLine($"Parabens você acertou! A palavra secreta era: {palavraSecreta}");
    }

    if (contadorErros > 5)
    {
        jogadorPerdeu = true;
        Console.WriteLine("Você perdeu, a palavra era: " + palavraSecreta);
    }
}

Console.WriteLine("Digite ENTER para sair...");
Console.ReadLine();