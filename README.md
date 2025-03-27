# Gerenciador de Tarefas - API (ToDoList)

## 📌 Introdução

Bem-vindo ao desafio prático de desenvolvimento de uma API para um **Gerenciador de Tarefas**! 🚀

O objetivo deste projeto é aplicar conceitos de arquitetura em camadas, boas práticas de desenvolvimento e padrões RESTful na criação de uma API para gerenciar tarefas.

## 📜 Descrição

Esta API permite que os usuários realizem as seguintes operações:

- Criar uma nova tarefa;
- Visualizar todas as tarefas criadas;
- Buscar uma tarefa pelo seu ID;
- Editar uma tarefa existente;
- Excluir uma tarefa.

A API segue um modelo de **arquitetura em camadas**, garantindo uma melhor organização e manutenção do código.



## 🏗 Arquitetura do Projeto

O projeto segue a divisão em camadas:

- **Camada de controle (API):** Responsável por receber as requisições e enviar as respostas contendo os dados e os status.codes;
- **Camada de regras de negócio (Application):** Contém a lógica do sistema e validações;
- **Camada de comunicação (Communication):** Responsável pelas requests e response (simulando as respostas do banco de dados).



## 📊 Estrutura da Tarefa

Uma tarefa possui os seguintes atributos:

| Campo          | Tipo          | Descrição                          |
|---------------|--------------|----------------------------------|
| `id`         | int         | Identificador único da tarefa  |
| `name`       | String       | Nome da tarefa                  |
| `description`  | String       | Descrição detalhada da tarefa  |
| `priority` | Enum       | `alta`, `média` ou `baixa`       |
| `date` | DateTime     | Data limite para conclusão     |
| `status`     | Enum       | `concluída`, `em andamento`, `aguardando` |



## 🔗 Endpoints

### Criar uma tarefa
- **POST** `api/Tasks`
- **Body:**
```json
{
  "name": "Estudar C#",
  "description": "Estudar padrões de projeto",
  "priority": "alta",
  "date": "2025-03-30T23:59:59",
  "status": "aguardando"
}
```

### Obter todas as tarefas
- **GET** `api/Tasks`
```json
{
  "tasks": [
    {
      "id": 1,
      "name": "Teste 1",
      "priority": 2,
      "date": "2025-03-25T00:00:00",
      "status": 1
    },
    {
      "id": 2,
      "name": "Teste 2",
      "priority": 0,
      "date": "2025-03-27T00:00:00",
      "status": 2
    }
  ]
}
```

### Obter uma tarefa pelo ID
- **GET** `api/Tasks/{id}`
```json
{
  "id": 1,
  "name": "Estudar C#",
  "description": "Aprimorar conhecimento em API REST",
  "priority": "média",
  "date": "2025-04-05T23:59:59",
  "status": "em andamento"
}
```

### Atualizar uma tarefa
- **PUT** `api/Tasks/{id}`
- **Body:**
```json
{
  "name": "Estudar C#",
  "description": "Aprimorar conhecimento em API REST",
  "priority": "média",
  "date": "2025-04-05T23:59:59",
  "status": "em andamento"
}
```

### Excluir uma tarefa
- **DELETE** `api/Tasks/{id}`



## ✅ Requisitos

- Implementar a arquitetura em camadas;
- Utilizar padrões RESTful;
- Retornar **status codes** adequados para cada operação;
- Aplicar boas práticas de desenvolvimento.



## 🔧 Tecnologias Utilizadas

- **C#**
- **.NET 8** (dependendo da versão utilizada)
- **Swagger** (para documentação da API)



## 🚀 Como Executar o Projeto

### 1️⃣ Clonar o repositório e acessar o projeto da API
```sh
git clone https://github.com/NeiJunio/ToDoListBasic.git
cd ToDoListBasic
cd .\ToDoList.API\
```

### 2️⃣ Executar a API
```sh
dotnet watch run
```

A API estará disponível em `https://localhost:porta` (conforme a porta definida na máquina pessoal).



## 📌 Considerações Finais

Este desafio foi e é uma excelente oportunidade para aprimorar conhecimentos em desenvolvimento de APIs com **.NET** e boas práticas de arquitetura.🚀

