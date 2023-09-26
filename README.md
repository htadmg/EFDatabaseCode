# Projeto EFDatabaseCode

Este projeto implementa um sistema de gerenciamento de pedidos, clientes e produtos utilizando Entity Framework.

## Estrutura do Projeto

O projeto é composto por quatro classes principais:

### 1. Cliente

A classe `Cliente` representa um cliente e possui os seguintes atributos:

- `Id`: Identificador único do cliente.
- `Nome`: Nome do cliente.
- `Telefone`: Número de telefone do cliente.
- `Email`: Endereço de e-mail do cliente.

Além disso, a classe possui uma coleção de pedidos associados a este cliente.

### 2. Pedido

A classe `Pedido` representa um pedido e possui os seguintes atributos:

- `Id`: Identificador único do pedido.
- `ClienteID`: Chave estrangeira que referencia o cliente que fez o pedido.
- `ValorTotal`: Valor total do pedido.

Além disso, a classe possui uma coleção de produtos associados a este pedido.

### 3. Produto

A classe `Produto` representa um produto e possui os seguintes atributos:

- `Id`: Identificador único do produto.
- `Nome`: Nome do produto.
- `Valor`: Valor do produto.

Além disso, a classe possui uma coleção de pedidos associados a este produto.

### 4. PedidoProduto

A classe `PedidoProduto` representa a relação entre pedidos e produtos e possui os seguintes atributos:

- `ID`: Identificador único da relação.
- `PedidoID`: Chave estrangeira que referencia o pedido associado.
- `ProdutoID`: Chave estrangeira que referencia o produto associado.
- `Valor`: Valor associado à relação.

Além disso, a classe possui referências para o pedido e o produto associados.

## Utilização

O projeto inclui um arquivo `Program.cs` que demonstra como utilizar as classes definidas:

```csharp
var clientes = new VendaWebContext().Cliente.ToList();
Cliente cliente = clientes[0];

var produtos = new VendaWebContext().Produto.ToList();
Produto produto = produtos[0];

var pedidos = new VendaWebContext().Pedido.ToList();
Pedido pedido = pedidos[0];

var pedidoProdutos = new VendaWebContext().PedidoProduto.ToList();
PedidoProduto pedidoProduto = pedidoProdutos[0];
