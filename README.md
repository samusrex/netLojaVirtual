## Loja Virtual - Cadastro de Produtos

Sistema de Cadastro de Produto,com listagem, adição/edição e exclusão de itens por categorias.

### Instalação

1. Faça um clone deste projeto com o git clone https://github.com/samusrex/netLojaVirtual.git

2. Abra a solução *Aplicacao.sln* no Visual Studio 2017.


3. Crie um banco de dados no SQL Server Express 2016, com o nome **Loja**.

3.1 Para adicionar a Store procedure execute o arquivo do projeto *spInserirProdutoCategoriaEletronicos.sql*

4.Configure as *connections strings* do projeto nos locais:
Aplicacao.Apresentacao -> Web.Config.
Aplicação.Console -> App.Config (Se desejar, executar).

Ex: __add name="LojaDb" connectionString="Data Source=[nomeservidor]\SQLEXPRESS;Initial Catalog=Loja; Integrated Security = true"  providerName="System.Data.SqlClient"__

5. Após as *connection strings* estiverem configurada corretamente.Abra a estrutura chamada *Aplicacao.Dados*, execute no *Package Manager Console* do seu Visual Studio, o comando *update-database*, este criará as tabelas necessárias no banco de dados.

6. Após a criação da estrutura necessária no banco, este será populado por alguns registros. Através do método *Seed* da classe *Configuration.cs.*

7. Configurar para que a estrutura *Aplicacao.Apresentacao* esteja como o *Projeto de Inicialização* Set as StartUp Project.

8. Execute.


## Tecnologias Utilizadas.

* Asp .Net MVC 5
* Entity Framework
* Materialize CSS
* JQuery

## Tasks

__Breve descrição das atividades__:

1. Elaborei uma arquitetura simples para meu desenvolvimento,dividida em:
* Aplicacao.Apresentacao : Aplicação MVC,HTML,Helpers,Js e CSS.
* Aplicacao.Console: Um programa de console para realizar teste nos métodos.
* Aplicacao.Loja: aqui encontra-se a lógica do sistema. Simples.
*Aplicacao.Testes: Alguns testes realizados.



2. Crie as classes que serão utlizadas. Com base na abstração obtida.

3. Criei o Repositório Genérico.

4. Implementei o Produto Repositório.

5. Apliquei o Migration para realizar as criações das tabelas no banco.

6. Criei uma aplicação de console, antes para testar os métodos.

7. Criei uma aplicação MVC, para visualizar os dados.

8. Apliquei estilização nas páginas.

9. Corrigi alguns bugs de apresentação.

10. Fiz um deploy local.

## Observações Finais e Considerações.
Existem várias jeitos de modelar esta solução, por exemplo, poderíamos criar uma entidade Produto e Categoria tal como:

` public class Produto{
(...)
Categoria categoria{get;set;}
}`
Porém para este exemplo, decidi aplicar a abstração e o polimorfismo da Orientação a Objetos e tornei a classe Produto em um conceito abstrato, bem mais próximo do que a palavra significa no mundo real. 
Esta contém informações em comum para todas as outras classe que a herdam, que são as classes concretas, onde cada uma possui características próprias que as definem como um objeto diferente. Com isso a aplicação se beneficia das vantagens do polimorfismo.

Existe um método no Repositório de Produtos que é chamado de 
*RegistreUsandoStoreProcedure()* , este chama a procedure que estará no banco criado e criará um novo registro de um Produto > Eletrônico.

Grato.















