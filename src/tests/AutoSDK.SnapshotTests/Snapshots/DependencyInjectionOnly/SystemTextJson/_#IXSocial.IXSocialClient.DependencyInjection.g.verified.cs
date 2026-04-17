//HintName: IXSocial.IXSocialClient.DependencyInjection.g.cs

#nullable enable

using global::Microsoft.Extensions.DependencyInjection;

namespace IXSocial
{

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
