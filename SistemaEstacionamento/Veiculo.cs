using System;

namespace SistemaEstacionamento
{
    // Classe abstrata representando veículo
    public abstract class Veiculo
    {
        // Propriedades para a placa, modelo e fabricante do veículo
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }

        public Veiculo(string placa, string modelo, string fabricante)
        {
            Placa = placa;
            Modelo = modelo;
            Fabricante = fabricante;
        }
    }
}
