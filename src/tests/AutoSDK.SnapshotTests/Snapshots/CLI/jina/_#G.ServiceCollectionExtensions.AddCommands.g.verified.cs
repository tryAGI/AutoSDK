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
                CreateEmbeddingV1EmbeddingsPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                StartBulkEmbeddingV1BulkEmbeddingsPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                RetrieveJobV1BulkEmbeddingsJobIdGetCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                RankV1RerankPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                TrainV1TrainPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ClassifyV1ClassifyPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                CreateMultiVectorV1MultiVectorPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                CreateMultiVectorV1MultiEmbeddingsPostCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GatewayHealthGetCommand>(services);

            // Register grouped command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                EmbeddingGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                BulkEmbeddingGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                RerankGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ClassificationGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MultiVectorGroupCommand>(services);

            // Register the main command service as a singleton
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MainCommand>(services);

            return services;
        }
    }
}