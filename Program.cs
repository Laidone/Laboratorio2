using System;

namespace Laboratorio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte b;
            b = byte.MaxValue;
            Console.WriteLine("Valor maximo de byte: " + b);// ele coloca na tela o maior valor que uma variável do tipo byte pode ter que no caso é 255
            int i;
            i = int.MaxValue; // ele coloca na tela o maior valor que uma variável do tipo inteiro assinado  de 32 bits pode ter que no caso é 2147483647
            long l;
            l = long.MaxValue;
            Console.WriteLine("Valor maximo de long: " + l);// ele coloca na tela o maior valor que uma variável do tipo inteiro assinado  de 64 bits pode ter que no caso é 9223372036854775807

            /* Questão 1
            decimal de = 10/3.0m;
            float f = 10/3.0f;
            double d = 10/3.0;
            Console.WriteLine("Decimal: " + de);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Double: " + d);
            */





            /*

          Questão 2 (Para essa questão, fiz mais de um exemplo)

             Exemplo 1

             string frase_Um;
             string frase_Dois;
             Console.WriteLine("Digite a primeira palavra ");
             frase_Um = Console.ReadLine();
             Console.WriteLine("Digite a segunda palavra ");
             frase_Dois = Console.ReadLine();
             if (Equals(frase_Dois, frase_Um))
            {
                Console.WriteLine("As palavras são iguais");
            }
              else
            {
                Console.WriteLine("As palavras são diferentes");
            }

           
            Exemplo 2

            
            string frase_Um;
            string palavra;
            Console.WriteLine("Digite a primeira palavra ");
            frase_Um = Console.ReadLine();
            Console.WriteLine("Digite a letra que você quer encontrar da palavra digitada");
            palavra = Console.ReadLine();
            int index = frase_Um.IndexOf(palavra);
            Console.WriteLine("A letra digitada está no index " + index);
            
             */


            /*
             Questão 3

                DateTime tempolocal = DateTime.Now;
                Console.WriteLine(tempolocal);
                Console.WriteLine("Hora do tempo local " + tempolocal.Hour);
                Console.WriteLine("Minutos do tempo local " + tempolocal.Minute);
                Console.WriteLine("Segundos do tempo local " + tempolocal.Second);
                //adicionando 1 hora no tmepo local
                tempolocal = DateTime.Now.AddHours(1.0);
                Console.WriteLine(tempolocal);
            
             */

            /*
            
            Questão 4
             
            int i = 10;
            float f = 0;
            f = i; //conversão implícita, sem perda de dados. 
            System.Console.WriteLine(f);
            f = 0.5F;
            i = (int)f; //conversão explícita, com perda de dados. 
            System.Console.WriteLine(i);

            O resultado do output é 10 e 0
            Explicação: o float é capaz de armazenar dados do tipo inteiro, por isso temos o resultado 10.
            O segundo resultado foi 0 pois quando fazemos (int)f, ele só vai adquirir a parte inteira (lembrar que ele não faz uma aproximação como em Math.round)
           
             */

            /*string numero = "4444444444444444444";
            Int64 valorstring64 = Convert.ToInt64(numero);
            Console.WriteLine("Valor em 64 bits " + valorstring64);
            int valorStringint = Convert.ToInt32(numero);
            Console.WriteLine("Valor em 32 bits " + valorStringint); // Valor muito grande 

            */

            /*
             Questão 5

                Abaixo um pequeno exemplo explicando como é feito a converção de string para inteiro e um erro de overflow

              string numero = "4444444444444444444";
              Int64 valorstring64 = Convert.ToInt64(numero);
              Console.WriteLine("Valor em 64 bits " + valorstring64);
              int valorStringint = Convert.ToInt32(numero);
              Console.WriteLine("Valor em 32 bits " + valorStringint); // Valor muito grande, por isso o programa vai gerar uma exceção sem tratamento
             
             */


            /*
            Questão 6 
            
            string s;
            Console.WriteLine("Digite o um número");
            s = Console.ReadLine();
            int i;
            bool condicao;
            condicao = int.TryParse(s, out i);
            if (condicao == false)
            {
                Console.WriteLine("Número muito grande para 32 bits");
            }
            else
            {
                Console.WriteLine("Número cabe em 32 bits");
            }
             
             */

            /*
            
            Questão 7

            double valorFracionado = 4.7;  
            int valorInteiro1 = (int) valorFracionado; // Nesse caso, quando fazemos (int), apenas "pegamos" a parte inteira da expressão (o que está antes da vírgula)
            int valorInteiro2 = Convert.ToInt32(valorFracionado); // Nesse caso, ocorre uma aproximção para o inteiro mais próximo, que nesse caso é 5
            Console.WriteLine("Conversao explicita = " + valorInteiro1); 
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2); 

             */

            /*Questão 8
            
            Funciona como um jeito mais simples para o usuário printar uma informação na tela. Isso ajuda muito pois para textos grandes, não vai ser necessário usar os sinais de + no meio da frase.
            Exemplo:
            Ao invés de digitar
            Console.WriteLine("O primeiro número foi " +  x + "  e o segundo número foi " + y)
            Podemos digitar
            Console.WriteLine("O primeiro número foi {0} e o segundo número foi {1}", x, y)

             */


        }
    }
}