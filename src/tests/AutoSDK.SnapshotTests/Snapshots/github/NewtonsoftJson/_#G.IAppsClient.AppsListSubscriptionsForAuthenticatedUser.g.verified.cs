//HintName: G.IAppsClient.AppsListSubscriptionsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// List subscriptions for the authenticated user<br/>
        /// Lists the active subscriptions for the authenticated user.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserMarketplacePurchase>> AppsListSubscriptionsForAuthenticatedUserAsync(
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}