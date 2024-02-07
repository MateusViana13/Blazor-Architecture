using Microsoft.Extensions.DependencyInjection;

namespace ExemploArquitetura.Infrastructure
{
    public static class ExemploInfraServices
    {
        /// <summary>
        /// Adiciona os serviços de infraestrutura
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void AddInfraServices(this IServiceCollection serviceProvider)
        {
            //Exemplo de como adicionar um serviço de infraestrutura
            //serviceProvider.AddScoped<IExemploInfraService, ExemploInfraService>();
        }
    }
}
