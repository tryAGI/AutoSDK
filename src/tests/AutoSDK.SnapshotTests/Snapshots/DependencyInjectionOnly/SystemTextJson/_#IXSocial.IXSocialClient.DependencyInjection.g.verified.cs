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

        /// <summary>
        /// Registers a singleton <see cref="global::IXSocial.IAutoSDKAuthorizationProvider"/>
        /// that the generated SDK client consults before each outgoing request. Pair with
        /// <see cref="AddIXSocialClient"/> to resolve credentials per call from an <see cref="global::System.IServiceProvider"/>
        /// without mutating the client's shared <c>Authorizations</c> list.
        /// </summary>
        /// <typeparam name="TProvider"></typeparam>
        /// <param name="services"></param>
        /// <param name="lifetime"></param>
        public static IServiceCollection AddIXSocialClientAuthorizationProvider<TProvider>(
            this IServiceCollection services,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where TProvider : class, global::IXSocial.IAutoSDKAuthorizationProvider
        {
            if (services is null)
            {
                throw new global::System.ArgumentNullException(nameof(services));
            }

            services.Add(new ServiceDescriptor(
                serviceType: typeof(global::IXSocial.IAutoSDKAuthorizationProvider),
                implementationType: typeof(TProvider),
                lifetime: lifetime));

            return services;
        }

        /// <summary>
        /// Registers an inline <see cref="global::IXSocial.IAutoSDKAuthorizationProvider"/>
        /// resolver that runs once per outgoing request with access to the active
        /// <see cref="global::System.IServiceProvider"/> and operation context.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="resolver"></param>
        /// <param name="lifetime"></param>
        public static IServiceCollection AddIXSocialClientAuthorizationProvider(
            this IServiceCollection services,
            global::System.Func<global::System.IServiceProvider, global::IXSocial.AutoSDKHookContext, global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IReadOnlyList<global::IXSocial.AutoSDKAuthorizationValue>?>> resolver,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            if (services is null)
            {
                throw new global::System.ArgumentNullException(nameof(services));
            }

            if (resolver is null)
            {
                throw new global::System.ArgumentNullException(nameof(resolver));
            }

            services.Add(new ServiceDescriptor(
                serviceType: typeof(global::IXSocial.IAutoSDKAuthorizationProvider),
                factory: serviceProvider => new IXSocialClientDelegateAuthorizationProvider(serviceProvider, resolver),
                lifetime: lifetime));

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

                        var authorizationProvider = (global::IXSocial.IAutoSDKAuthorizationProvider?)
                            serviceProvider.GetService(typeof(global::IXSocial.IAutoSDKAuthorizationProvider));
                        if (authorizationProvider is not null)
                        {
                            clientOptions.UseAuthorizationProvider(authorizationProvider);
                        }

                        configureClientOptions?.Invoke(serviceProvider, clientOptions);

                        return new global::IXSocial.IXSocialClient(
                            httpClient: httpClient,
                            baseUri: resolveBaseUri(serviceProvider),
                            authorizations: null,
                            options: clientOptions,
                            disposeHttpClient: false);
                    });

            configureHttpClientBuilder?.Invoke(httpClientBuilder);
            return httpClientBuilder;
        }
    }

    internal sealed class IXSocialClientDelegateAuthorizationProvider : global::IXSocial.IAutoSDKAuthorizationProvider
    {
        private readonly global::System.IServiceProvider _serviceProvider;
        private readonly global::System.Func<global::System.IServiceProvider, global::IXSocial.AutoSDKHookContext, global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IReadOnlyList<global::IXSocial.AutoSDKAuthorizationValue>?>> _resolver;

        public IXSocialClientDelegateAuthorizationProvider(
            global::System.IServiceProvider serviceProvider,
            global::System.Func<global::System.IServiceProvider, global::IXSocial.AutoSDKHookContext, global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IReadOnlyList<global::IXSocial.AutoSDKAuthorizationValue>?>> resolver)
        {
            _serviceProvider = serviceProvider ?? throw new global::System.ArgumentNullException(nameof(serviceProvider));
            _resolver = resolver ?? throw new global::System.ArgumentNullException(nameof(resolver));
        }

        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IReadOnlyList<global::IXSocial.AutoSDKAuthorizationValue>?> ResolveAsync(
            global::IXSocial.AutoSDKHookContext context)
        {
            return await _resolver(_serviceProvider, context).ConfigureAwait(false);
        }
    }
}
