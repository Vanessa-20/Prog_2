# Prog_2
Projeto trabalho
Criar um projeto
Seleciona o aplicativo  Web do ASP.NET Core(Model-View-Controller)
Coloca o nome do projeto e tira o http
Primeiro voce vai instalar os pacotes e colocar para versao 6.0.20 (ferramentas -gerenciador de pacotes nugets- gerenciador de pacots nugets para solucao)
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer

Para espesificar a classe  model vai criar a pasta psicologo( vai no models- adicionar- novo item seleciona classe e nomeia para psicolog.cs)
Definir um dbcontext cria a pasta data e faz um app bdcontext.cs
definir o AppUser no models

dotnet ef migrations add Initial
(criar a classe migracions)
depois o o dotnet ef database update
(atualizar o banco de dados)
