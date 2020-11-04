using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Funcoes_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Hoje a noite, sem luz, decidi xeretar a quinta gaveta de vovô: achei linguiça, pão e fubá";

            string frase_trocada = frase.Replace("VOVô", "mamãe"); //Replace() pode substituir cadeias de caracteres ou caracteres únicos.

            WriteLine(frase_trocada);

            //WriteLine(frase.ToUpper()); //ToUpper() deixa todas as letras em MAIÚSCULAS
            //WriteLine(frase.ToLower()); //ToLower() deixa todas as letras em minúsculas

            //string subFrase = "achei";

            //int posicaoInicial = frase.IndexOf(subFrase); //IndexOf() A pesquisa é iniciada em uma posição de caractere especificada e examina um número especificado de posições de caracteres.
            //int posicaoFinal = 10;

            //string sub = frase.Substring(posicaoInicial);

            //WriteLine(sub);

            //var achou = frase.Contains(subFrase); //Contains() Retorna um valor que indica se uma subcadeia especificada ocorre nesta cadeia de caracteres.

            //WriteLine(achou);

            //WriteLine(frase.Length); //Contar quantos caracteres

            //string[] partes = frase.Split(',');

            //for(var i = 0; i < partes.Length; i++)
            //{
            //    WriteLine(partes[i].Trim()); //Trim() Remove todos os caracteres de espaço em branco à esquerda e à direita da cadeia de caracteres atual.
            //}

            ReadLine();
        }
    }
}
