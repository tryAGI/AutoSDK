//HintName: G.IMetadataClient.MetadataRetrieveCurrentBalances.g.cs
#nullable enable

namespace G
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Retrieve current organization balance<br/>
        /// Retrieve the current usage balances for the organization.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataRetrieveCurrentBalancesResponse> MetadataRetrieveCurrentBalancesAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}