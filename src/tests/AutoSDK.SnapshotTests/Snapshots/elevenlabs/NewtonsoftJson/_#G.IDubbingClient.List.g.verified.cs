//HintName: G.IDubbingClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// List Dubs<br/>
        /// List the dubs you have access to.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many dubs to return at maximum. Can not exceed 200, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="dubbingStatus">
        /// What state the dub is currently in.
        /// </param>
        /// <param name="filterByCreator">
        /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="orderBy">
        /// The field to use for ordering results from this query.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="orderDirection">
        /// The order direction to use for results from this query.<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DubbingMetadataPageResponseModel> ListAsync(
            string? cursor = default,
            int? pageSize = default,
            global::G.ListDubsDubbingStatus? dubbingStatus = default,
            global::G.ListDubsFilterByCreator? filterByCreator = default,
            string? orderBy = default,
            global::G.ListDubsOrderDirection? orderDirection = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}