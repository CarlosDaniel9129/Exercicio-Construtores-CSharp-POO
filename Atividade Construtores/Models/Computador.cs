using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Construtores.Models
{
    class Computador
    {
        private string modelo;
        private double preco;
        private string cor;

        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                if (value >= 2300 && value <= 8000)
                {
                    preco = value;
                }
                else
                {
                    throw new Exception("O preço informado é inválido");
                }
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                if (value ==  "branco" || value == "preto")
                {
                    cor = value;
                }
                else
                {
                    throw new Exception("A cor informada é inválida");
                }
            }
        }

        public Computador()
        {
            
        }

        public Computador(string _modelo)
        {
            modelo = _modelo;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Computador ---- Modelo: " + _modelo);
        }

        public Computador(double _preco, string _cor)
        {
            Cor = _cor;
            Preco = _preco;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Computador ---- Preço: " + _preco);
            Console.WriteLine("Computador ---- Cor: " + _cor);
        }
        
        public Computador(string _modelo, string _cor)
        {
            Cor = _cor;
            modelo = _modelo;                /*não necessitoy fazer verificação na var*/

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Computador ---- Modelo: " + _modelo);
            Console.WriteLine("Computador ---- Cor: " + _cor);
        }



    }
}
