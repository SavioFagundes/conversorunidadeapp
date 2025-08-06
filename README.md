# 🔄 Conversor de Unidades Universal

Uma aplicação web desenvolvida em **ASP.NET Core 9.0** com **Razor Pages** para conversão de diferentes tipos de unidades de medida.

![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-512BD4?style=for-the-badge&logo=dotnet)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=for-the-badge&logo=bootstrap)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

## 📋 Descrição

O **ConversorUnidadesApp** é uma ferramenta web intuitiva que permite aos usuários converter facilmente entre diferentes unidades de medida. A aplicação oferece conversões para:

- 📏 **Comprimento** - metros, centímetros, polegadas, pés, etc.
- ⚖️ **Peso** - quilos, gramas, libras, onças, etc.  
- 🌡️ **Temperatura** - Celsius, Fahrenheit, Kelvin

## ✨ Características

- 🎨 **Interface Responsiva** - Design moderno com Bootstrap 5
- ⚡ **Performance Otimizada** - Built com ASP.NET Core 9.0
- 🔒 **Seguro** - HTTPS por padrão
- 📱 **Mobile-Friendly** - Funciona perfeitamente em dispositivos móveis
- 🌐 **Cross-Platform** - Roda em Windows, Linux e macOS

## 🛠️ Tecnologias Utilizadas

- **Framework**: ASP.NET Core 9.0
- **Arquitetura**: Razor Pages
- **Frontend**: HTML5, CSS3, Bootstrap 5.3
- **Backend**: C# 12
- **IDE**: Visual Studio 2022 / VS Code

## 📦 Pré-requisitos

Antes de executar o projeto, certifique-se de ter instalado:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) ou superior
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/) para controle de versão

## 🚀 Como Executar

### 1. Clone o repositório
```bash
git clone https://github.com/SavioFagundes/conversorunidadeapp.git
cd conversorunidadeapp
```

### 2. Restaure as dependências
```bash
dotnet restore
```

### 3. Execute a aplicação
```bash
dotnet run
```

### 4. Acesse no navegador
- **HTTPS**: https://localhost:7294
- **HTTP**: http://localhost:5131

## 📁 Estrutura do Projeto

```
ConversorUnidadesApp/
├── 📄 Program.cs                    # Ponto de entrada da aplicação
├── 📄 ConversorUnidadesApp.csproj   # Arquivo de projeto
├── 📁 Pages/                        # Razor Pages
│   ├── 📄 Index.cshtml              # Página inicial
│   ├── 📄 Index.cshtml.cs           # Code-behind da página inicial
│   ├── 📁 Shared/                   # Layouts compartilhados
│   │   ├── 📄 _Layout.cshtml        # Layout principal
│   │   └── 📄 _ValidationScriptsPartial.cshtml
│   ├── 📄 _ViewImports.cshtml       # Imports globais
│   └── 📄 _ViewStart.cshtml         # Configurações iniciais
├── 📁 wwwroot/                      # Arquivos estáticos
│   ├── 📁 css/                      # Estilos CSS
│   ├── 📁 js/                       # Scripts JavaScript
│   ├── 📁 lib/                      # Bibliotecas (Bootstrap, jQuery)
│   └── 📄 favicon.ico               # Ícone da aplicação
├── 📁 Properties/
│   └── 📄 launchSettings.json       # Configurações de execução
├── 📄 appsettings.json              # Configurações da aplicação
└── 📄 appsettings.Development.json  # Configurações de desenvolvimento
```

## 🎯 Funcionalidades Planejadas

- [x] Interface inicial com navegação
- [ ] Conversor de Comprimento
- [ ] Conversor de Peso  
- [ ] Conversor de Temperatura
- [ ] Histórico de conversões
- [ ] API REST para conversões
- [ ] Testes unitários
- [ ] Deploy automatizado

## 🌐 Screenshots

### Página Inicial
![Página Inicial](docs/images/home-page.png)

*Tela inicial com opções de conversão disponíveis*

## 🔧 Configuração de Desenvolvimento

### Variáveis de Ambiente
```json
{
  "ASPNETCORE_ENVIRONMENT": "Development",
  "ASPNETCORE_URLS": "https://localhost:7294;http://localhost:5131"
}
```

### Comandos Úteis
```bash
# Compilar o projeto
dotnet build

# Executar em modo watch (hot reload)
dotnet watch run

# Publicar para produção
dotnet publish -c Release -o ./publish

# Executar testes
dotnet test
```

## 📖 Como Contribuir

1. **Fork** o projeto
2. Crie uma **branch** para sua feature (`git checkout -b feature/nova-conversao`)
3. **Commit** suas mudanças (`git commit -am 'Adiciona conversor de volume'`)
4. **Push** para a branch (`git push origin feature/nova-conversao`)
5. Abra um **Pull Request**

### 🎨 Padrões de Código
- Use **PascalCase** para nomes de classes e métodos
- Use **camelCase** para variáveis locais
- Siga as convenções do **C# Coding Standards**
- Comente código complexo
- Escreva testes para novas funcionalidades

## 🐛 Reportar Bugs

Encontrou um bug? Abra uma [issue](https://github.com/SavioFagundes/conversorunidadeapp/issues) com:

- Descrição detalhada do problema
- Passos para reproduzir
- Screenshots (se aplicável)
- Informações do ambiente (OS, .NET version, etc.)

## 📄 Licença

Este projeto está licenciado sob a **MIT License** - veja o arquivo [LICENSE](LICENSE) para detalhes.

## 👥 Autores

- **Savio Fagundes** - *Desenvolvimento inicial* - [@SavioFagundes](https://github.com/SavioFagundes)

## 🙏 Agradecimentos

- [ASP.NET Core Team](https://github.com/dotnet/aspnetcore) pela excelente framework
- [Bootstrap Team](https://getbootstrap.com/) pelo framework CSS
- Comunidade .NET pela documentação e suporte

## 📞 Contato

- **GitHub**: [@SavioFagundes](https://github.com/SavioFagundes)
- **Email**: saviofagundesmrq@gmail.com
- **LinkedIn**: [Seu Perfil](https://www.linkedin.com/in/saviofagundes/)

---

⭐ **Se este projeto foi útil para você, considere dar uma estrela!** ⭐

<div align="center">
  <sub>Feito com ❤️ por <a href="https://github.com/SavioFagundes">Savio Fagundes</a></sub>
</div>
