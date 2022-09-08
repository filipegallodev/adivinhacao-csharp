using JogoAdivinhacao;

Console.WriteLine("Bem-vindo ao jogo da Adivinhação!");

while (true) 
{
    Console.WriteLine("\nTente adivinhar o número aleatório entre 0 à 10:");

    Numeros num = new Numeros(10);
    num.GerarNumero();

    num.EscolherNumero();

    num.VerificarNumero();
}

