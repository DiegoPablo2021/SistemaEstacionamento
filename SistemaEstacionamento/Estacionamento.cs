using System;
using System.Collections.Generic;

namespace SistemaEstacionamento
{
    // Classe responsável por toda gestão dos veículos estacionados
    public class Estacionamento
    {
        private const decimal ValorHora = 5.00m; // Valor cobrado por hora estacionado
        private readonly Dictionary<string, Veiculo> veiculosEstacionados = new Dictionary<string, Veiculo>();

        // Método para dar entrada de um veículo no estacionamento
        public void EntradaVeiculo(Veiculo veiculo)
        {
            veiculosEstacionados.Add(veiculo.Placa, veiculo);
            Console.WriteLine("Veículo estacionado com sucesso!");
        }

        // Método para dar saída de um veículo do estacionamento e calcular a tarifa
        public void SaidaVeiculo(string placa, int horasEstacionado, int minutosEstacionado)
        {
            if (veiculosEstacionados.TryGetValue(placa, out var veiculo))
            {
                veiculosEstacionados.Remove(placa);

                // Calculando o valor a ser cobrado considerando horas e minutos
                decimal valorHoras = horasEstacionado * ValorHora;
                decimal valorMinutos = (minutosEstacionado / 60.0m) * ValorHora;
                decimal valorCobrado = valorHoras + valorMinutos;

                Console.WriteLine($"Veículo {placa} removido. Valor total: R$ {valorCobrado:F2}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        // Método para listar os veículos estacionados
        public void ListarVeiculos()
        {
            if (veiculosEstacionados.Count == 0)
            {
                Console.WriteLine("Não há veículo estacionado.");
                return;
            }

            Console.WriteLine($"Total de veículos estacionados: {veiculosEstacionados.Count}");
            foreach (var veiculo in veiculosEstacionados.Values)
            {
                var tipo = veiculo is Carro ? "Carro" : "Moto";
                Console.WriteLine($"{tipo} - Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}, Fabricante: {veiculo.Fabricante}");
            }
        }
    }
}
