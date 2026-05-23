# ✅ Todo List API

API RESTful desenvolvida com ASP.NET Core 8, Entity Framework Core e SQL Server para gerenciamento de tarefas (To Do List).

## 📌 Sobre o projeto

Este projeto foi desenvolvido como desafio técnico para a vaga de Desenvolvedor C#.

A aplicação permite realizar operações CRUD completas em uma lista de tarefas:

- Criar tarefas
- Listar tarefas
- Buscar tarefa por ID
- Atualizar tarefas
- Remover tarefas

---

# 🚀 Tecnologias utilizadas

- ASP.NET Core 8
- C#
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- REST API

---

# 📁 Estrutura do projeto

```bash
Controllers/
Models/
Data/
Migrations/
Program.cs
appsettings.json
```

---

# ⚙️ Configuração do ambiente

## ✅ Pré-requisitos

Antes de executar o projeto é necessário possuir instalado:

- .NET 8 SDK
- SQL Server
- Visual Studio 2022

---

# 🔧 Configuração do banco de dados

A string de conexão está localizada em:

```bash
appsettings.json
```

Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=TodoListDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

# ▶️ Como executar o projeto

## 1. Clone o repositório

```bash
git clone https://github.com/Felippe-gif/TodoListApiii.git
```

---

## 2. Abra o projeto no Visual Studio

Abra a solução:

```bash
TodoListApiii.sln
```

---

## 3. Execute as migrations

Abra o Package Manager Console:

```bash
Tools → NuGet Package Manager → Package Manager Console
```

Execute:

```bash
Add-Migration InitialCreate
```

Depois:

```bash
Update-Database
```

---

## 4. Execute a aplicação

Pressione:

```bash
F5
```

ou:

```bash
Ctrl + F5
```

---

# 📘 Swagger

Ao executar a aplicação, o Swagger será aberto automaticamente.

Exemplo:

```bash
https://localhost:xxxx/swagger
```

---

# 📌 Endpoints da API

## ✅ Listar tarefas

```http
GET /api/tarefas
```

---

## ✅ Buscar tarefa por ID

```http
GET /api/tarefas/{id}
```

---

## ✅ Criar tarefa

```http
POST /api/tarefas
```

### Exemplo JSON

```json
{
  "titulo": "Estudar ASP.NET Core",
  "descricao": "Aprender CRUD com Entity Framework",
  "concluida": false
}
```

---

## ✅ Atualizar tarefa

```http
PUT /api/tarefas/{id}
```

### Exemplo JSON

```json
{
  "id": 1,
  "titulo": "Projeto atualizado",
  "descricao": "CRUD funcionando",
  "concluida": true
}
```

---

## ✅ Remover tarefa

```http
DELETE /api/tarefas/{id}
```

---

# 🛠️ Funcionalidades implementadas

- CRUD completo
- Entity Framework Core
- SQL Server
- Migrations
- Swagger/OpenAPI
- API RESTful

---

# 📘 Swagger

## Interface da API funcionando

![Swagger](swagger.png)

# 👨‍💻 Autor

Felippe

GitHub:
https://github.com/Felippe-gif
