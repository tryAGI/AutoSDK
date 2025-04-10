//HintName: G.IProductSubscriptionClient.ChangeAutoRenew.g.cs
#nullable enable

namespace G
{
    public partial interface IProductSubscriptionClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChangeAutoRenewAsync(
            global::G.ProductSubscriptionForChangeAutoRenewOptionRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="productSubscriptionId"></param>
        /// <param name="autoRenew"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ChangeAutoRenewAsync(
            string? currentCulture = default,
            long? userId = default,
            long? productSubscriptionId = default,
            bool? autoRenew = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}