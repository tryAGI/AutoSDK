//HintName: G.ServiceCollectionExtensions.AddCommands.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provides extension methods for adding command services to the dependency injection container.
    /// </summary>
    internal static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers all command services required by the application into the dependency injection container.
        /// </summary>
        /// <param name="services">The <see cref="global::Microsoft.Extensions.DependencyInjection.IServiceCollection"/> to which the services will be added.</param>
        /// <returns>The updated <see cref="global::Microsoft.Extensions.DependencyInjection.IServiceCollection"/> instance.</returns>
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddCommands(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {
            // Register individual command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessagesPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                CompletePostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ModelsListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ModelsGetCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageBatchesPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageBatchesListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageBatchesRetrieveCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageBatchesDeleteCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageBatchesCancelCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageBatchesResultsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessagesCountTokensPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessagesPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaModelsListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaModelsGetCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessageBatchesPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessageBatchesListCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessageBatchesRetrieveCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessageBatchesDeleteCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessageBatchesCancelCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessageBatchesResultsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BetaMessagesCountTokensPostCommand>(services);

            // Register grouped command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                TextCompletionGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MessageBatcheGroupCommand>(services);

            // Register the main command service as a singleton
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MainCommand>(services);

            return services;
        }
    }
}