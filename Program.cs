using System;

namespace ProjetoAED1
{
    class Program
    {
        class Revendedora
        {
            protected string Motor;
            protected string Cilindrada;
            protected string Aceleracao;
            protected double Consumo;
            protected string Modelo;
            protected string Marca;
            protected string Cor;
            protected string Cambio;
            protected string Tracao;
            protected int AnoFabricacao;


            public Revendedora(string motor, string porlitro, string velocidade, double litro,
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
            public void setCilindro(string porlitro)
            {
                Cilindrada = porlitro;
            }
            public string getCinlindro()
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

            public PessoaJuridica(string fantasia, string cnpj, string ins_estadual)
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
            protected string Valor;
            protected string ValorDesconto;
            protected string ValorTotal;

            public PedidoCompra(string carro, string dtpedido, string dtentrega, string preco, string desconto, string total)
            {
                DadoDoVeiculo = carro;
                DataPedido = dtpedido;
                DataEntrega = dtentrega;
                Valor = preco;
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
            public void setvalor(string preco)
            {
                Valor = preco;
            }
            public string getvalor()
            {
                return Valor;
            }
            public void setValorPedido(string pedido)
            {
                Valor = pedido;
            }
            public string getValorPedido()
            {
                return Valor;
            }
            public void setDesconto(string desconto)
            {
               
                ValorDesconto = desconto;
            }
            public string getDesconto()
            {
                return ValorDesconto;
            }
            public void setTotal(string total)
            {
                ValorTotal = total;
            }
            public string getTotal()
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
            public Venda() { }

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
        class PedidoEntrega : PedidoCompra
        {
            protected string Transportadora;
            protected string EndTransportadora;
            protected string Motorista;
            protected string Mercadoria;

            public PedidoEntrega(string transporte, string endtransporte, string condutor, string mercadoria)
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
            Console.WriteLine(">>>>>>>>>>>>>>>>>>Pedido de Compra<<<<<<<<<<<<<<<<<<<<");
            PessoaFisica pf = new PessoaFisica();
            PedidoCompra pc = new PedidoCompra();
            Venda vendido = new Venda();
            pf.setdataPedido("17/05/20");
            pf.setNomeFisico("Enivaldo Pinheiro");
            pf.setcpf("12345678900");
            pf.setRgeral("12345-ES");
            pf.setEnd("Rua IF nº27  bairro csharp  cidade UCL  Estado Terra do Nunca");
            pf.setTel("27 995170817");
            pf.setTipoModelo("Espero");
            pf.setCorRgb("vermelho");
            pf.setFabricante("Daewoo");
            pf.setTipoMotor("Gasolina 8 valvulas");
            pf.setAno(1995);
            pf.setCilindro("2.0");
            pf.setcambio("Automatico");
            pf.setvalor("10.000");
            pf.setDesconto("1.000");
            pf.setTotal("9.000");
                 

            Console.WriteLine("\n Data do Pedido: {0} \n Nome: {1} \n Cpf: {2} \n RG: {3} \n Endereço:{4} \n Telefone: {5}",pf.getdataPedido(), pf.getNomeFisico(), pf.getcpf(), pf.getRgeral(), pf.getEnd(), pf.getTel());
            Console.WriteLine("\n Modelo do Carro: {0} \n Cor do Carro: {1} \n Fabriante: {2} \n Tipo Motor: {3} \n Ano Fabricação: {4} \n Cilindrada Carro: {5} \n Tipo de Cambio: {6}",
                pf.getTipoModelo(), pf.getCorRgb(), pf.getFabricante(), pf.getTipoMotor(), pf.getAno(), pf.getCinlindro(), pf.getcambio());
            Console.WriteLine("\n Valor do Carro : {0} \n Desconto de 10% para compras Avista: {1} \n Valor total a pagar: {2}",pf.getvalor(),pf.getDesconto(),pf.getTotal());
                      
           
            
            Console.WriteLine(">>>>>>>>>>>>>>>>>>Venda<<<<<<<<<<<<<<<<<<<<");
           
            pc.setdataEntrega("20/05/20");
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
            pc.setCilindro("2.0");
            pc.setcambio("Automatico");
            pc.setvalor("10.000");
            pc.setDesconto("1.000");
            pc.setTotal("9.000");
            vendido.setPlaca("ESP 123");
            vendido.setGarantia("3 meses");
            vendido.setvalor("10.000");
            vendido.setDesconto("1.000");
            vendido.setTotal("9.000");

            Console.WriteLine("\n Data da Venda: {0} \n Nome: {1} \n Cpf: {2} \n RG: {3} \n Endereço:{4} \n Telefone: {5}",pc.getdataEntrega(),pf.getNomeFisico(), pf.getcpf(), pf.getRgeral(), pf.getEnd(), pf.getTel());
            Console.WriteLine("\n Modelo do Carro: {0} \n Cor do Carro: {1} \n Fabriante: {2} \n Tipo Motor: {3} \n Ano Fabricação: {4} \n Cilindrada Carro: {5} \n Tipo de Cambio: {6}",
                pc.getTipoModelo(), pc.getCorRgb(), pc.getFabricante(), pc.getTipoMotor(), pc.getAno(), pc.getCinlindro(), pc.getcambio());
            Console.WriteLine("\n Numero da Placa: {0} \n Garantia de Compra: {1} \n Valor do Carro : {2} \n Desconto de 10% para compras Avista: {3} \n Valor total a pagar: {4}", vendido.getPlaca(),vendido.getGarantia(),vendido.getvalor(), vendido.getDesconto(), vendido.getTotal());







        }
    }
}
