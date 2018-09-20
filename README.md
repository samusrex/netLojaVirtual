## Loja Virtual - Cadastro de Produtos

Sistema de Cadastro de Produto,com listagem, adição/edição e exclusão de itens por categorias.

### Instalação

1. Faça um clone deste projeto com o git clone https://github.com/samusrex/netLojaVirtual.git

2. Abra a solução *Aplicacao.sln* no Visual Studio 2017.


3. Crie um banco de dados no SQL Server Express 2016, com o nome **Loja**.

4.Configure as *connections strings* do projeto em dois locais:
Aplicacao.Apresentacao -> Web.Config.
Aplicação.Console -> App.Config (Se desejar, executar).

Ex: __add name="LojaDb" connectionString="Data Source=.\SQLEXPRESS01;Initial Catalog=Loja; Integrated Security = true"  providerName="System.Data.SqlClient"__

(Em caso de banco de dados em rede local, configurar o DatarSource de acordo com os parâmetros do banco de dados.)

5. Abra a solução e no estrutura chamada *Aplicacao.Dados*, execute no *Package Manager Console* do seu Visual Studio, o comando *update-database*, este criará as tabelas necessárias no banco de dados.

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

## Observações Finais.











