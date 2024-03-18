using System;

namespace Ex20
{
    internal class Conta
    {
        public int NumeroDaConta;
        public string Nome;
        public double Saldo;

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Retirar(double valor)
        {
            Saldo -= valor;
        }
    }
}
