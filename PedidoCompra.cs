using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraCerta
{
    class PedidoCompra : Revendedora
    {
        protected string DadoDoVeiculo;
        protected string DataPedido;
        protected string DataEntrega;
        protected double Valor;
        protected double ValorFrete;
        protected double ValorDesconto;
        protected double ValorTotal;

        public PedidoCompra(string carro,string dtpedido,string dtentrega,double preco,double frete,double desconto,double total)
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
        public void veiculo(string carro)
        {
            DadoDoVeiculo = carro;
        }
        public string veiculo()
        {
            return DadoDoVeiculo;
        }
        public void dataPedido(string pedido)
        {
            DataPedido = pedido;
        }
        public string dataPedido()
        {
            return DataPedido;
        }
        public void dataEntrega(string entrega)
        {
            DataEntrega = entrega;
        }
        public string dataEntrega()
        {
            return DataEntrega;
        }
        public void Frete(double frete)
        {
            ValorFrete = frete;
        }
        public double Frete()
        {
            return ValorFrete;
        }
        public void Desconto(double desconto)
        {
            ValorDesconto = desconto;
        }
        public double Desconto()
        {
            return ValorDesconto;
        }
        public void Total(double total)
        {
            ValorTotal = total;
        }
        public double Total()
        {
            return ValorTotal;
        }
    }
}
