using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraCerta
{
    static class Program
    {

        static void Main()
        {

            string Busca;
           
            PessoaFisica pf = new PessoaFisica();
            pf.NomeFisico("Pinheiro");
            Console.WriteLine();
            Revendedora carro = new Revendedora();
            Console.WriteLine("Informe o modelo do carro? ");
            Busca = Console.ReadLine();
            carro.TipoModelo(Busca);
            Console.WriteLine();
            Console.WriteLine("Informe a marca do carro? ");
            Busca = Console.ReadLine();
            carro.Fabricante(Busca);
            Console.WriteLine();
            Console.WriteLine("Informe a cor do carro? ");
            Busca = Console.ReadLine();
            carro.CorRgb(Busca);
            Console.WriteLine();
            Console.WriteLine("Informe o tipo do motor? ");
            Busca= Console.ReadLine();
            carro.TipoMotor(Busca);
            Console.WriteLine();
            Console.WriteLine("Informe o ano do carro? " + carro.Ano());
            Busca = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe a media de consumo ? "+ carro.Litro_Km());
            Busca = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe tipo de cambio? " + carro.cambio());
            Busca = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe tipo de tração? " + carro.tracao());
            Busca = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe tipo de cambio? " + carro.cambio());
            Busca = Console.ReadLine();

        }
    }
}
