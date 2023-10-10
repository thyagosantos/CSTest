# Questão 1
### Categorização de Trades em um Banco  
Este projeto visa demonstrar o uso de padrões de design na categorização de trades em um banco. O problema consiste em categorizar trades com base em seu valor e no setor do cliente. Para isso, foram utilizados os seguintes padrões de design:
### Padrão de Design Strategy
O padrão de design Strategy foi utilizado para definir e encapsular algoritmos de categorização diferentes em classes separadas, permitindo que eles possam ser facilmente modificados, estendidos ou substituídos sem afetar o código existente. As regras de categorização, como LowRisk, MediumRisk e HighRisk, foram implementadas como estratégias que implementam a mesma interface ITradeCategorizationRule. Isso permite que novas regras sejam adicionadas no futuro sem a necessidade de alterar o código existente.
### Como Usar
### Para usar o sistema de categorização de trades, siga as etapas abaixo:

1. Defina regras de categorização personalizadas:
Crie novas classes que implementam a interface ITradeCategorizationRule para definir regras de categorização personalizadas. Você pode adicionar, remover ou modificar regras conforme necessário.

2. Crie uma instância de TradeCategorizer:
No seu programa principal, crie uma lista de regras de categorização e passe essa lista para o construtor de TradeCategorizer. Isso permitirá que você use o TradeCategorizer com as regras personalizadas que você definiu.

3. Categorize Trades:
Crie uma lista de trades que você deseja categorizar e use o TradeCategorizer para atribuir categorias a esses trades.

4. Visualize os Resultados:
Os resultados da categorização serão refletidos nas categorias atribuídas a cada trade. Você pode exibir essas categorias como desejado

### Conclusão
As regras de categorização são encapsuladas em classes separadas, facilitando a adição, remoção e modificação de regras no futuro. 

## Questão 2: Solução T-SQL para Categorização de Trades

Nesta questão, apresentamos uma solução procedural em T-SQL (SQL Server) para a categorização de trades com base em regras específicas. Aqui está como você pode usar esta solução:

### Passo 1: Criar Tabelas

Antes de começar, você precisará criar as tabelas necessárias para armazenar os trades e os resultados categorizados. 
Você pode usar os seguintes arquivos SQL para criar as tabelas: Question 2\CREATE TABLE.sql
Você pode usar os seguintes arquivos SQL para criar a Procedure: Question 2\CREATE PROCEDURE.sql
Você deve usar os seguintes arquivos SQL para executar o exemplo: Question 2\execute the stored procedure.sql

execute the stored procedure.sq
