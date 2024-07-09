# Sistema de Estacionamento - C#

Este é um projeto de sistema de estacionamento desenvolvido em C# utilizando a plataforma Visual Studio. O sistema permite a entrada, saída e listagem de veículos estacionados,
calculando o valor a ser cobrado pelo tempo de estacionamento.

## Funcionalidades

- Entrada de veículo (Carro ou Moto)
- Saída de veículo com cálculo de valor cobrado (horas e minutos)
- Listagem de veículos estacionados
- Encerrar o programa

## Estrutura do Projeto

O projeto segue os princípios de Clean Code e está organizado da seguinte maneira:

- **Veiculo**: Classe base abstrata para veículos.
- **Carro**: Subclasse de Veiculo para representar carros que herda de veículos.
- **Moto**: Subclasse de Veiculo para representar motos que herda de veículos.
- **Estacionamento**: Classe responsável pela gestão dos veículos estacionados.
- **Program**: Classe principal que contém o menu e as interações com o usuário.

## Como Executar

1. Clone o repositório:

    ```bash
    git clone https://github.com/seu-usuario/sistema-estacionamento.git
    cd sistema-estacionamento
    ```

2. Abra o projeto no Visual Studio:

    - Abra o Visual Studio.
    - Selecione "Open a project or solution".
    - Navegue até o diretório clonado e abra o arquivo `SistemaEstacionamento.sln`.

3. Execute o projeto:

    - Pressione `F5` ou clique em "Start" no Visual Studio.

## Uso

### Menu Principal

Ao executar o programa, o menu principal será exibido com as seguintes opções:

1. **Entrada de veículo**
   - Solicita o tipo de veículo (Carro/Moto), placa, modelo e fabricante.
   - Exibe uma mensagem de sucesso ao estacionar o veículo.

2. **Saída de veículo**
   - Solicita a placa do veículo e a quantidade de horas e minutos estacionado.
   - Calcula e exibe o valor total a ser cobrado pelo tempo de estacionamento.

3. **Listar veículos estacionados**
   - Exibe a quantidade de veículos estacionados e suas informações (tipo (carro ou moto), placa, modelo e fabricante).

4. **Encerrar o programa**
   - Encerra a execução do programa.

### Entrada de Veículo

Ao selecionar a opção "Entrada de veículo", o programa solicitará as seguintes informações:

- Tipo de veículo (Carro ou Moto)
- Placa
- Modelo
- Fabricante

### Saída de Veículo

Ao selecionar a opção "Saída de veículo", o programa solicitará a placa do veículo e a quantidade de horas e minutos estacionado. O valor a ser cobrado é calculado com base
em uma taxa fixa de R$ 5,00 por hora.

### Listar Veículos Estacionados

Ao selecionar a opção "Listar veículos estacionados", o programa exibirá a quantidade de veículos estacionados, bem como as informações detalhadas de cada veículo
(tipo, placa, modelo e fabricante).

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias.

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.


---
⌨️ com ❤️ por [Diego Pablo](https://github.com/DiegoPablo2021) 😊