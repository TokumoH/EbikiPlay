# Estrutura
Arquitetura DDD e Linguagem C#, feito no Visual Studio utilizando Windows Forms.

# EbikiPlay: Sistema CRUD e Player
O EbikiPlay é o um projeto final da matéria de Programação Orientada a Eventos (POE). Seu objetivo é realizar as atividades CRUD e funcionar como um player musical.

## Objetivos
Ao final do projeto o EbikiPlay deve ser capaz de realizar cadastros de músicas, artistas, álbuns, usuários, gêneros e playlists conforme a especificação de cada classe. Também deve ser possível tocar as músicas cadastradas através da url local do arquivo adicionada no cadastro do sistema.

## Arquitetura
Conforme o projeto Cinema (<a href ="https://github.com/TokumoH/Cinema">Cinema</a>) feito em conjunto com o Professor <a href="https://github.com/murilovarges">Murilo Varges</a> na aula de POE, o projeto segue uma arquitetura com base em DDD com banco de dados Postgres.

## Bibliotecas Nuget
	• RealTaizor
	• FluentValidation
	• Microsoft.EntityFrameworkCore
	• Npgsql
	• AutoMapper

## Estrutura de Diretórios Principais
`
/EbikiApp
	/Base
	/Cadastros
	/Config
	/Infra
	/Models
/EbikiDomain
	/Base
	/Diagrama
/EbikiRepository
	/Base
	/Context
	/Mapping
	/Repository
/EbikiService
	/Base
	/Validators
/EbikiTestes
`
