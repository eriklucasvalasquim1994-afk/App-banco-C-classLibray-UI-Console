using System;

namespace BancoClassLibrary
{
    public class Titular
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }    //Essas linhas definem propriedades automáticas, forma padrão de criar campos que armazenam dados num objeto, como dados pessoais de um cliente ou titular de conta.
        public string Endereco { get; set; }
    }

    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string NomeConta { get; set; }
        public string TitularNome { get; set; }   //O mesmo conceito de aplicar propriedades de classe.
        public decimal Saldo { get; private set; }
        public Titular Titular { get; set; }

        public Conta() { }

        public Conta(string titularNome, decimal saldoInicial)
        {
            TitularNome = titularNome;         //COnstrutor de classe, aqui é um método executado automaticamente semppre que uma nova instancia for criado.
            Saldo = saldoInicial;
        }
        public void VerSaldoDisponivel()
        {
            Console.WriteLine($"Saldo disponível: {Saldo:C}"); //Mstra o saldo atual da conta na consola (terminal) para o utilizador.
        }


        public decimal VerSaldo() //Parte do código define um método na sua classe, cujo objetivo é retornar o valor atual do saldo.
        {
            return Saldo;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor deve ser maior que 0."); //define o método responsável por realizar a operação de depósito na classe

            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= 0) return false;
            if (valor > Saldo) return false; //Define o método responsável pela operação de saque

            Saldo -= valor;
            return true;
        }

    }
}
