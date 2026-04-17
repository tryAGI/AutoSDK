//HintName: IXSocial.HttpResilience.g.cs

#nullable enable

namespace IXSocial
{
    /// <summary>
    /// Extension methods for wiring generated SDK clients into Microsoft.Extensions.Http.Resilience.
    /// </summary>
    public static class AutoSDKHttpResilienceExtensions
    {
        /// <summary>
        /// Adds the Microsoft standard HTTP resilience handler to the current HTTP client builder.
        /// Unsafe HTTP method retries are disabled before custom configuration is applied.
        /// </summary>
        /// <param name="builder">The HTTP client builder.</param>
        /// <param name="configure">Optional custom configuration for the standard resilience options.</param>
        /// <returns>The current HTTP client builder.</returns>
        [global::System.CLSCompliant(false)]
        public static global::Microsoft.Extensions.DependencyInjection.IHttpClientBuilder AddAutoSDKStandardResilienceHandler(
            this global::Microsoft.Extensions.DependencyInjection.IHttpClientBuilder builder,
            global::System.Action<global::Microsoft.Extensions.Http.Resilience.HttpStandardResilienceOptions>? configure = null)
        {
            if (builder == null)
            {
                throw new global::System.ArgumentNullException(nameof(builder));
            }

            global::Microsoft.Extensions.DependencyInjection.ResilienceHttpClientBuilderExtensions.AddStandardResilienceHandler(
                builder,
                options =>
                {
#pragma warning disable EXTEXP0001
                    global::Microsoft.Extensions.Http.Resilience.HttpRetryStrategyOptionsExtensions.DisableForUnsafeHttpMethods(options.Retry);
#pragma warning restore EXTEXP0001
                    configure?.Invoke(options);
                });
            return builder;
        }
    }
}
