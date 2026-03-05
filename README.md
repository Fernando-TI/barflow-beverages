# BarFlow:

BarFlow é um projeto backend desenvolvido em C#/.NET com foco em aprendizado de arquitetura em camadas e boas práticas de organização de código.

A proposta do projeto é simular o gerenciamento de bebidas de um bar, aplicando conceitos de separação de responsabilidades, modelagem de domínio e comunicação entre camadas.

---

## Arquitetura:

O projeto está organizado em camadas:

- **Domain** → regras de negócio e entidades
- **Application** → serviços e DTOs
- **Infrastructure** → persistência(repositório em memória)
- **API** → exposição de endpoints REST

Essa estrutura busca manter o domínio protegido e desacoplado, facilitando manutenção e evolução do sistema.

---

## Tecnologias utilizadas:

- C#
- .NET / ASP.NET Core
- Web API
- Repository Pattern

---

## Como executar:

1. Clonar o repositório:
```
git clone https://github.com/Fernando-TI/barflow-beverages
```

2. Acessar a pasta do projeto:

```
cd BarFlow
```

3. Executar a API:

```
dotnet run
```

4. Acessar o Swagger:

```
https://localhost:<5000>/swagger
```

---

## Objetivo do projeto:

Este projeto foi criado com fins de aprendizado, colocando em prática os conceitos importantes em desenvolvimento e explorando:

- Arquitetura em camadas
- Organização de código
- Encapsulamento de regras de negócio
- Comunicação entre serviços

O foco principal é evoluir a compreensão sobre estruturas de aplicações backend.

---

## Status do projeto:

 Em evolução contínua 🚀
