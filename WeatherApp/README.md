# WeatherApp - Aplicação Blazor de Previsão do Tempo

Este é um projeto de demonstração que utiliza Blazor para exibir informações de previsão do tempo.

## Pré-requisitos

- .NET 8.0 SDK
- Visual Studio 2022 ou VS Code com extensões C#
- Docker (para execução em container)

## Como Executar Localmente

1. Clone o repositório:
```bash
git clone [URL_DO_SEU_REPOSITORIO]
cd WeatherApp
```

2. Usando .NET diretamente:
```bash
dotnet restore
dotnet run
```

3. Ou usando Docker:
```bash
docker build -t weatherapp .
docker run -p 8080:8080 weatherapp
```

4. Acesse a aplicação em `http://localhost:8080`

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
   - Build da imagem Docker

## Deploy no Render.com

1. Crie uma conta no [Render.com](https://render.com)
2. Crie um novo Web Service e selecione "Docker" como runtime environment
3. Conecte seu repositório GitHub
4. Configure:
   - Branch: main
   - Root Directory: ./WeatherApp
   - Docker Command: deixe vazio (será usado o Dockerfile)

O deploy será automático sempre que houver um push na branch main.

## Estrutura do Projeto

- `/Components` - Componentes Blazor
- `/Components/Pages` - Páginas da aplicação
- `/WeatherApp.Tests` - Testes unitários
- `/.github/workflows` - Configurações do GitHub Actions
- `/Dockerfile` - Configuração do container Docker

## Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request 