string palavraSecreta = "ABACATE";

char[] letrasCorretas = new char[7];

for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

bool jogadorAcertou = false;

while (!jogadorAcertou)
{
    //Console.Clear();

    for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }

    Console.Write("\nDigite uma letra: ");
    char chute = Convert.ToChar(Console.ReadLine());

    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraSecreta.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraSecreta[contadorPalavraSecreta];

        if (chute == letraSecretaAtual)
        {
            letrasCorretas[contadorPalavraSecreta] = chute;
        }
    }

    string letrasCorretasCompleta = string.Join("", letrasCorretas);

    if (palavraSecreta == letrasCorretasCompleta)
    {
        jogadorAcertou = true;
        Console.WriteLine($"Parabens você acertou! A palavra secreta era: {palavraSecreta}");
    }

}

Console.WriteLine("Digite ENTER para sair...");
Console.ReadLine();