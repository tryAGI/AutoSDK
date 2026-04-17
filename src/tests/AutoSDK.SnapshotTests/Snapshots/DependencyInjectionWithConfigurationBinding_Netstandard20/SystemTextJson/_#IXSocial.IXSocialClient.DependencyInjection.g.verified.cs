//HintName: IXSocial.IXSocialClient.DependencyInjection.g.cs

#nullable enable

using global::Microsoft.Extensions.DependencyInjection;
using global::Microsoft.Extensions.Configuration;
using global::Microsoft.Extensions.DependencyInjection.Extensions;
using global::Microsoft.Extensions.Options;

namespace IXSocial
{

    /// <summary>
    /// Options bound from configuration for the IXSocialClient.
    /// </summary>
    public sealed partial class IXSocialOptions
    {
        /// <summary>
        /// Default configuration section name for this SDK client.
        /// </summary>
        public const string DefaultConfigurationSectionName = "IXSocial";

        /// <summary>
        /// Base URL used for the generated SDK client.
        /// </summary>
        public global::System.Uri? ApiUrl { get; set; }
    }


    /// <summary>
    /// Extension methods for wiring the generated SDK client into dependency injection.
    /// </summary>
    public static class DependencyInjectionExtensions
    {
        /// <summary>
        /// Registers the generated SDK client with a typed <see cref="global::System.Net.Http.HttpClient"/>.
        /// </summary>
        public static IServiceCollection AddIXSocialClient(
            this IServiceCollection services,
            global::System.Uri baseUri,
            global::System.Action<IHttpClientBuilder>? configureHttpClientBuilder = null,
            global::System.Action<global::System.IServiceProvider, global::IXSocial.AutoSDKClientOptions>? configureClientOptions = null)
        {
            if (services is null)
            {
                throw new global::System.ArgumentNullException(nameof(services));
            }

            if (baseUri is null)
            {
                throw new global::System.ArgumentNullException(nameof(baseUri));
            }

            _ = RegisterIXSocialClient(services, _ => baseUri, configureHttpClientBuilder, configureClientOptions);
            return services;
        }


        /// <summary>
        /// Registers the generated SDK client with configuration-bound options and a typed <see cref="global::System.Net.Http.HttpClient"/>.
        /// </summary>
        public static IServiceCollection AddIXSocialClient(
            this IServiceCollection services,
            IConfiguration configuration,
            string? sectionName = null,
            global::System.Action<OptionsBuilder<global::IXSocial.IXSocialOptions>>? configureOptions = null,
            global::System.Action<IHttpClientBuilder>? configureHttpClientBuilder = null,
            global::System.Action<global::System.IServiceProvider, global::IXSocial.AutoSDKClientOptions>? configureClientOptions = null)
        {
            if (services is null)
            {
                throw new global::System.ArgumentNullException(nameof(services));
            }

            if (configuration is null)
            {
                throw new global::System.ArgumentNullException(nameof(configuration));
            }

            sectionName ??= global::IXSocial.IXSocialOptions.DefaultConfigurationSectionName;
            services.TryAddSingleton<IConfiguration>(configuration);

            var optionsBuilder = services
                .AddOptions<global::IXSocial.IXSocialOptions>()
                .BindConfiguration(sectionName)
                .Validate(static options => options.ApiUrl is not null, "IXSocial:ApiUrl is missing");

            configureOptions?.Invoke(optionsBuilder);
            _ = optionsBuilder.ValidateOnStart();

            _ = RegisterIXSocialClient(
                services,
                serviceProvider => serviceProvider
                    .GetRequiredService<IOptions<global::IXSocial.IXSocialOptions>>()
                    .Value
                    .ApiUrl ?? throw new global::System.InvalidOperationException($"{sectionName}:ApiUrl is missing"),
                configureHttpClientBuilder,
                configureClientOptions);

            return services;
        }

        private static IHttpClientBuilder RegisterIXSocialClient(
            IServiceCollection services,
            global::System.Func<global::System.IServiceProvider, global::System.Uri> resolveBaseUri,
            global::System.Action<IHttpClientBuilder>? configureHttpClientBuilder,
            global::System.Action<global::System.IServiceProvider, global::IXSocial.AutoSDKClientOptions>? configureClientOptions)
        {
            var httpClientBuilder = services
                .AddHttpClient<global::IXSocial.IIXSocialClient, global::IXSocial.IXSocialClient>(
                    (httpClient, serviceProvider) =>
                    {
                        var clientOptions = new global::IXSocial.AutoSDKClientOptions();
                        configureClientOptions?.Invoke(serviceProvider, clientOptions);

                        return new global::IXSocial.IXSocialClient(
                            httpClient: httpClient,
                            baseUri: resolveBaseUri(serviceProvider),
                            options: clientOptions,
                            disposeHttpClient: false);
                    });

            configureHttpClientBuilder?.Invoke(httpClientBuilder);
            return httpClientBuilder;
        }
    }
}
