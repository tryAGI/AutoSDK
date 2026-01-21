//HintName: G.IApi.SetConfigPaymentConfigPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Set Config
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigOut> SetConfigPaymentConfigPostAsync(
            global::G.ConfigIn request,
            object? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set Config
        /// </summary>
        /// <param name="session"></param>
        /// <param name="limit">
        /// Set usage limit (in USD). Negative means no limit.null/not-set means don't change it
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigOut> SetConfigPaymentConfigPostAsync(
            object? session = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}