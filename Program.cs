// See https://aka.ms/new-console-template for more information
using exercicios_POO;

MediaEscolar media = new MediaEscolar(0d, 0d);
ConversorDeTemperatura temperatura = new ConversorDeTemperatura(0d, 0d, ' ');
JogoDeAdivinhacao jogo = new JogoDeAdivinhacao (0,0,0);

Console.WriteLine("Exercicío 1 - Média Escolar");
media.CalcularMedia();
Console.WriteLine("----------------------------------------");
Console.WriteLine("Exercicío 2 - Conversor de Temperatura");
temperatura.EscolheTemperatura();
Console.WriteLine("----------------------------------------");
Console.WriteLine("Exercicío 3 - Jogo de Adivinhação");
jogo.Jogar();