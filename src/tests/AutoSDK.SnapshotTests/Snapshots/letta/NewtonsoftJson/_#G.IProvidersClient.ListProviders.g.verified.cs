//HintName: G.IProvidersClient.ListProviders.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// List Providers<br/>
        /// Get a list of all custom providers.
        /// </summary>
        /// <param name="before">
        /// Provider ID cursor for pagination. Returns providers that come before this provider ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Provider ID cursor for pagination. Returns providers that come after this provider ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of providers to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for providers by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="name">
        /// Filter providers by name
        /// </param>
        /// <param name="providerType">
        /// Filter providers by type
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Provider>> ListProvidersAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListProvidersOrder? order = default,
            string? orderBy = default,
            string? name = default,
            global::G.ProviderType? providerType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}