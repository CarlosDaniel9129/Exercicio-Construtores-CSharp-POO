using Atividade_Construtores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador Accer = new Computador();

            Computador Asus = new Computador("X1KL6555");

            Computador Samsung = new Computador(2500, "preto");

            Computador Lenovo = new Computador("X254LM", "branco");

            /*****************************************************************/

            Estudante Carlos = new Estudante();

            Estudante Daniel = new Estudante("Daniel");

            Estudante Jesus = new Estudante(17, "47-99245-1683");

            Estudante David = new Estudante("Carlos", 17);

            Estudante Rodrigo = new Estudante("rodrigo@gmail", "47-99565-7895");

            /*****************************************************************/

            Veiculo Celta = new Veiculo("Caminhão");

            Veiculo Agile = new Veiculo("Carro", 2005);

            Veiculo Gol = new Veiculo(2010);

            Veiculo Saveiro = new Veiculo("Prata", "Confortline");

            Veiculo Cb300 = new Veiculo("Vermelha", "Esport", 2020, "Moto");

        }
    }
}
