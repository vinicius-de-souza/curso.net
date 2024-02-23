using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        // atributos privados
        private double Saldo;
        private short NumeroConta;
        // propriedades autoimplementadas
        public string _nome { get; private set; }
        // construtores
        public Conta (string nome, short numeroConta)
        {
            _nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta(string nome, short numeroConta, double saldo)
        {
            _nome = nome;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        // propriedades customizadas

        // metodos gerais

        public void AdicionarSaldo(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public override string ToString()
        {
            return $"\nDados da conta:\nConta: {NumeroConta}, Titular: {_nome}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
