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
                PostDescribeCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PostGenerateImageCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetApiKeysCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                CreateApiKeyCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                DeleteSingleApiKeyCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ReactivateSubscriptionCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetApiStripeSubscriptionCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetApiSubscriptionCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PostApiSubscriptionCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GetApiTermsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PostApiTermsCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PostRemixImageCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                PostUpscaleImageCommand>(services);

            // Register grouped command services as singletons
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                GenerateGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                ManageGroupCommand>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                VisionGroupCommand>(services);

            // Register the main command service as a singleton
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MainCommand>(services);

            return services;
        }
    }
}