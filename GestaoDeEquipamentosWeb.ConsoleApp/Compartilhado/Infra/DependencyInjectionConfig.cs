public static class DependencyInjection
{
    public static void RegistrarServicos(IServiceCollection services)
    {
        RegistrarServicosChamado(services);
        RegistrarServicosEquipamento(services);
        RegistrarServicosFabricante(services);
    }

    private static void RegistrarServicosChamado(IServiceCollection services)
    {
        services.AddScoped<IRepositorioChamado, RepositorioChamado>();
        services.AddScoped<IRepositorioEquipamento, RepositorioEquipamento>();
    }
}