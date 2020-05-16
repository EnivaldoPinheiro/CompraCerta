using System;
using System.IO;
using System.Text;

namespace ProjetoAED1
{
    class Program
    {
        class Revendedora
        {
            protected string Motor;
            protected double Cilindrada;
            protected string Aceleracao;
            protected double Consumo;
            protected string Modelo;
            protected string Marca;
            protected string Cor;
            protected string Cambio;
            protected string Tracao;
            protected int AnoFabricacao;


            public Revendedora(string motor, double porlitro, string velocidade, double litro,
                 string modelo, string fabricante, string cor, string marcha, string tracao, int ano)
            {
                Motor = motor;
                Cilindrada = porlitro;
                Aceleracao = velocidade;
                Consumo = litro;
                Modelo = modelo;
                Marca = fabricante;
                Cor = cor;
                Cambio = marcha;
                Tracao = tracao;
                AnoFabricacao = ano;

            }
            public Revendedora()
            {
            }
            public void setTipoMotor(string tipo)
            {
                Motor = tipo;
            }
            public string getTipoMotor()
            {
                return Motor;
            }
            public void setCilindro(double porlitro)
            {
                Cilindrada = porlitro;
            }
            public double getCinlindro()
            {
                return Cilindrada;
            }
            public void setVelocidade(string velocidade)
            {
                Aceleracao = velocidade;
            }
            public string getVelocidade()
            {
                return Aceleracao;
            }
            public void setLitro_Km(double consumo)
            {
                Consumo = consumo;

            }
            public double getLitro_Km()
            {
                return Consumo;
            }

            public void setTipoModelo(string tipomodelo)
            {
                Modelo = tipomodelo;
            }
            public string getTipoModelo()
            {
                return Modelo;
            }
            public void setFabricante(string marca)
            {
                Marca = marca;
            }
            public string getFabricante()
            {
                return Marca;
            }
            public void setCorRgb(string cor)
            {
                Cor = cor;
            }
            public string getCorRgb()
            {
                return Cor;
            }
            public void setcambio(string marcha)
            {
                Cambio = marcha;
            }
            public string getcambio()
            {
                return Cambio;
            }
            public void settracao(string tracao)
            {
                Tracao = tracao;
            }
            public string gettracao()
            {
                return Tracao;
            }
            public void setAno(int ano)
            {
                AnoFabricacao = ano;
            }
            public int getAno()
            {
                return AnoFabricacao;
            }

        }
        class PessoaFisica : PedidoCompra
        {
            protected string Nome;
            protected string Cpf;
            protected string Rg;
            protected string Endereco;
            protected string Telefone;



            public PessoaFisica(string nome, string cpf, string rg, string end, string contato)
            {
                Nome = nome;
                Rg = rg;
                Cpf = cpf;
                Endereco = end;
                Telefone = contato;
            }
            public PessoaFisica()
            {

            }
            public void setNomeFisico(string nome)
            {
                Nome = nome;
            }
            public string getNomeFisico()
            {
                return Nome;
            }
            public void setcpf(string cpf)
            {
                Cpf = cpf;
            }
            public string getcpf()
            {
                return Cpf;
            }
            public void setRgeral(string rg)
            {
                Rg = rg;
            }
            public string getRgeral()
            {
                return Rg;
            }
            public void setEnd(string end)
            {
                Endereco = end;
            }
            public string getEnd()
            {
                return Endereco;
            }
            public void setTel(string contato)
            {
                Telefone = contato;
            }
            public string getTel()
            {
                return Telefone;
            }

        }
        class PessoaJuridica : PessoaFisica
        {
            protected string NomeFantasia;
            protected string Cnpj;
            protected string InscEstadual;

            public PessoaJuridica(string fantasia,string cnpj,string ins_estadual)
            {
                NomeFantasia = fantasia;
                Cnpj = cnpj;
                InscEstadual = ins_estadual;
            }

            public void setFantasia(string empresa)
            {
                NomeFantasia = empresa;
            }
            public string getFantasia()
            {
                return NomeFantasia;
            }
            public void setCNPJ(string cnpj)
            {
                Cnpj = cnpj;
            }
            public string getCNPJ()
            {
                return Cnpj;
            }
            public void setinsestad(string ins_estad)
            {
                InscEstadual = ins_estad;
            }
            public string getinsestad()
            {
                return InscEstadual;
            }


        }
        class PedidoCompra : Revendedora
        {
            protected string DadoDoVeiculo;
            protected string DataPedido;
            protected string DataEntrega;
            protected double Valor;
            protected double ValorFrete;
            protected double ValorDesconto;
            protected double ValorTotal;

            public PedidoCompra(string carro, string dtpedido, string dtentrega, double preco, double frete, double desconto, double total)
            {
                DadoDoVeiculo = carro;
                DataPedido = dtpedido;
                DataEntrega = dtentrega;
                Valor = preco;
                ValorFrete = frete;
                ValorDesconto = desconto;
                ValorTotal = total;
            }
            public PedidoCompra()
            {

            }
            public void setveiculo(string carro)
            {
                DadoDoVeiculo = carro;
            }
            public string getveiculo()
            {
                return DadoDoVeiculo;
            }
            public void setdataPedido(string pedido)
            {
                DataPedido = pedido;
            }
            public string getdataPedido()
            {
                return DataPedido;
            }
            public void setdataEntrega(string entrega)
            {
                DataEntrega = entrega;
            }
            public string getdataEntrega()
            {
                return DataEntrega;
            }
            public void setFrete(double frete)
            {
                ValorFrete = frete;
            }
            public double getFrete()
            {
                return ValorFrete;
            }
            public void setDesconto(double desconto)
            {
                ValorDesconto = desconto;
            }
            public double getDesconto()
            {
                return ValorDesconto;
            }
            public void setTotal(double total)
            {
                ValorTotal = total;
            }
            public double getTotal()
            {
                return ValorTotal;
            }
        }
        class Venda : PedidoCompra
        {
            protected string Emplacamento;
            protected string ItemOpcional;
            protected string GarantiaCompra;

            public Venda(string placa, string opcionais, string garantia)
            {
                Emplacamento = placa;
                ItemOpcional = opcionais;
                GarantiaCompra = garantia;
            }
            public void setPlaca(string placa)
            {
                Emplacamento = placa;
            }
            public string getPlaca()
            {
                return Emplacamento;
            }
            public void setItens(string acessorio)
            {
                ItemOpcional = acessorio;
            }
            public string getItens()
            {
                return ItemOpcional;
            }
            public void setGarantia(string garantia)
            {
                GarantiaCompra = garantia;

            }
            public string getGarantia()
            {
                return GarantiaCompra;
            }
        }
        class PedidoEntrega
        {
            protected string Transportadora;
            protected string EndTransportadora;
            protected string Motorista;
            protected string Mercadoria;

            public PedidoEntrega(string transporte,string endtransporte,string condutor,string mercadoria)
            {
                Transportadora = transporte;
                EndTransportadora = endtransporte;
                Motorista = condutor;
                Mercadoria = mercadoria;
            }
            public PedidoEntrega() { }
            public void setNomeTransportadora(string transportadora)
            {
                Transportadora = transportadora;
            }
            public string getNomeTransportadora()
            {
                return Transportadora;
            }
            public void setEndtransportadora(string endereco)
            {
                EndTransportadora = endereco;
            }
            public string getEndtransportadora()
            {
                return EndTransportadora;
            }
            public void setNomeMotorista(string condutor)
            {
                Motorista = condutor;
            }
            public string getNomeMotorista()
            {
                return Motorista;
            }
            public void setTipoMercadoria(string tipo)
            {
                Mercadoria = tipo;
            }
            public string getTipoMercadoria()
            {
                return Mercadoria;
            }
        }
        static void Main(string[] args)
        {
            int motor;
            
            PessoaFisica pf = new PessoaFisica();
            PedidoCompra pc = new PedidoCompra();
            pf.setNomeFisico("Enivaldo Pinheiro");
            pf.setcpf("12345678900");
            pf.setRgeral("12345-ES");
            pf.setEnd("Rua IF nº27  bairro csharp  cidade UCL  Estado Terra do Nunca");
            pf.setTel("27 995170817");
            pc.setTipoModelo("Espero");
            pc.setCorRgb("vermelho");
            pc.setFabricante("Daewoo");
            pc.setTipoMotor("Gasolina 8 valvulas");
            pc.setAno(1995);
            pc.setCilindro(2.0);
            pc.setcambio("Automatico");
           
            
            Console.WriteLine("\n Nome: {0} \n Cpf: {1} \n RG: {2} \n Endereço:{3} \n Telefone: {4}", pf.getNomeFisico(),pf.getcpf(),pf.getRgeral(),pf.getEnd(),pf.getTel());
            Console.WriteLine("\n Modelo do Carro: {0} \n Cor do Carro: {1} \n Fabriante: {2} \n Tipo Motor: {3} \n Ano Fabricação: {4} \n Cilindrada Carro: {5} \n Tipo de Cambio: {6}",
                pc.getTipoModelo(), pc.getCorRgb(),pc.getFabricante(),pc.getTipoMotor(),pc.getAno(),pc.getCinlindro(),pc.getcambio()) ;


            //Revendedora carro = new Revendedora();
            // Console.WriteLine("Informe o modelo do carro? ");
            // Busca = Console.ReadLine();
            //carro.TipoModelo(Busca);


            //Console.WriteLine("Informe o modelo do carro? ");
            // StreamWriter sr = new StreamWriter(@"C:\Users\familia Pinheiro\Documents\CompraCerta\Arq texto\Minha_tabela.txt", true);
            // sr.GetType(pf.getNomeFisico);
            // sr.Close();







            //Console.WriteLine("Informe a marca do carro? ");
            //Busca = Console.ReadLine();
            //carro.Fabricante(Busca);
            //Console.WriteLine();

            //Console.WriteLine("Informe a cor do carro? ");
            //Busca = Console.ReadLine();
            //carro.CorRgb(Busca);
            //Console.WriteLine();

            //Console.WriteLine("Informe o tipo do motor? ");
            //Busca = Console.ReadLine();
            //carro.TipoMotor(Busca);
            //Console.WriteLine();

            //Console.WriteLine("Informe o ano do carro? " + carro.Ano());
            //Busca = Convert.ToString(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Informe a media de consumo ? " + carro.Litro_Km());
            //Busca = Convert.ToString(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Informe tipo de cambio? " + carro.cambio());
            //Busca = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("Informe tipo de tração? " + carro.tracao());
            //text = Console.ReadLine();
            //Console.WriteLine();





            //StreamWriter tab = new StreamWriter(@"D:/CompraCerta/Minha_tabela.txt");
            //tab.WriteLine("Enivaldo Pinheiro", pf.NomeFisico());

            //FileInfo aFile = new FileInfo("D:/CompraCerta/Minha_tabela.txt");
        }
    }
}
