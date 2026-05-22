public interface IChamadoLogger
{
    void LogarCriacaoChamado(Chamado chamado);
    void LogarEdicaoChamado(Chamado chamado);
    void LogarExclusaoChamado(string id);
}

public class ChamadoLogger : ILogger<ChamadoLogger>
{
    private readonly ILogger<ChamadoLogger> logger;

    public ChamadoLogger(ILogger<ChamadoLogger> logger)
    {
        this.logger = logger;
    }

    public void LogarCriacaoChamado(Chamado chamado)
    {
        logger.LogInformation("Chamado criado: {Titulo} (ID: {Id})", chamado.Titulo, chamado.Id);
    }

    public void LogarEdicaoChamado(Chamado chamado)
    {
        logger.LogInformation("Chamado editado: {Titulo} (ID: {Id})", chamado.Titulo, chamado.Id);
    }

    public void LogarExclusaoChamado(string id)
    {
        logger.LogInformation("Chamado excluído: ID {Id}", id);
    }
}