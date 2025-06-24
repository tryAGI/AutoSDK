using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAddCommands(
        EquatableArray<EndPoint> methods,
        EquatableArray<Tag> tags,
        CancellationToken cancellationToken = default)
    {
        if (methods.IsEmpty || tags.IsEmpty)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

namespace {methods[0].Settings.Namespace}
{{
    /// <summary>
    /// Provides extension methods for adding command services to the dependency injection container.
    /// </summary>
    internal static class ServiceCollectionExtensions
    {{
        /// <summary>
        /// Registers all command services required by the application into the dependency injection container.
        /// </summary>
        /// <param name=""services"">The <see cref=""global::Microsoft.Extensions.DependencyInjection.IServiceCollection""/> to which the services will be added.</param>
        /// <returns>The updated <see cref=""global::Microsoft.Extensions.DependencyInjection.IServiceCollection""/> instance.</returns>
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddCommands(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {{
            // Register individual command services as singletons
{methods.Select(x => $"{x.MethodName}Command").Distinct().Select((type, i) => @$"
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                {type}>(services);").Inject()}

            // Register grouped command services as singletons
{tags.Select(x => $"{x.SingularizedName}Command").Distinct().Select((type, i) => @$"
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                {type}>(services);").Inject()}

            // Register the main command service as a singleton
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MainCommand>(services);

            return services;
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}