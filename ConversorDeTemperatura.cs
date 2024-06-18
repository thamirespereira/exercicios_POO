using System.Security.Cryptography.X509Certificates;

namespace exercicios_POO
{
    public class ConversorDeTemperatura
    {
        public double Temperatura { get; set; }
        public double Resultado { get; set; }
        public const double Fator = 32;
        public const double Fator2 = 1.8; 
        public char Opcao { get; set; }

        public ConversorDeTemperatura(double temperatura, double resultado, char opcao)
        {
            Temperatura = temperatura;
            Resultado = resultado;
            Opcao = opcao;
        }

        public void EscolheTemperatura(){

            Console.WriteLine("Escola a temperatura que você deseja converter: (C = Celsius, F = Fahrenheit)");
            Opcao = char.Parse(Console.ReadLine());

            switch (Opcao)
            {
                case 'c':
                    Console.WriteLine("Você escolheu Celsius para Fahrenheit");
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    Temperatura = double.Parse(Console.ReadLine());
                    CelsiusParaFahrenheit();
                    break;

                case 'f':
                    Console.WriteLine("Você escolheu Fahrenheit para Celsius");
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    Temperatura = double.Parse(Console.ReadLine());
                    FahrenheitParaCelsius();
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                break;
            }
    }

    public void CelsiusParaFahrenheit()
        {
            Resultado = (Temperatura * Fator2) + Fator;
            Console.WriteLine("A temperatura em Fahrenheit é: " + Resultado);
        }

    public void FahrenheitParaCelsius()
    {
        Resultado = (Temperatura - Fator) / Fator2;
        Console.WriteLine("A temperatura em Celsius é: " + Resultado);
    }
}
}