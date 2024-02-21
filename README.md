# Validação de Senha - README

## Introdução
Este projeto consiste em uma aplicação em .NET que expõe uma API web para validar senhas de acordo com critérios específicos. A validação é realizada através de uma requisição HTTP, onde é fornecida uma senha como entrada e a API responde com um booleano indicando se a senha é válida ou não, juntamente com uma lista de erros, caso a senha seja inválida.

## Especificações da Senha
Uma senha é considerada válida quando atende aos seguintes critérios:
- Deve conter nove ou mais caracteres.
- Deve conter pelo menos um dígito.
- Deve conter pelo menos uma letra minúscula.
- Deve conter pelo menos uma letra maiúscula.
- Deve conter pelo menos um caractere especial dos seguintes: !@#$%^&*()-+.
- Não pode possuir caracteres repetidos dentro do conjunto.
- Espaços em branco não são considerados como caracteres válidos.

## Exemplos de Senhas
- `IsValid("")` retorna `false`
- `IsValid("aa")` retorna `false`
- `IsValid("ab")` retorna `false`
- `IsValid("AAAbbbCc")` retorna `false`
- `IsValid("AbTp9!foo")` retorna `false`
- `IsValid("AbTp9!foA")` retorna `false`
- `IsValid("AbTp9 fok")` retorna `false`
- `IsValid("AbTp9!fok")` retorna `true`

## Executando o Projeto
Para executar o projeto, siga as instruções abaixo:
1. Clone este repositório em seu ambiente local.
2. Certifique-se de ter o ambiente .NET configurado em sua máquina.
3. Abra o projeto em seu ambiente de desenvolvimento preferido (Visual Studio, Visual Studio Code, etc.).
4. Compile e execute a aplicação.
5. Após a execução, a API estará disponível para receber requisições de validação de senha.

## Detalhes da Solução
### Arquitetura
A arquitetura do projeto segue os padrões convencionais do ASP.NET Web API, com separação clara entre camadas de apresentação, lógica de negócio e modelos de dados. A utilização de um controlador (`ValidacaoController`) permite a exposição de endpoints HTTP para validação de senhas, enquanto os modelos de dados (`PasswordValidationResult`) encapsulam os resultados da validação.

### Decisões de Design
- **Abstração e Coesão**: As funcionalidades foram separadas em métodos e classes distintas, promovendo a reutilização e a manutenibilidade do código.
- **Acoplamento**: As dependências entre os componentes foram minimizadas, permitindo uma fácil extensão e modificação do sistema.
- **Clean Code**: O código foi escrito seguindo as melhores práticas de codificação, com nomes significativos de variáveis, métodos e classes, facilitando a compreensão e a manutenção.
- **SOLID**: Os princípios SOLID foram aplicados sempre que possível, visando a construção de um sistema robusto e escalável.

## Premissas Assumidas
Durante o desenvolvimento do projeto, algumas premissas foram assumidas:
- A API é acessada somente por usuários autorizados e autenticados.
- As validações de entrada foram limitadas ao escopo do problema apresentado, não incluindo validações adicionais, como sanitização de dados.

## Conclusão
Este projeto foi desenvolvido com o objetivo de fornecer uma solução robusta e escalável para validação de senhas em uma API web. A estruturação do código, aliada às melhores práticas de desenvolvimento, visa garantir a qualidade e a eficiência do sistema.

Para mais detalhes, sugestões ou melhorias, sinta-se à vontade para entrar em contato ou abrir uma issue neste repositório.

---

**Autor:** Paula Pereira Petroniho

**Data de Criação:** 21/02/2024

**Versão:** 1.0
