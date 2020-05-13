using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraCerta
{
    class Revendedora
    {
        protected string Motor;
        protected double Potencia;
        protected string Aceleracao;
        protected double Consumo;
        protected string Modelo;
        protected string Marca;
        protected string Cor;
        protected string Cambio;
        protected string Tracao;
        protected int AnoFabricacao;
       

        public Revendedora(string motor, double cv, string velocidade, double litro,
             string modelo, string fabricante, string cor, string marcha, string tracao,int ano)
        {
            Motor = motor;
            Potencia = cv;
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
        public void TipoMotor(string tipo)
        {
            Motor = tipo;
        }
        public string TipoMotor()
        {
            return Motor;
        }
        public void CavaloV(double cv)
        {
            Potencia = cv;
        }
        public double CavaloV()
        {
            return Potencia;
        }
        public void Velocidade(string velocidade)
        {
            Aceleracao = velocidade;
        }
        public string Velocidade()
        {
            return Aceleracao;
        }
        public void Litro_Km(double consumo)
        {
            Consumo = consumo;

        }
        public double Litro_Km()
        {
            return Consumo;
        }

        public void TipoModelo(string tipomodelo)
        {
            Modelo = tipomodelo;
        }
        public string TipoModelo()
        {
            return Modelo;
        }
        public void Fabricante(string marca)
        {
            Marca = marca;
        }
        public string Fabricante()
        {
            return Marca;
        }
        public void CorRgb(string cor)
        {
            Cor = cor;
        }
        public string CorRgb()
        {
            return Cor;
        }
        public void cambio(string marcha)
        {
            Cambio = marcha;
        }
        public string cambio()
        {
            return Cambio;
        }
        public void tracao(string tracao)
        {
            Tracao = tracao;
        }
        public string tracao()
        {
            return Tracao;
        }
        public void Ano(int ano)
        {
            AnoFabricacao = ano;
        }
        public int Ano()
        {
            return AnoFabricacao;
        }
       
    }
}
