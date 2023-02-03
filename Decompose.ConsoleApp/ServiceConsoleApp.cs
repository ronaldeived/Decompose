using Decompose.Service;
using System;

namespace Decompose.ConsoleApp
{
    public class ServiceConsoleApp
    {
        private VerifyNumberService _verifyNumber;
        public ServiceConsoleApp(VerifyNumberService verifyNumber)
        {
            _verifyNumber = verifyNumber;
        }

        public void ServiceConsole()
        {
            var response = string.Empty;
            do
            {
                Console.WriteLine("Digite um número para verificar divisores e primos: ");
                var number = int.Parse(Console.ReadLine());

                var getResult = _verifyNumber.Decompose(number);

                var dividers = string.Empty;
                var primes = string.Empty;

                foreach (var item in getResult.Dividers)
                    dividers += string.Concat(item.ToString(), " ");

                foreach (var item in getResult.Primes)
                    primes += string.Concat(item.ToString(), " ");

                Console.WriteLine($"Número de entrada: {getResult.Value}");
                Console.WriteLine($"Números divisores: {dividers}");
                Console.WriteLine($"Divisores Primos: {primes}");

                Console.WriteLine("\nDeseja verificar outro número? Sim (s) ou Não (n): ");
                response = Console.ReadLine();

                if (!(response.ToLower().Equals("s")))
                    break;

                Console.WriteLine();

            } while (true);
        }
    }
}
