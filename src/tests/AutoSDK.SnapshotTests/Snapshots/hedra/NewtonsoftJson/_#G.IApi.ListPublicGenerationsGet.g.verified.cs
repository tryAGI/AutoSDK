//HintName: G.IApi.ListPublicGenerationsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdAfter"></param>
        /// <param name="promptQuery"></param>
        /// <param name="agentThreadId"></param>
        /// <param name="ids"></param>
        /// <param name="pagingParams">
        /// Default Value: {"limit":100,"offset":0}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PagedResponseGeneration> ListPublicGenerationsGetAsync(
            global::G.AnyOf<global::G.AssetType?, global::G.GenerationType?, object>? type = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? createdAfter = default,
            string? promptQuery = default,
            global::System.Guid? agentThreadId = default,
            string? ids = default,
            global::G.PagingParams? pagingParams = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}