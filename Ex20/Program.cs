using System;
using System.Globalization;


namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.Write("Digite o número da conta: ");
            c.NumeroDaConta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o titular da conta: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o saldo da conta: ");
            c.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Digite o valor do depósito: ");
            double deposito = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine("Depósito realizado com sucesso!");
            Console.WriteLine();
            Console.Write("Digite o valor do saque: ");
            deposito = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Retirar(deposito);
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine();
            Console.Write("Saque realizado com sucesso! "+ c.Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
