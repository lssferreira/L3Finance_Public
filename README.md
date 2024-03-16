
# L3 Finance 💸

Este é um projeto de uma aplicação para gerenciar contas a pagar, fornecendo funcionalidades de consulta e cadastro. 

## Tecnologias Utilizadas
+ .NET 8 - Plataforma de desenvolvimento para construção de aplicativos modernos e de alto desempenho em C#
+ ASP.NET Core - Framework para construção de aplicativos web e APIs em C#
+ Entity Framework Core - Mapeamento objeto-relacional para acesso a dados em .NET
+ Blazor - Framework para construção de aplicativos web interativos usando .NET
+ MudBlazor - Uma biblioteca de componentes UI para Blazor, baseada em Material Design
+ xUnit - Framework de teste de unidade para .NET Core

# 🛠️ Abrir e rodar o projeto localmente

1. **Abrir com a IDE**:
   - Escolha a sua IDE de preferência. Recomendado:
     - [Visual Studio Community](https://visualstudio.microsoft.com/pt-br/vs/community/)

2. **Abrir o Projeto**:
   - No Visual Studio Community:
       - Abra o Visual Studio Community.
   - No menu, selecione "Arquivo" > "Abrir" > "Projeto/Solução".
   - Selecione **L3Finance.sln**
     
3. **Geração do banco de dados**
    - Clique com o botão direito sobre o projeto Shared.Data
      - Selecione a opção **Definir projeto de inicialização**
    - No menu, selecione > "Ferramentas" > "Gerenciado de pacotes do Nuget" > "Console do Gerenciado de Pacotes"
    - Execute o comando: `` Update-Database``

4. **Executar o projeto**:
   - Definir o projeto de inicialização
     - Vá em propriedades na solução
     - Em configurar projetos de inicialização marque a opção "Vários projetos de inicialização"
     - Selecione o perfil de inicialização personalizado (API+WEB)

## Status

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge)


