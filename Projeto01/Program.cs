using System;
using Projeto01.Entities; //importando

namespace Projeto01
{
    //classe inicial
    class Program
    {
        //método de execução do projeto
        static void Main(string[] args)
        {


            Cliente cliente = new Cliente();
            //criando um objeto para a Classe Cliente


            //realizando a captura do id do cliente

            try //tentativa
            {
                Console.Write("Informe o id do cliente......:");
                cliente.Id = int.Parse(Console.ReadLine());

                //realizando a captura do nome do cliente
                Console.Write("Informe o Nome do cliente.........: ");
                cliente.Nome = Console.ReadLine();
                //realizando a captura do cpf do cliente
                Console.Write("Informe o CPF do cliente..........: ");
                cliente.Cpf = Console.ReadLine();
                //realizando a captura do cpf do cliente
                Console.Write("Informe o Email do cliente........: ");
                cliente.Email = Console.ReadLine();

                Console.WriteLine("\nObrigado por participar!");
                Console.WriteLine("\nLegal né Pai?:3 ");
            }
            catch (Exception e) //captura de exceção
            {


                Console.WriteLine("\nOcorreu um erro!: " + e.Message);

                //verificar se o usuário deseja repetir o processo
                Console.WriteLine("\nDeseja tentar novamente? (S,N)..: ");
                //capturar o valor digitado
                var opcao = Console.ReadLine();

                if (opcao.ToUpper().Equals("S"))
                {

                    //limpar o console
                    Console.Clear();
                    //recursividade
                    Main(args);

                }
                else
                {

                    Console.WriteLine("\nFim do Programa");

                }
            }


            //pausar o prompt do DOS 
            Console.ReadKey();

        }
    }
}