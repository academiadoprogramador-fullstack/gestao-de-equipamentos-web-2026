public static class DependencyInjection
{
    public static void RegistrarServicos(IServiceCollection services)
    {
        services.AddScoped<IRepositorioChamado, RepositorioChamado>();
        services.AddScoped<IRepositorioEquipamento, RepositorioEquipamento>();
    }
}