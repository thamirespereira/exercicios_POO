using System.Xml;

namespace exercicios_POO
{
    public class MediaEscolar
    {
        public double Nota;
        public double Soma = 0;

        public MediaEscolar(double nota, double soma)
        {
            Nota = nota;
            Soma = soma;
        }

        public void CalcularMedia()
        {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Digite a nota do aluno: "); 
            Nota = double.Parse(Console.ReadLine());
            Soma += Nota;
        }

        double Media = Soma / 4;    

        if (Media >= 7)
        {
            Console.WriteLine("Aprovado com média: " + Media);
        }
        else if (Media < 5)
        {
            Console.WriteLine("Reprovado com média: " + Media);
        }
        else
        {
            Console.WriteLine("Recuperação com média: " + Media);
    }

        }
    }
}