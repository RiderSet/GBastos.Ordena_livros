📚 Ordena_LivrosApi – Web API mínima com Controllers (.NET)

Esta é uma Web API desenvolvida em C# com ASP.NET Core, utilizando o padrão MVC (Controllers).
A API tem como objetivo ordenar uma lista de livros em memória, de acordo com critérios dinâmicos informados pelo cliente.

🚀 Funcionalidades

✔ Web API com Controllers
✔ ASP.NET Core (.NET 8 / .NET 9)
✔ Persistência em memória
✔ Ordenação dinâmica por múltiplos critérios
✔ DTOs para entrada e saída
✔ Validação de dados
✔ Swagger (OpenAPI)
✔ Testes unitários com xUnit

📘 Livros armazenados em memória

A API trabalha inicialmente com os seguintes livros:

Título	Autor	Edição
Java How to Program	Deitel & Deitel	2007
Patterns of Enterprise Application Architecture	Martin Fowler	2002
Head First Design Patterns	Elisabeth Freeman	2004
Internet & World Wide Web: How to Program	Deitel & Deitel	2007
🔗 Endpoint disponível
POST /api/livros/ordenar

Este endpoint executa a ordenação dos livros conforme o critério informado.

📥 Request (Entrada)
Corpo da requisição (JSON)
{
  "campo": "titulo",
  "direcao": "asc"
}

Parâmetros aceitos
Campo	Descrição	Valores válidos
campo	Campo usado na ordenação	titulo, autor, edicao
direcao	Direção da ordenação	asc, desc

📌 Os valores não diferenciam maiúsculas de minúsculas.

📤 Response (Saída)
✅ Sucesso – 200 OK
[
  {
    "titulo": "Head First Design Patterns",
    "autor": "Elisabeth Freeman",
    "edicao": 2004
  },
  {
    "titulo": "Internet & World Wide Web: How to Program",
    "autor": "Deitel & Deitel",
    "edicao": 2007
  },
  {
    "titulo": "Java How to Program",
    "autor": "Deitel & Deitel",
    "edicao": 2007
  },
  {
    "titulo": "Patterns of Enterprise Application Architecture",
    "autor": "Martin Fowler",
    "edicao": 2002
  }
]

❌ Erro – 400 Bad Request

Quando o critério informado é inválido:

{
  "campo": "preco",
  "direcao": "asc"
}


Resposta:

Critério de ordenação inválido.

▶️ Como executar o projeto
Pré-requisitos

.NET SDK 8 ou 9

Git

Visual Studio ou VS Code (opcional)

Clonar o repositório
git clone https://github.com/SEU-USUARIO/LivrosApi.git
cd LivrosApi

Executar a aplicação
dotnet restore
dotnet run


A aplicação será iniciada em algo semelhante a:

https://localhost:7000

🧪 Testar no Swagger

Abra o navegador e acesse:

https://localhost:7000/swagger


Localize o endpoint POST /api/livros/ordenar

Clique em Try it out

Informe o JSON da requisição

Clique em Execute

🧪 Testar via curl (opcional)
curl -X POST https://localhost:7000/api/livros/ordenar \
-H "Content-Type: application/json" \
-d "{ \"campo\": \"autor\", \"direcao\": \"desc\" }"

🧪 Testes unitários

Os testes unitários validam a regra de negócio da ordenação.

Executar:

dotnet test

🛠 Tecnologias Utilizadas

ASP.NET Core Web API

Controllers (MVC)

C#

Swagger / OpenAPI

xUnit

InMemory Repository

Dependency Injection

📌 Possíveis melhorias

Paginação de resultados

Ordenação genérica com Expression Trees

FluentValidation

Persistência com banco de dados

Versionamento da API

Autenticação e autorização

👤 Autor

Gil Antonio Bastos
Projeto educacional para estudo de Web APIs com ASP.NET Core e Controllers.

📄 Licença

Este projeto está sob a licença MIT.
