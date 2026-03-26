string palavraSecreta = "ABACATE";

bool jogadorAcertou = false;

while (!jogadorAcertou)
{
    Console.Clear();
    Console.WriteLine("Jogo da Forca");
    Console.Write("Digite uma letra: ");
    char letra = Convert.ToChar(Console.ReadLine());

    Console.WriteLine(letra);
    Console.ReadLine();
}

