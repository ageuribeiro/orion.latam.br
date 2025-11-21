# Clean Architecture Python Template

Bem-vindo ao **Clean Architecture Python Template**, um modelo profissional e minimalista criado para ajudar desenvolvedores ao redor do mundo a iniciar projetos Python utilizando os princípios de **Clean Architecture**, **independência de camadas** e **separação clara de responsabilidades**.

Este template foi construído para ser simples, direto e reutilizável — ideal para aplicações de console (CLI), serviços, microserviços, automações e até bases para APIs.

---

## 📌 Objetivo

Fornecer uma estrutura inicial que:

* aplique conceitos da Clean Architecture de Robert C. Martin;
* separe regras de negócio de infraestrutura e interface;
* facilite testes, manutenção e escalabilidade;
* funcione em qualquer ambiente Python sem dependências externas.

---

## 🏗️ Estrutura do Projeto

A estrutura gerada segue o fluxo **Interface → Application → Domain**, com dependências sempre apontando para dentro.

```
clean_project/
│
├── domain/
│   ├── entities/
│   └── value_objects/
│
├── application/
│   ├── interfaces/
│   └── use_cases/
│
├── infrastructure/
│   ├── repositories/
│   └── services/
│
├── interface/
│   └── cli/
│       └── commands/
│
├── main.py
└── pyproject.toml (opcional)
```

---

## 🔄 Fluxo da Arquitetura

A comunicação entre camadas segue esta ordem:

```
Interface (CLI) → Application (Use Cases) → Domain
                     ↓
                 Infrastructure
```

### Domínio (**domain/**)

Contém as regras de negócio mais puras: entidades e value objects.

### Aplicação (**application/**)

Implementa casos de uso, orquestra lógica e conversa com interfaces externas via portas (interfaces).

### Infraestrutura (**infrastructure/**)

Implementações concretas de bancos, serviços externos, arquivos, APIs, etc.

### Interface (**interface/**)

Onde a aplicação "fala" com o usuário. Neste template: uma CLI simples.

---

## ▶️ Execução

Após criar o projeto, basta executar:

```bash
python main.py
```

Saída esperada:

```
=== Console Application - Clean Architecture (Python) ===
Hello World from Clean Architecture!
```

---

## 📂 Arquivos Iniciais

### **main.py**

```python
from interface.cli.run import run_cli

if __name__ == "__main__":
    run_cli()
```

### **interface/cli/run.py**

```python
from interface.cli.commands.hello import hello_command

def run_cli():
    print("=== Console Application - Clean Architecture (Python) ===")
    hello_command()
```

### **interface/cli/commands/hello.py**

```python
from application.use_cases.hello_use_case import HelloUseCase

def hello_command():
    result = HelloUseCase().execute()
    print(result)
```

### **application/use_cases/hello_use_case.py**

```python
class HelloUseCase:
    def execute(self):
        return "Hello World from Clean Architecture!"
```

---

## 🧪 Testes

Recomenda-se criar a seguinte estrutura:

```
tests/
│
├── domain/
├── application/
└── interface/
```

Execute testes com:

```bash
pytest
```

---

## 🌍 Principais Benefícios

* Independência entre camadas
* Domínio puro e testável
* Fácil evolução
* Infraestrutura substituível
* CLI simples e robusta
* Código limpo e organizado
* Perfeito para projetos didáticos ou enterprise

---

## 🗺️ Roadmap

* Script automatizado de criação (PowerShell/Linux/macOS)
* Template ZIP
* Template Cookiecutter
* Publicação no PyPI (`cleanarch-init`)
* Versão para FastAPI/Flask

---

## 🤝 Contribuições

Pull Requests são bem-vindos! O objetivo é transformar este template na **melhor referência de Clean Architecture em Python** disponível publicamente.

Se deseja sugerir melhorias, abra uma Issue!

---

## 📄 Licença

Este projeto é licenciado sob a licença **MIT**. Use livremente.

---

## 💬 Autor

Criado com o objetivo de fornecer um **padrão global acessível e profissional** para Python.

---

Se quiser, posso agora gerar:

* o **script PowerShell para criar este template automaticamente**;
* o **template ZIP**;
* o **cookiecutter**;
* ou a **página inicial do repositório GitHub**.

Só dizer: *"Vamos para o próximo passo"*.
