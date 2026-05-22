using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Infra;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloChamado.Dominio;

namespace GestaoDeEquipamentosWeb.ConsoleApp.ModuloChamado.Infra;

public class RepositorioChamadoEmArquivo : RepositorioBaseEmArquivo<Chamado>, IRepositorio<Chamado>
{
    public RepositorioChamadoEmArquivo(ContextoJson contexto) : base(contexto) { }

    protected override List<Chamado> CarregarRegistros()
    {
        return contexto.Chamados;
    }
}
