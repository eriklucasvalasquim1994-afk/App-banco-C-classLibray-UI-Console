using System;
using BancoClassLibrary;
using Titular = BancoClassLibrary.Titular;

namespace BancoUI
{
    public class Program //Aqui defini a classe do sistema, no caso aqui é um programa.
    {
        public static void Main(string[] args) // Ponto de entrada de um programa C#; é a primeira função que é executada quando o seu aplicativo inicia.
        {
            // Criação da conta
            Console.Write("Digite o saldo inicial: ");
            decimal saldoInicial = decimal.Parse(Console.ReadLine());

            var conta = new Conta("Conta Teste", saldoInicial); //Declaração da variável conta, para que o c# descubra automaticamente que o tipo dessa variável será conta.
            conta.Agencia = 1;
            conta.NumeroConta = 1000;

            conta.Titular = new Titular()
            {
                Cpf = "065321655498",    //Dados do usuário como CPF,Rg e endereço
                Rg = "8954566",
                Endereco = "Rua Centro"
            };

            bool rodando = true;

            while (rodando)
            {
                Console.Clear();
                Console.WriteLine($"=== Conta: {conta.NomeConta} ===");  //Mostra o número da conta
                Console.WriteLine($"Titular: {conta.Titular.Cpf}");     //Mostra o CPF do usuário
                Console.WriteLine($"Saldo atual: {conta.VerSaldo():C}"); //Aqui você tem acesso ao saldo disponível na sua conta.
                Console.WriteLine("\nEscolha uma opção:"); //Aqui você escolhe qual opção você vai selecionar no menu de escolhas 
                Console.WriteLine("1 - Depositar"); //Opção aonde você pode depositar dinheiro na sua conta 
                Console.WriteLine("2 - Sacar"); //Aqui você sacar um valor pré determinado
                Console.WriteLine("3 - Ver Saldo disponível"); //Aqui você vê o seu saldo disponível 
                Console.WriteLine("4 - Sair"); //Aqui você opta por sair do aplicativo.

                Console.Write("Opção: ");
                string opcao = Console.ReadLine(); //Par de linhas permite que o seu programa receba um comando do utilizador

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o valor para depositar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito)) //Responsável por interagir com o utilizador, ler a entrada dele, e validar se o que foi digitado pode ser convertido num valor numérico válido para um depósito.
                        {
                            conta.Depositar(valorDeposito);
                            Console.WriteLine($"Depósito de {valorDeposito:C} realizado!"); //Demonstra a execução de um método e a exibição do resultado para o utilizador, utilizando os dados validados na etapa anterior.
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!"); //Aqui se a operação for inválida ela define que a opração será abortada.
                        }
                        break;

                    case "2":
                        Console.Write("Digite o valor para sacar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque)) //Exibe a mensagem "digite o valor para sacar", no terminal instruindo o usuário sobre o que deve fazer.
                        {
                            if (conta.Sacar(valorSaque))
                                Console.WriteLine($"Saque de {valorSaque:C} realizado!"); //Chamar o método Sacar no seu objeto conta, passando o valor que o utilizador digitou (valorSaque) como argumento.
                            else
                                Console.WriteLine("Saque não permitido: saldo insuficiente ou valor inválido."); //Essa linha de código é uma mensagem de erro ou aviso que informa o utilizador que a operação que ele tentou fazer não foi bem-sucedida.

                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!"); //Aqui define que o valor solicitado para saque é inválido.
                        }
                        break;

                    case "3":
                        conta.VerSaldoDisponivel(); // chama o método void ou imprime usando decimal
                        break;

                    case "4":
                        rodando = false;
                        Console.WriteLine("Saindo do sistema..."); //Aqui você teclando a tecla esc você pode sair do sistema. 
                        break;

                    default:
                        Console.WriteLine("Opção inválida!"); //Ocorre quando você seleciona uma opção inválida ou quando você tenta sacar um valor indisponível no saldo.
                        break;
                }

                if (rodando)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar..."); //Nesse opção aqui você aperta qualquer tecla para dar seguimento as operações que você deseja realizar.
                    Console.ReadKey();
                }
            }
        }
    }
}
