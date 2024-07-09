using System;
using System.Collections.Generic;

namespace SistemaEstacionamento
{
    // Classe Carro herdando propriedades da classe Veiculo
    public class Carro : Veiculo
    {
        public Carro(string placa, string modelo, string fabricante) : base(placa, modelo, fabricante)
        {
        }
    }
}
