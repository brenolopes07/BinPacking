# 🗃️ BinPacking API – Desafio Técnico

Este projeto é uma solução para o desafio técnico, onde o objetivo é criar uma API para ajudar o Seu Manoel a automatizar o processo de embalagem dos pedidos da sua loja de jogos online. A aplicação recebe uma lista de pedidos, calcula o melhor encaixe dos produtos em caixas pré-definidas e retorna o resultado.

---

## 🚀 Tecnologias Utilizadas

### Back-end
- .NET 8 (ASP.NET Core)
- Entity Framework Core
- SQL Server (em Docker)
- Swagger para documentação

### Outros
- Docker para o banco de dados
- Arquitetura RESTful

---

## 🎯 Funcionalidades

- Recebimento de pedidos via JSON
- Cálculo de melhor empacotamento de produtos em caixas
- Minimização do número de caixas utilizadas
- Banco de dados SQL Server via Docker
- Documentação interativa via Swagger

---

## 📦 Tamanhos das Caixas

As caixas disponíveis para o Seu Manoel são:

- **Caixa 1:** 30 x 40 x 80 cm
- **Caixa 2:** 80 x 50 x 40 cm
- **Caixa 3:** 50 x 80 x 60 cm

---

## ▶️ Como Executar Localmente

### Pré-requisitos

- Docker instalado
- .NET SDK 8 instalado

---

### 1️⃣ Clone o repositório

```bash
git clone https://github.com/brenolopes07/BinPacking.git
cd BinPacking