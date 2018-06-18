# Teste QA Automation - Sistema Orange HRM

Foram efetuados testes de acesso ao sistema
- Login
  - Usuário ou senha inválidos ou vazios;
  - Usuário e senha corretos
- Logout

Pontos de verificação:
- Se está na página inicial (logado com sucesso)
- Se logou com user e senha incorretos (login com falha)
- Se efetuou logout com sucesso

Tecnologias utlizadas:

Visual Studio 2015 - C#
Specflow (Escrita dos cenários em BDD)
ExtentReport (Geração de Report)

# Instalação do projeto e configuração de ambiente

No Visual Studio:
 Vá em Tools –> Extension and Updates –> Procurar por SpecFlow

Após, clicar com o botão direito em cima do projeto e ir em "Manage Nuget Packages..."
e instalar o SpecFlow e SpecFlow.NUnit

Importar no nuget todas as referências (dll):
clique com o botão direito em cima do projeto e acesse "Manage Nuget Packages..." Vá em Browse e procure pelos seguintes pacotes:

- Nunit e instale o Nunit(v3.9.0);
- Nunit3TestAdapter instale o  Nunit3TestAdapter(v3.9.0);
- Utilizar a dll RelevantCodes.ExtentReports.dll (encontra-se na pasta bin do projeto):
Na estrutura do projeto, clique com o botão direito em R*eferences->add reference...->Clique em "Browse..."* e vá na pasta do 
projeto "TesteWebQA\bin\Debug" e selecione RelevantCodes.ExtentReports.dll e clique em "Add" e "Ok".
