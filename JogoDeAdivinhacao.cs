namespace exercicios_POO
{
    public class JogoDeAdivinhacao
    {
        Random random = new Random();
        public int NumeroAleatorio;
        public int Tentativa {get; set;} = 0;
        public int Numero {get; set;}

        public JogoDeAdivinhacao(int numeroAleatorio, int tentativa, int numero)
        {
            NumeroAleatorio = numeroAleatorio;
            Tentativa = tentativa;
            Numero = numero;
        }

        public void Jogar()
        {
            NumeroAleatorio = random.Next(1, 11);
            Console.WriteLine("Adivinhe o número.");

            while (Tentativa < 3)
            {
                Console.WriteLine("Qual o seu palpite? ");
                Numero = Convert.ToInt32(Console.ReadLine());
                Tentativa ++;

                if(Numero == NumeroAleatorio){
                    Console.WriteLine("Parabéns você acertou! O número é " + NumeroAleatorio);
                    break;
                }
                else if(Numero > NumeroAleatorio)
                {
                    Console.WriteLine("Seu palpite é maior que o número. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Seu palpite é menor que o número. Tente novamente.");
                }
            }

            if(Tentativa == 3 && Numero != NumeroAleatorio)
            {
                Console.WriteLine("Você não acertou, o número era " + NumeroAleatorio);
            }
        }
    }
}