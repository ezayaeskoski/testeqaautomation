# Teste QA Automation - Sistema Orange HRM

Foram efetuados testes de acesso ao sistema
- Login
  - Usuário ou senha inválidos ou vazios;
  - Usuário e senha corretos.
- Logout

<b>Pontos de verificação:</b>
- Se está na página inicial (logado com sucesso);
- Se logou com user e senha incorretos (login com falha);
- Se efetuou logout com sucesso.

As evidências dos testes encontram-se dentro da pasta "Reports" em "TesteWebQA\Reports"

<b>Tecnologias utlizadas:</b>

- Visual Studio 2015 - C#;
- Specflow (Escrita dos cenários em BDD);
- ExtentReport (Geração de Report).

# Instalação do projeto e configuração de ambiente

<b>No Visual Studio:</b>
 - Vá em Tools –> Extension and Updates –> Procurar por SpecFlow;
 - Reiniciar a IDE.
 
 <b>Instalar o projeto:</b>
- Fazer o clone do projeto ou efetuar o download;
- Abrir a solution TesteWebQA.sln

Após, clicar com o botão direito em cima do projeto e ir em "Manage Nuget Packages..."
e instalar o SpecFlow e SpecFlow.NUnit

<b>Importar no nuget todas as referências (dll):</b>
clique com o botão direito em cima do projeto e acesse "Manage Nuget Packages..." Vá em Browse e procure pelos seguintes pacotes:

- Nunit e instale o Nunit(v3.9.0);
- Nunit3TestAdapter instale o  Nunit3TestAdapter(v3.9.0);
- Utilizar a dll RelevantCodes.ExtentReports.dll (encontra-se na pasta bin do projeto):
Na estrutura do projeto, clique com o botão direito em R*eferences->add reference...->Clique em "Browse..."* e vá na pasta do 
projeto "TesteWebQA\bin\Debug" e selecione RelevantCodes.ExtentReports.dll e clique em "Add" e "Ok".


