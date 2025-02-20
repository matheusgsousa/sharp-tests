# SharpTests

Este repositório contém uma coleção de projetos de teste para diferentes bibliotecas e aplicações. Cada projeto de teste é responsável por validar a funcionalidade de uma biblioteca específica. Os testes são reproduções de casos exemplificados e estudados no livro "Test Driven Development - Teste e Design no Mundo Real com DotNet - Casa do Codigo".

## Ferramentas Utilizadas

- **NUnit**: Framework de testes unitários.
- **Moq**: Biblioteca para criação de objetos mock.
- **Coverlet**: Ferramenta de cobertura de código.

## Projetos

### AlgarismosRomanos

- **Descrição**: Biblioteca para conversão de números romanos para inteiros.
- **Projeto de Teste**: `TestAlgarismosRomanos`

### Calculadora

- **Descrição**: Biblioteca para operações básicas de cálculo.
- **Projeto de Teste**: `TestCalculadora`

### EmpresaTech

- **Descrição**: Biblioteca para gerenciamento de funcionários e cálculo de salários.
- **Projeto de Teste**: `TestEmpresaTech`

### LojaVirtual

- **Descrição**: Biblioteca para gerenciamento de um carrinho de compras.
- **Projeto de Teste**: `TestLojaVirtual`

### Lojinha

- **Descrição**: Biblioteca para gerenciamento de produtos e carrinho de compras.
- **Projeto de Teste**: `TestLojinha`

### NotaFiscalLib

- **Descrição**: Biblioteca para geração e gerenciamento de notas fiscais.
- **Projeto de Teste**: `TestNotaFiscalLib`

## Estrutura do Repositório

- **/AlgarismosRomanos**: Código fonte da biblioteca AlgarismosRomanos.
- **/Calculadora**: Código fonte da biblioteca Calculadora.
- **/EmpresaTech**: Código fonte da biblioteca EmpresaTech.
- **/LojaVirtual**: Código fonte da biblioteca LojaVirtual.
- **/Lojinha**: Código fonte da biblioteca Lojinha.
- **/NotaFiscalLib**: Código fonte da biblioteca NotaFiscalLib.
- **/TestAlgarismosRomanos**: Testes unitários para a biblioteca AlgarismosRomanos.
- **/TestCalculadora**: Testes unitários para a biblioteca Calculadora.
- **/TestEmpresaTech**: Testes unitários para a biblioteca EmpresaTech.
- **/TestLojaVirtual**: Testes unitários para a biblioteca LojaVirtual.
- **/TestLojinha**: Testes unitários para a biblioteca Lojinha.
- **/TestNotaFiscalLib**: Testes unitários para a biblioteca NotaFiscalLib.

## Como Executar os Testes

1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/SharpTests.git
   ```
2. Navegue até o diretório do projeto de teste desejado:
   ```sh
   cd SharpTests/TestCalculadora
   ```
3. Execute os testes:
   ```sh
   dotnet test
   ```
