using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.AtendimentoService;
using Api.Domain.Interfaces.Services.CategoriaServico;
using Api.Domain.Interfaces.Services.ClienteServico;
using Api.Domain.Interfaces.Services.Funcionario;
using Api.Domain.Interfaces.Services.Servico;
using Api.Domain.Interfaces.Services.StatusAtendimento;
using Api.Domain.Interfaces.Services.TipoPagamento;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Infra.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            /*
                - AddTransient 
                    - Para cada vez que a Interface for usada será criada uma nova
                    instância da classe que a implementa
                - AddScoped
                    - Em 10 métodos ele precisar a Interface ele vai usar a mesma 
                    instância
                - AddSingleton
                    - Cria uma instância ao iniciar a aplicação.
            
            */
            serviceCollection.AddTransient<ICategoriaServicoService, CategoriaServicoService>();
            serviceCollection.AddTransient<ITipoPagamentoService, TipoPagamentoService>();
            serviceCollection.AddTransient<IServicoService, ServicoService>();
            serviceCollection.AddTransient<IFuncionarioService, FuncionarioService>();
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IStatusAtendimentoService, StatusAtendimentoService>();
            serviceCollection.AddTransient<IAtendimentoService, AtedimentoService>();
        }
    }
}