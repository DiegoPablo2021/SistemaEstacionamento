using System;

namespace SistemaEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var estacionamento = new Estacionamento();
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo ao Estacionamento 24/7\n");
                Console.WriteLine("============== Menu ===============");
                Console.WriteLine("1. Entrada de veículo");
                Console.WriteLine("2. Saída de veículo");
                Console.WriteLine("3. Listar veículos estacionados");
                Console.WriteLine("4. Encerrar o programa");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        EntradaVeiculo(estacionamento);
                        break;
                    case "2":
                        SaidaVeiculo(estacionamento);
                        break;
                    case "3":
                        ListarVeiculos(estacionamento);
                        break;
                    case "4":
                        Console.WriteLine("Encerrando o programa, volte sempre!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (opcao != "4")
                {
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
                }

            } while (opcao != "4");
        }

        // Método para dar entrada de um veículo
        static void EntradaVeiculo(Estacionamento estacionamento)
        {
            Console.Clear();
            Console.WriteLine("Entrada de Veículo");
            Console.Write("Tipo de veículo (Carro/Moto): ");
            var tipo = Console.ReadLine();

            Console.Write("Placa: ");
            var placa = Console.ReadLine();

            Console.Write("Modelo: ");
            var modelo = Console.ReadLine();

            Console.Write("Fabricante: ");
            var fabricante = Console.ReadLine();

            Veiculo veiculo;
            if (tipo.Equals("Carro", StringComparison.OrdinalIgnoreCase))
            {
                veiculo = new Carro(placa, modelo, fabricante);
            }
            else if (tipo.Equals("Moto", StringComparison.OrdinalIgnoreCase))
            {
                veiculo = new Moto(placa, modelo, fabricante);
            }
            else
            {
                Console.WriteLine("Tipo de veículo inválido.");
                return;
            }

            estacionamento.EntradaVeiculo(veiculo);
        }

        // Método para dar saída de um veículo
        static void SaidaVeiculo(Estacionamento estacionamento)
        {
            Console.Clear();
            Console.WriteLine("Saída de Veículo");
            Console.Write("Placa do veículo: ");
            var placa = Console.ReadLine();

            Console.Write("Quantidade de horas estacionado: ");
            if (int.TryParse(Console.ReadLine(), out int horasEstacionado))
            {
                Console.Write("Quantidade de minutos estacionado: ");
                if (int.TryParse(Console.ReadLine(), out int minutosEstacionado))
                {
                    estacionamento.SaidaVeiculo(placa, horasEstacionado, minutosEstacionado);
                }
                else
                {
                    Console.WriteLine("Quantidade de minutos inválida.");
                }
            }
            else
            {
                Console.WriteLine("Quantidade de horas inválida.");
            }
        }

        // Método para lisgar os veículos estacionados
        static void ListarVeiculos(Estacionamento estacionamento)
        {
            Console.Clear();
            Console.WriteLine("Veículos Estacionados");
            estacionamento.ListarVeiculos();
        }
    }
}
