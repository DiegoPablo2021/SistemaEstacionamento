using System;
using System.Collections.Generic;



namespace SistemaEstacionamento
{
    // Classe Moto herdando propriedades da classe Veiculo
    public class Moto : Veiculo
    {
        public Moto(string placa, string modelo, string fabricante) : base(placa, modelo, fabricante)
        {
        }
    }
}
