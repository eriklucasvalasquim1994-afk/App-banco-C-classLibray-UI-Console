#  App.Banco — Sistema Bancário Simples em C#

Este projeto é um **aplicativo bancário básico em C#**, criado para treinar conceitos de lógica, orientação a objetos, classes, métodos e manipulação de dados no console.  

O objetivo é simular operações bancárias simples como **criar conta, depositar, sacar e visualizar o saldo**.

---

##  Funcionalidades

- Criar uma conta bancária  
- Consultar saldo atual  
- Depositar valores  
- Sacar valores (com validação de saldo)  
- Exibição formatada das informações no console  
- Sistema organizado em classes separadas (OOP)

---
##  Estrutura do Projeto

App.Banco/
│
├── App.Banco.sln # Arquivo da solução
├── Program banco git.cs # Lógica principal (Console)
├── ContaBancaria.cs # Classe ContaBancaria (OOP)
└── README.md # Documentação do projeto


---

##  Classe Principal — ContaBancaria

A classe `ContaBancaria` contém:

- Propriedades: Titular, Saldo  
- Métodos:
  - `Depositar(decimal valor)`
  - `Sacar(decimal valor)`
  - `VerSaldo()`

Esses métodos garantem encapsulamento e validação interna.

---

##  Como Executar o Projeto

1. Instale o **.NET SDK** (versão 6 ou superior)  
2. Abra o projeto no **Visual Studio** ou **VS Code**  
3. Rode pelo terminal com:


4. O menu aparecerá no console para você interagir com o sistema.

---

##  Tecnologias Utilizadas

- **C#**
- **.NET**
- Programação orientada a objetos (POO)
- Console Application

---

##  Exemplo de Uso (Opcional)

=== Conta: João Silva ===
Saldo atual: R$ 350,00

1 - Depositar
2 - Sacar
3 - Ver Saldo
0 - Sair

---

## Aprendizados do Projeto

- Uso de classes e métodos  
- Criar e manipular objetos  
- Entrada e saída de dados no console  
- Validação de informações  
- Estrutura de projetos no GitHub  
- Versionamento e organização de repositórios

---

##  Observações

Este é um projeto inicial criado para estudo, mas pode evoluir para algo mais completo, como:

- Persistência de dados (arquivo, banco ou API)  
- Interface gráfica (WinForms ou WPF)  
- Versão Web com ASP.NET  
- Múltiplas contas e extratos  
- Autenticação de usuário

---

##  Licença

Projeto livre para estudo.

