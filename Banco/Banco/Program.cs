using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Console.WriteLine("----BANCO----");
            Console.WriteLine("Entre o numero da conta: ");
            short NumeroConta = short.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Haverá um depósito inicial? (s/n): ");
            char Opcao = char.Parse(Console.ReadLine());
            Conta conta = new Conta(Nome, NumeroConta);

            if (Opcao == 's')
            {
                Console.WriteLine("Entre o valor de deposito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.AdicionarSaldo(valor);
            }

            Console.WriteLine(conta.ToString());


            Console.WriteLine("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarSaldo(valor);
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor-5);
            Console.WriteLine(conta.ToString());

            Console.ReadKey();
        }
    }
}
