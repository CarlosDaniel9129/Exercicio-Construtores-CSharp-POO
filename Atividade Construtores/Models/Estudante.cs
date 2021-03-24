using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Construtores
{
    class Estudante
    {
        private string nome;
        private string email;
        private int idade;
        private string telefone;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("O campo do NOME deve ser obrigatório");
                }
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value >= 13 && value <= 18)
                {
                    idade = value;
                }
                else
                {
                    throw new Exception("A idade informada é inválida");
                }
            }
        }

        public string Telefone
        {
            get 
            {
                return telefone; 
            }
            set
            {
                if (value.Length >= 11 && value.Length <= 15)
                {
                    telefone = value;
                }
                else
                {
                    throw new Exception("Telefone informado é invalido");
                }
            }
        }


        public Estudante()
        {

        }

        public Estudante(string _nome)
        {
            Nome = _nome;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Estudante ---- Nome: " + _nome);
        }

        public Estudante(string _nome, int _idade)
        {
            Nome = _nome;
            Idade = _idade;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Estudante ---- Nome: " + _nome);
            Console.WriteLine("Estudante ---- Idade: " + _idade);
        }

        public Estudante(int _idade, string _telefone)
        {
            Idade = _idade;
            Telefone = _telefone;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Estudante ---- Idade: " + _idade);
            Console.WriteLine("Estudante ---- Telefone: " + _telefone);
        }

        public Estudante(string _email, string _telefone)
        {
            email = _email;
            Telefone = _telefone;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Estudante ---- Email: " + _email);
            Console.WriteLine("Estudante ---- Telefone: " + _telefone);
        }
    }
}
