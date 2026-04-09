//HintName: G.IEntitiesClient.EntitiesFiltersList.g.cs
#nullable enable

namespace G
{
    public partial interface IEntitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task EntitiesFiltersListAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}