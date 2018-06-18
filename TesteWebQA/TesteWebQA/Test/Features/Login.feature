#language: pt-br

Funcionalidade: Verificações de Login para o sistema OrangeHRM

Contexto: 
Dado que acesso o sistema OrangeHRM

Esquema do Cenário: Realizar Login no sistema com sucesso
Dado que esteja na página de Login
Quando inserir os dados de "<USUARIO>" e "<SENHA>" e efetuar o login
Então a página inicial do sistema é apresentada

Exemplos: 
| USUARIO | SENHA |
|  admi8n | admin |
|  admin  | admin |

Cenário: Realizar Logout no sistema com sucesso
Dado que esteja logado no sistema
Quando clicar no botão Logout
Então a página de login é apresentada