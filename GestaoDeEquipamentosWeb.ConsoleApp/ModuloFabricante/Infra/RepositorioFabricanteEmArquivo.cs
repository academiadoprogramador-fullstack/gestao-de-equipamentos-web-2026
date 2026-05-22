using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Infra;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante.Dominio;

namespace GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante.Infra;

public class RepositorioFabricanteEmArquivo :
    RepositorioBaseEmArquivo<Fabricante>, IRepositorio<Fabricante>
{
    public RepositorioFabricanteEmArquivo(ContextoJson contexto) : base(contexto) { }

    protected override List<Fabricante> CarregarRegistros()
    {
        return contexto.Fabricantes;
    }
}
