using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Construtores.Models
{
    class Veiculo
    {
        private string modelo;
        private int ano;
        private string cor;
        private string tipo;

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if(value >= 2000 && value <= 2020)
                {
                    ano = value; 
                }
                else
                {
                    throw new Exception("O ANO infomrado é inválido");
                }
            }

        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if(value == "Carro" || value == "Moto" || value == "Caminhão" || value == "Barco" || value == "Avião")
                {
                    tipo = value;
                }
                else
                {
                    throw new Exception("O tipo de Veículo infomrado é inválido");
                }
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if(value.Length > 5)
                {
                    modelo = value;
                }
                else
                {
                    throw new Exception("O modelo informado deve ter ao mesnos 5 caracteres");
                }
            }
        }

        public Veiculo(string _tipo)
        {
            Tipo = _tipo;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Veiculo ---- Tipo: " + _tipo);
        }

        public Veiculo(string _tipo, int _ano)
        {
            Tipo = _tipo;
            Ano = _ano;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Veiculo ---- Tipo: " + _tipo);
            Console.WriteLine("Veiculo ---- Ano: " + _ano);
        }

        public Veiculo(int _ano)
        {
            Ano = _ano;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Veiculo ---- Ano: " + _ano);
        }   

        public Veiculo(string _cor, string _modelo)
        {
            cor = _cor;
            Modelo = _modelo;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Veiculo ---- Cor: " + _cor);
            Console.WriteLine("Veiculo ---- Modelo: " + _modelo);
        }

        public Veiculo(string _cor, string _modelo, int _ano, string _tipo)
        {
            cor = _cor;
            Modelo = _modelo;
            Ano = _ano;
            Tipo = _tipo;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Veiculo ---- Cor: " + _cor);
            Console.WriteLine("Veiculo ---- Modelo: " + _modelo);
            Console.WriteLine("Veiculo ---- Ano: " + _ano);
            Console.WriteLine("Veiculo ---- Tipo: " + _tipo);
        }
    }
}
