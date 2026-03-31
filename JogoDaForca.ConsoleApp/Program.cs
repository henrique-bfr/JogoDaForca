string palavraSecreta = "ABACATE";

char[] letrasCorretas = new char[7];

for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

int contadorErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

while (!jogadorAcertou && !jogadorPerdeu)
{
    Console.Clear();
    Console.WriteLine("Jogo da forca");
    Console.WriteLine("Erros cometidos: " + contadorErros + " erros.");
    Console.Write("Chutes: ");

    for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }

    Console.Write("\nDigite uma letra: ");
    char chute = Convert.ToChar(Console.ReadLine());

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

    if(contadorErros > 5)
    {
        jogadorPerdeu = true;
        Console.WriteLine("Você perdeu, a palavra era: " + palavraSecreta);
    }
}

Console.WriteLine("Digite ENTER para sair...");
Console.ReadLine();