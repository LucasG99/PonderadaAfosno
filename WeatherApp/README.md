# WeatherApp - Aplicação Blazor de Previsão do Tempo

## Resumo

Este documento apresenta a documentação técnica do projeto *WeatherApp, uma aplicação de demonstração desenvolvida com **Blazor* (Server-Side) para exibir informações de previsão do tempo. O projeto foi construído utilizando *.NET 8.0, com uma esteira de CI/CD completa via **GitHub Actions, testes unitários e deploy automatizado no **Render.com*. A aplicação é baseada no template padrão do Blazor Weather, com personalizações para atender aos requisitos do projeto.

---

## 1 Introdução

O *WeatherApp* é um projeto acadêmico e prático que demonstra o uso do framework *Blazor* para criar aplicações web interativas. A aplicação exibe informações de previsão do tempo e inclui uma página de contador como exemplo adicional de funcionalidade. Este documento detalha os pré-requisitos, a estrutura do projeto, instruções de execução, testes, pipeline de CI/CD e orientações para contribuições.

## 2 Pré-requisitos

Para executar e contribuir com o projeto, é necessário ter as seguintes ferramentas instaladas:

- *.NET 8.0 SDK*: Disponível em [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
- *Visual Studio 2022* ou *VS Code* com extensões para C# (ex.: C# for Visual Studio Code).
- *Docker*: Necessário para execução em container (opcional).
- *Git*: Para clonar o repositório e gerenciar o controle de versão.
- Conta no *Render.com* ou *Railway.app* para deploy.

## 3 Estrutura do Projeto

A estrutura de pastas do projeto é organizada para facilitar o desenvolvimento e a manutenção. Abaixo está a representação textual da estrutura de pastas, conforme visualizada no ambiente de desenvolvimento:

WeatherApp/

├── .github/

│   └── workflows/

│       └── ci-cd.yml

├── Components/

│   ├── layout/

│   │   ├── MainLayout.razor

│   │   ├── MainLayout.razor.css

│   │   ├── NavMenu.razor

│   │   └── NavMenu.razor.css

│   ├── Pages/

│   │   ├── Counter.razor

│   │   ├── Error.razor

│   │   ├── Home.razor

│   │   ├── Weather.razor

│   │   ├── Imports.razor

│   │   └── App.razor

│   └── Routes.razor

├── obj/

│   ├── project.assets.json

│   ├── project.nuget.cache

│   ├── WeatherApp.csproj.nuget.dgspec.json

│   ├── WeatherApp.csproj.nuget.g.props

│   └── WeatherApp.csproj.nuget.g.targets

├── Properties/

│   └── launchSettings.json

├── WeatherApp.Tests/

│   ├── obj/

│   │   ├── project.assets.json

│   │   ├── project.nuget.cache

│   │   ├── WeatherApp.Tests.csproj.nuget.d...

│   │   ├── WeatherApp.Tests.csproj.nuget.g...

│   │   └── WeatherApp.Tests.csproj.nuget.g...

│   ├── UnitTest1.cs

│   └── WeatherApp.Tests.csproj

├── wwwroot/

│   ├── bootstrap/

│   │   ├── css/

│   │   │   ├── bootstrap-grid.css

│   │   │   ├── bootstrap-grid.css.map

│   │   │   ├── bootstrap-grid.min.css

│   │   │   ├── bootstrap-grid.min.css.map

│   │   │   ├── bootstrap-grid.rtl.css

│   │   │   ├── bootstrap-grid.rtl.css.map

│   │   │   ├── bootstrap-grid.rtl.min.css

│   │   │   ├── bootstrap-grid.rtl.min.css.map

│   │   │   ├── bootstrap-reboot.css

│   │   │   ├── bootstrap-reboot.css.map

│   │   │   ├── bootstrap-reboot.min.css

│   │   │   ├── bootstrap-reboot.min.css.map

│   │   │   ├── bootstrap-reboot.rtl.css

│   │   │   ├── bootstrap-reboot.rtl.css.map

│   │   │   ├── bootstrap-reboot.rtl.min.css

│   │   │   ├── bootstrap-reboot.rtl.min.css.map

│   │   │   ├── bootstrap-utilities.css

│   │   │   ├── bootstrap-utilities.css.map

│   │   │   ├── bootstrap-utilities.min.css

│   │   │   ├── bootstrap-utilities.min.css.map

│   │   │   ├── bootstrap-utilities.rtl.css

│   │   │   ├── bootstrap-utilities.rtl.css.map

│   │   │   ├── bootstrap-utilities.rtl.min.css

│   │   │   ├── bootstrap-utilities.rtl.min.css.map

│   │   │   ├── bootstrap.css

│   │   │   ├── bootstrap.css.map

│   │   │   ├── bootstrap.min.css

│   │   │   ├── bootstrap.min.css.map

│   │   │   ├── bootstrap.rtl.css

│   │   │   ├── bootstrap.rtl.css.map

│   │   │   ├── bootstrap.rtl.min.css

│   │   │   └── bootstrap.rtl.min.css.map

│   │   └── js/

│   │       ├── bootstrap.bundle.js

│   │       ├── bootstrap.bundle.js.map

│   │       ├── bootstrap.bundle.min.js

│   │       ├── bootstrap.bundle.min.js.map

│   │       ├── bootstrap.esm.js

│   │       ├── bootstrap.esm.js.map

│   │       ├── bootstrap.esm.min.js

│   │       ├── bootstrap.esm.min.js.map

│   │       ├── bootstrap.js

│   │       ├── bootstrap.js.map

│   │       ├── bootstrap.min.js

│   │       └── bootstrap.min.js.map

│   ├── css/

│   │   ├── app.css

│   │   └── favicon.png

│   ├── dockerignore

│   ├── appsettings.Development.json

│   ├── appsettings.json

│   └── Dockerfile

├── Program.cs

├── README.md

└── WeatherApp.csproj

3.1 Descrição das Principas Pastas e Arquivos

/.github/workflows: Contém o arquivo ci-cd.yml para a pipeline de CI/CD.

/Components: componentes reutilizáveis do Blazor

/Pages: Páginas da aplicação, como Counter.razor, Home.razor, e Weather.razor

MainLayout.razor: Layout principal da aplicação.

NavMenu.razor: Componente de navegação lateral.

/Properties: Configurações do projeto, como launchSettings.json.

/wwwroot: Arquivos estáticos, como CSS e JavaScript.

/css: Estilos da aplicação, incluindo arquivos do Bootstrap.

/lib/bootstrap: Biblioteca Bootstrap para estilização

/WeatherApp.Tests: Testes unitários do projeto

WeatherApp.Tests.csproj: Arquivo de projeto para os testes.

UnitTest1.cs: Arquivo de testes unitários

/Dockerfile: Arquivo de configuração para criar a imagem Docker.

Program.cs: ponto de entrada da aplicação

WeatherApp.csproj: Arquivo de projeto principal.

## Parte 3: Como Executar Localmente

### 4. Como Executar Localmente

#### 4.1 Clonando o Repositório

Clone o repositório do GitHub:

```bash
git clone [URL_DO_SEU_REPOSITORIO]
cd WeatherApp
```

#### 4.2 Usando o .NET CLI

Restaure as dependências:

```bash
dotnet restore
```

Execute a aplicação:

```bash
dotnet run
```

Acesse a aplicação em [http://localhost:8080](http://localhost:8080).

#### 4.3 Usando Docker

Construa a imagem Docker:

```bash
docker build -t weatherapp .
```

Execute o container:

```bash
docker run -p 8080:8080 weatherapp
```

Acesse a aplicação em [http://localhost:8080](http://localhost:8080).

#### 4.4 Descrição da Interface da Aplicação

A aplicação possui uma interface simples com uma barra de navegação lateral à esquerda, contendo links para as páginas **"Home"**, **"Counter"** e **"Weather"**.

- A página **"Counter"** exibe um título *"Counter"*, um texto indicando a contagem atual (inicialmente 0) e um botão azul com o texto *"Click me"* para incrementar o contador.
- No canto superior direito, há um link *"About"*.

