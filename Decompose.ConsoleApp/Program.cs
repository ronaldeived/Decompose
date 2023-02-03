using Decompose.Service;

namespace Decompose.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var verifyNumber = new VerifyNumberService();
            var service = new ServiceConsoleApp(verifyNumber);
            service.ServiceConsole();
        }
    }
}
