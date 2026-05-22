using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Infra;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento.Dominio;

namespace GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento.Infra;

public class RepositorioEquipamentoEmArquivo :
    RepositorioBaseEmArquivo<Equipamento>, IRepositorio<Equipamento>
{
    public RepositorioEquipamentoEmArquivo(ContextoJson contexto) : base(contexto) { }

    protected override List<Equipamento> CarregarRegistros()
    {
        return contexto.Equipamentos;
    }
}
