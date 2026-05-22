# Prompt:
  - Configure o projeto e organize dentro de cada módulo as Entidades, os Repositorios, os controllers, os viewmodels e as views. Os controllers, os viewsModels e as views coloque-os dentro da pasta apresentação. Dentro da pasta de cada modulo organize as entidades dentro de uma pasta chamada dominio e os repositorios dentro de uma pasta chamada infra. Configure o asp.net mvc para funcionar desta forma

  - Altere o plano para seguir a estrutura abaixo. Removendo dentro da pasta views o nome do módulo. Remova também os diretórios "Controllers" e "ViewModels" dentro de "Views". Crie também um módulo chamado "Home" e organize os arquivos dentro dele. E o que for compartilhado

# Reorganização Modular do Projeto

## Contexto

O projeto atualmente possui uma organização modular básica (ModuloChamado, ModuloEquipamento, ModuloFabricante) onde cada módulo contém entidades e repositórios. Porém, Controllers, Views e ViewModels estão numa pasta centralizada (/Apresentação).

O objetivo é reorganizar cada módulo seguindo arquitetura em camadas clara:
- **Dominio/** - Entidades de negócio
- **Infra/** - Repositórios e persistência
- **Apresentacao/** - Controllers, ViewModels e Views

Isso melhora a coesão modular, facilita manutenção e deixa cada módulo auto-contido.

## Estrutura Alvo

```
ModuloChamado/
├── Dominio/
│   └── Chamado.cs
├── Infra/
│   └── RepositorioChamadoEmArquivo.cs
└── Apresentacao/
    └── ChamadoController.cs
    └── ChamadoViewModels.cs    
    └── Views/
        ├── Listar.cshtml
        ├── Cadastrar.cshtml
        ├── Editar.cshtml
        └── Excluir.cshtml

ModuloEquipamento/
├── Dominio/
│   └── Equipamento.cs
├── Infra/
│   └── RepositorioEquipamentoEmArquivo.cs
└── Apresentacao/
    └── EquipamentoController.cs    
    └── EquipamentoViewModels.cs
    └── Views/    
        ├── Listar.cshtml
        ├── Cadastrar.cshtml
        ├── Editar.cshtml
        └── Excluir.cshtml

ModuloFabricante/
├── Dominio/
│   └── Fabricante.cs
├── Infra/
│   └── RepositorioFabricanteEmArquivo.cs
└── Apresentacao/
    └── FabricanteController.cs    
    └── FabricanteViewModels.cs
    └── Views/
        ├── Listar.cshtml
        ├── Cadastrar.cshtml
        ├── Editar.cshtml
        └── Excluir.cshtml

ModuloHome/
└── Apresentacao/
    └── HomeController.cs        
    └── Views/
        └── Index.cshtml
        
Compartilhado
|── Apresentacao
|   └── Views/    
|       ├── _Layout.cshtml
|       └── _ViewImports.cshtml
|── Dominio
└── Infra
```

## Plano de Implementação

### Etapa 1: Reorganizar ModuloFabricante

1. **Criar estrutura de pastas:**
   - ModuloFabricante/Dominio/
   - ModuloFabricante/Infra/
   - ModuloFabricante/Apresentacao/Controllers/
   - ModuloFabricante/Apresentacao/ViewModels/
   - ModuloFabricante/Apresentacao/Views/Fabricante/

2. **Mover e ajustar arquivos:**
   - ModuloFabricante/Fabricante.cs → Dominio/Fabricante.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante.Dominio`
   - ModuloFabricante/RepositorioFabricanteEmArquivo.cs → Infra/RepositorioFabricanteEmArquivo.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante.Infra`
     - Ajustar using para Dominio
   - Controllers/FabricanteController.cs → Apresentacao/Controllers/FabricanteController.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante.Apresentacao.Controllers`
     - Ajustar usings para Dominio, Infra e ViewModels
   - Models/FabricanteViewModels.cs → Apresentacao/ViewModels/FabricanteViewModels.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante.Apresentacao.ViewModels`
   - Views/Fabricante/*.cshtml → Apresentacao/Views/Fabricante/*.cshtml

### Etapa 2: Reorganizar ModuloEquipamento

1. **Criar estrutura de pastas:**
   - ModuloEquipamento/Dominio/
   - ModuloEquipamento/Infra/
   - ModuloEquipamento/Apresentacao/Controllers/
   - ModuloEquipamento/Apresentacao/ViewModels/
   - ModuloEquipamento/Apresentacao/Views/Equipamento/

2. **Mover e ajustar arquivos:**
   - ModuloEquipamento/Equipamento.cs → Dominio/Equipamento.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento.Dominio`
     - Ajustar using para ModuloFabricante.Dominio
   - ModuloEquipamento/RepositorioEquipamentoEmArquivo.cs → Infra/RepositorioEquipamentoEmArquivo.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento.Infra`
   - Controllers/EquipamentoController.cs → Apresentacao/Controllers/EquipamentoController.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento.Apresentacao.Controllers`
   - Models/EquipamentoViewModels.cs → Apresentacao/ViewModels/EquipamentoViewModels.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento.Apresentacao.ViewModels`
   - Views/Equipamento/*.cshtml → Apresentacao/Views/Equipamento/*.cshtml

### Etapa 3: Reorganizar ModuloChamado

1. **Criar estrutura de pastas:**
   - ModuloChamado/Dominio/
   - ModuloChamado/Infra/
   - ModuloChamado/Apresentacao/Controllers/
   - ModuloChamado/Apresentacao/ViewModels/
   - ModuloChamado/Apresentacao/Views/Chamado/

2. **Mover e ajustar arquivos:**
   - ModuloChamado/Chamado.cs → Dominio/Chamado.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloChamado.Dominio`
     - Ajustar using para ModuloEquipamento.Dominio
   - ModuloChamado/RepositorioChamadoEmArquivo.cs → Infra/RepositorioChamadoEmArquivo.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloChamado.Infra`
   - Controllers/ChamadoController.cs → Apresentacao/Controllers/ChamadoController.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloChamado.Apresentacao.Controllers`
   - Models/ChamadoViewModels.cs → Apresentacao/ViewModels/ChamadoViewModels.cs
     - Namespace: `GestaoDeEquipamentosWeb.ConsoleApp.ModuloChamado.Apresentacao.ViewModels`
   - Views/Chamado/*.cshtml → Apresentacao/Views/Chamado/*.cshtml

### Etapa 4: Configurar ASP.NET MVC

**Arquivo:** Program.cs

1. **Configurar localização de Views:**
```csharp
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        // Formato padrão para Views em módulos
        options.ViewLocationFormats.Clear();
        
        // Módulos com estrutura Apresentacao/Views
        options.ViewLocationFormats.Add("/{1}/Apresentacao/Views/{0}.cshtml");
        options.ViewLocationFormats.Add("/Modulo{1}/Apresentacao/Views/{1}/{0}.cshtml");
        
        // Views compartilhadas
        options.ViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
        options.ViewLocationFormats.Add("/Views/{1}/{0}.cshtml");
        
        // Área compartilhada (fallback)
        options.ViewLocationFormats.Add("/Views/{0}.cshtml");
    });
```

**Explicação dos formatos:**
- `{0}` = nome da view (ex: "Listar")
- `{1}` = nome do controller sem "Controller" (ex: "Fabricante")
- `/Modulo{1}/Apresentacao/Views/{1}/{0}.cshtml` permite que:
  - Controller "FabricanteController" busque views em "/ModuloFabricante/Apresentacao/Views/Fabricante/Listar.cshtml"

2. **Adicionar _ViewImports.cshtml em cada módulo:**

Criar em cada `Modulo*/Apresentacao/Views/` um arquivo `_ViewImports.cshtml`:
```cshtml
@using GestaoDeEquipamentosWeb.ConsoleApp
@using GestaoDeEquipamentosWeb.ConsoleApp.Modulo[Nome].Apresentacao.ViewModels
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

### Etapa 5: Limpar pastas antigas

1. Excluir pasta `/Controllers/` (manter apenas HomeController.cs se não for modularizado)
2. Excluir pasta `/Models/` (após mover todos ViewModels)
3. Excluir pastas `/Views/Fabricante/`, `/Views/Equipamento/`, `/Views/Chamado/`
4. Manter `/Views/Home/` e `/Views/Shared/`

## Arquivos Críticos

### Arquivos a serem movidos:

**ModuloFabricante:**
- `ModuloFabricante/Fabricante.cs`
- `ModuloFabricante/RepositorioFabricanteEmArquivo.cs`
- `Controllers/FabricanteController.cs`
- `Models/FabricanteViewModels.cs`
- `Views/Fabricante/Listar.cshtml`
- `Views/Fabricante/Cadastrar.cshtml`
- `Views/Fabricante/Editar.cshtml`
- `Views/Fabricante/Excluir.cshtml`

**ModuloEquipamento:**
- `ModuloEquipamento/Equipamento.cs`
- `ModuloEquipamento/RepositorioEquipamentoEmArquivo.cs`
- `Controllers/EquipamentoController.cs`
- `Models/EquipamentoViewModels.cs`
- `Views/Equipamento/Listar.cshtml`
- `Views/Equipamento/Cadastrar.cshtml`
- `Views/Equipamento/Editar.cshtml`
- `Views/Equipamento/Excluir.cshtml`

**ModuloChamado:**
- `ModuloChamado/Chamado.cs`
- `ModuloChamado/RepositorioChamadoEmArquivo.cs`
- `Controllers/ChamadoController.cs`
- `Models/ChamadoViewModels.cs`
- `Views/Chamado/Listar.cshtml`
- `Views/Chamado/Cadastrar.cshtml`
- `Views/Chamado/Editar.cshtml`
- `Views/Chamado/Excluir.cshtml`

### Arquivo a ser modificado:
- `Program.cs` - adicionar configuração de RazorOptions

## Verificação

Após implementação, testar:

1. **Build do projeto:** `dotnet build`
   - Verificar que não há erros de namespace ou referências quebradas

2. **Executar aplicação:** `dotnet run`
   - Verificar que a aplicação inicia sem erros

3. **Testar cada módulo no browser:**
   - Acessar `/Fabricante/Listar` - verificar que renderiza views corretamente
   - Acessar `/Equipamento/Listar` - verificar funcionamento
   - Acessar `/Chamado/Listar` - verificar funcionamento
   - Acessar `/Home/Index` - verificar que home permanece funcionando

4. **Testar CRUD completo:**
   - Cadastrar novo fabricante
   - Editar fabricante
   - Excluir fabricante
   - Repetir para Equipamento e Chamado

5. **Verificar navegação:**
   - Todos os links no _Layout.cshtml devem funcionar
   - Não deve haver erros 404 para views

## Considerações

- Esta reorganização é uma refatoração estrutural, não deve alterar comportamento
- Todos os namespaces precisam ser ajustados consistentemente
- A configuração de ViewLocationFormats é crítica para o MVC encontrar as views
- Views Shared permanecem em `/Views/Shared/` para serem acessíveis por todos módulos
- HomeController pode permanecer em `/Controllers/` ou ser movido para um módulo Home se desejado
