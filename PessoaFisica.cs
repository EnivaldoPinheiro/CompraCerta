using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraCerta
{
    class PessoaFisica : PedidoCompra
    {
        protected string Nome;
        protected string Cpf;
        protected string Rg;
        protected string Endereco;
        protected int Telefone;



        public PessoaFisica(string nome, string cpf, string rg, string end, int contato)
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
        public void NomeFisico(string nome)
        {
            Nome = nome;
        }
        public string NomeFisico()
        {
            return Nome;
        }
        public void cpf(string cpf)
        {
            Cpf = cpf;
        }
        public string cpf()
        {
            return Cpf;
        }
        public void Rgeral(string rg)
        {
            Rg = rg;
        }
        public string Rgeral()
        {
            return Rg;
        }
        public void End(string end)
        {
            Endereco = end;
        }
        public string End()
        {
            return Endereco;
        }
        public void Tel(int contato)
        {
            Telefone = contato;
        }
        public int Tel()
        {
            return Telefone;
        }

    }
}
