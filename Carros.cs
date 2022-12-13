using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoChatoCarro
{
    internal class Carros
    {
        private string Marca;

        public string MarcaCarro
        {
            get { return Marca; }
            set { Marca = value; }
        }
        private double Valor;

        public double Valores
        {
            get { return Valor; }
            set { Valor = value; }
        }

        private string Cor;

        public string CorCarro
        {
            get { return Cor; }
            set { Cor = value; }
        }
        private string Modelo;

        public string ModeloCarro
        {
            get { return Modelo; }
            set { Modelo = value; }
        }
        private int Ano;

        public int AnoCarro
        {
            get { return Ano; }
            set { Ano = value; }
        }
        public int Acao;
        public int id;

        
        public void Mensagem()
        {
            Console.WriteLine("Digite 1 para cadastrar um carro: ");
            Console.WriteLine("Digite 2 para Excluir um carro: ");
            Console.WriteLine("Digite qualquer outro numero para Encerrar: ");
        }




    }
}