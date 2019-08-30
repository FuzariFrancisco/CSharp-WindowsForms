using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("SELECIONE UM JOGO ");
                Console.WriteLine("1 - Adivinhar número ");
                Console.WriteLine("2 - Par ou Ímpar ");
                Console.WriteLine("3 - Sair "); opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        {
                            
                                Console.Clear();
                                Jogo_Sorteio();
                                Console.WriteLine();
                                Jogo_Sorteio();
                                Console.WriteLine();
                                Jogo_Sorteio();
                                Console.WriteLine();
                                Console.ReadKey();

                           
                            break;

                        }

                    case 2:
                        {
                            
                                Console.Clear();
                                Jogo_Par_Impar();
                                Console.WriteLine();
                                Jogo_Par_Impar();
                                Console.WriteLine();
                                Jogo_Par_Impar();
                                Console.WriteLine();
                                Console.ReadKey();
                            break;
                        }

                }

            } while (opcao != 3);

           

           

        }

        static void Jogo_Sorteio()
        {
            //VARIÁVEL QUE O USUÁRIO DIGITA
            int num_usuario;

            //COMANDOS QUE GERAM UM NÚMERO ALEATÓRIO DE 1 Á 10
            Random random = new Random();
            int num_aleatorio = random.Next(0, 10);

            //ESCREVE NA TELA PEDINDO PARA O USUÁRIO UM NÚMERO E LÊ ELE
            Console.WriteLine("Digite um número de 0 á 10 "); num_usuario = Convert.ToInt32(Console.ReadLine());

            //FAZ A COMPARAÇÃO PARA VER SE É IGUAL Á O NÚEMRO SORTEADO OU NÃO
            if (num_usuario == num_aleatorio)
            {
                Console.WriteLine("Parabéns você ganhou! ");
            }
            else
            {
                Console.WriteLine("Você perdeu... ");
            }

  
        }

        static void Jogo_Par_Impar()
        {
            //VARIÁVEL QUE O USUÁRIO DIGITA
            int num_usuario, total;
            string opcao, resultado;

            //COMANDOS QUE GERAM UM NÚMERO ALEATÓRIO DE 1 Á 10
            Random random = new Random();
            int num_aleatorio = random.Next(0, 10);

            //PEDE PARA O USUÁRIO SELECIONAR UMA DAS OPÇÕES
            Console.WriteLine("Escolha PAR(P) ou ÍMPAR(I) "); opcao = Console.ReadLine();

            //PEDE PARA O USUÁRIO INFORMAR UM NÚMERO DE 0 Á 10
            Console.WriteLine("Informe um número de 0 á 10 "); num_usuario = Convert.ToInt32(Console.ReadLine());

            total = num_usuario + num_aleatorio;

            if(total % 2 == 0)
            {
                Console.WriteLine("O número é par ");
                resultado = "P";
            }
            else
            {
                Console.WriteLine("O número é ímpar");
                resultado = "I";
            }

            Console.WriteLine("A soma dos dois números é: " + total);

            if (resultado == opcao)
            {
                Console.WriteLine("Você ganhou!");
            }
            else
            {
                Console.WriteLine("Você perdeu...");
            }
        }
    }
}
