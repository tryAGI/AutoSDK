using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateDependencyInjection(
        Client client,
        bool includeConfigurationBinding = false,
        CancellationToken cancellationToken = default)
    {
        var optionsTypeName = GetDependencyInjectionOptionsTypeName(client.ClassName);
        var configurationSectionName = GetDependencyInjectionConfigurationSectionName(client.ClassName);
        var addMethodName = $"Add{client.ClassName}";
        var optionsValidationMessage = $"{configurationSectionName}:ApiUrl is missing";

        return $@"
#nullable enable

using global::Microsoft.Extensions.DependencyInjection;
{(includeConfigurationBinding ? @"using global::Microsoft.Extensions.Configuration;
using global::Microsoft.Extensions.DependencyInjection.Extensions;
using global::Microsoft.Extensions.Options;" : TrimmedLine)}

namespace {client.Settings.Namespace}
{{
{(includeConfigurationBinding ? $@"
    /// <summary>
    /// Options bound from configuration for the {client.ClassName}.
    /// </summary>
    public sealed partial class {optionsTypeName}
    {{
        /// <summary>
        /// Default configuration section name for this SDK client.
        /// </summary>
        public const string DefaultConfigurationSectionName = ""{configurationSectionName}"";

        /// <summary>
        /// Base URL used for the generated SDK client.
        /// </summary>
        public global::System.Uri? ApiUrl {{ get; set; }}
    }}
" : TrimmedLine)}

    /// <summary>
    /// Extension methods for wiring the generated SDK client into dependency injection.
    /// </summary>
    public static class DependencyInjectionExtensions
    {{
        /// <summary>
        /// Registers the generated SDK client with a typed <see cref=""global::System.Net.Http.HttpClient""/>.
        /// </summary>
        public static IServiceCollection {addMethodName}(
            this IServiceCollection services,
            global::System.Uri baseUri,
            global::System.Action<IHttpClientBuilder>? configureHttpClientBuilder = null,
            global::System.Action<global::System.IServiceProvider, global::{client.Settings.Namespace}.AutoSDKClientOptions>? configureClientOptions = null)
        {{
            if (services is null)
            {{
                throw new global::System.ArgumentNullException(nameof(services));
            }}

            if (baseUri is null)
            {{
                throw new global::System.ArgumentNullException(nameof(baseUri));
            }}

            _ = Register{client.ClassName}(services, _ => baseUri, configureHttpClientBuilder, configureClientOptions);
            return services;
        }}
{(includeConfigurationBinding ? $@"

        /// <summary>
        /// Registers the generated SDK client with configuration-bound options and a typed <see cref=""global::System.Net.Http.HttpClient""/>.
        /// </summary>
        public static IServiceCollection {addMethodName}(
            this IServiceCollection services,
            IConfiguration configuration,
            string? sectionName = null,
            global::System.Action<OptionsBuilder<global::{client.Settings.Namespace}.{optionsTypeName}>>? configureOptions = null,
            global::System.Action<IHttpClientBuilder>? configureHttpClientBuilder = null,
            global::System.Action<global::System.IServiceProvider, global::{client.Settings.Namespace}.AutoSDKClientOptions>? configureClientOptions = null)
        {{
            if (services is null)
            {{
                throw new global::System.ArgumentNullException(nameof(services));
            }}

            if (configuration is null)
            {{
                throw new global::System.ArgumentNullException(nameof(configuration));
            }}

            sectionName ??= global::{client.Settings.Namespace}.{optionsTypeName}.DefaultConfigurationSectionName;
            services.TryAddSingleton<IConfiguration>(configuration);

            var optionsBuilder = services
                .AddOptions<global::{client.Settings.Namespace}.{optionsTypeName}>()
                .BindConfiguration(sectionName)
                .Validate(static options => options.ApiUrl is not null, ""{optionsValidationMessage}"");

            configureOptions?.Invoke(optionsBuilder);
            _ = optionsBuilder.ValidateOnStart();

            _ = Register{client.ClassName}(
                services,
                serviceProvider => serviceProvider
                    .GetRequiredService<IOptions<global::{client.Settings.Namespace}.{optionsTypeName}>>()
                    .Value
                    .ApiUrl ?? throw new global::System.InvalidOperationException($""{{sectionName}}:ApiUrl is missing""),
                configureHttpClientBuilder,
                configureClientOptions);

            return services;
        }}" : TrimmedLine)}

        private static IHttpClientBuilder Register{client.ClassName}(
            IServiceCollection services,
            global::System.Func<global::System.IServiceProvider, global::System.Uri> resolveBaseUri,
            global::System.Action<IHttpClientBuilder>? configureHttpClientBuilder,
            global::System.Action<global::System.IServiceProvider, global::{client.Settings.Namespace}.AutoSDKClientOptions>? configureClientOptions)
        {{
            var httpClientBuilder = services
                .AddHttpClient<global::{client.Settings.Namespace}.I{client.ClassName}, global::{client.Settings.Namespace}.{client.ClassName}>(
                    (httpClient, serviceProvider) =>
                    {{
                        var clientOptions = new global::{client.Settings.Namespace}.AutoSDKClientOptions();
                        configureClientOptions?.Invoke(serviceProvider, clientOptions);

                        return new global::{client.Settings.Namespace}.{client.ClassName}(
                            httpClient: httpClient,
                            baseUri: resolveBaseUri(serviceProvider),
                            authorizations: null,
                            options: clientOptions,
                            disposeHttpClient: false);
                    }});

            configureHttpClientBuilder?.Invoke(httpClientBuilder);
            return httpClientBuilder;
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GetDependencyInjectionOptionsTypeName(string className)
    {
        return GetDependencyInjectionConfigurationSectionName(className) + "Options";
    }

    private static string GetDependencyInjectionConfigurationSectionName(string className)
    {
        return className.EndsWith("Client", StringComparison.Ordinal)
            ? className.Substring(0, className.Length - "Client".Length)
            : className;
    }
}
