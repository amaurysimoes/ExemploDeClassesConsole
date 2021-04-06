using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDevmedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Assinatura a = new Assinatura
            {
                Codigo = 123,
                Nome = "Assinatura MVP",
                Preco = 69.99M,
                DataEspiracao = DateTime.Today.AddMonths(12)
            };
            Console.WriteLine($"Dias restante de assinatura: {a.GetTempoRestante().Days}");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
