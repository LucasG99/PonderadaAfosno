# WeatherApp - Aplicação Blazor de Previsão do Tempo

Este é um projeto de demonstração que utiliza Blazor para exibir informações de previsão do tempo.

## Pré-requisitos

- .NET 8.0 SDK
- Visual Studio 2022 ou VS Code com extensões C#

## Como Executar Localmente

1. Clone o repositório:
```bash
git clone [URL_DO_SEU_REPOSITORIO]
cd WeatherApp
```

2. Restaure as dependências:
```bash
dotnet restore
```

3. Execute o projeto:
```bash
dotnet run
```

4. Acesse a aplicação em `https://localhost:5001` ou `http://localhost:5000`

## Executando os Testes

Para executar os testes unitários:

```bash
dotnet test
```

## CI/CD Pipeline

O projeto utiliza GitHub Actions para CI/CD com as seguintes etapas:

1. **Build e Teste**
   - Restauração de dependências
   - Compilação do projeto
   - Execução de testes unitários

2. **Deploy**
   - Deploy automático para o Render.com quando alterações são enviadas para a branch main
   - Requer configuração do `RENDER_API_KEY` nos secrets do GitHub

## Configuração do Deploy no Render.com

1. Crie uma conta no [Render.com](https://render.com)
2. Crie um novo Web Service
3. Conecte seu repositório GitHub
4. Configure as seguintes variáveis de ambiente:
   - `ASPNETCORE_ENVIRONMENT`: Production
   - Outras variáveis específicas do seu ambiente

## Estrutura do Projeto

- `/Components` - Componentes Blazor
- `/Components/Pages` - Páginas da aplicação
- `/WeatherApp.Tests` - Testes unitários
- `/.github/workflows` - Configurações do GitHub Actions

## Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request 