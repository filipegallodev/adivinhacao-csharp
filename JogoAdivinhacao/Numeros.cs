namespace JogoAdivinhacao
{
    public class Numeros
    {
        public Numeros(int numeroDistancia)
        {
           NumeroDistancia = numeroDistancia;
        }

        public int NumeroAleatorio { get; set; }
        public int NumeroEscolhido { get; set; }
        public int NumeroDistancia { get; set; }

        public void GerarNumero()
        {
            Random rnd = new();
            NumeroAleatorio = rnd.Next(10);
        }

        public void EscolherNumero()
        {
            int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
        }

        public void VerificarNumero()
        {
            if (NumeroEscolhido == NumeroAleatorio)
            {
                Console.WriteLine($"Parabéns!! Você acertou em cheio!");
            }
            else
            {
                Console.WriteLine($"Não foi dessa vez... o número aleatório era {NumeroAleatorio}!");
            }
        }
    }
}
