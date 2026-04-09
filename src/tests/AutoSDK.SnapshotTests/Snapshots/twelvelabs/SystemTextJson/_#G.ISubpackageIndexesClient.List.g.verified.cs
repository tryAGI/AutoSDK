//HintName: G.ISubpackageIndexesClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesClient
    {
        /// <summary>
        /// List indexes<br/>
        /// This method returns a list of the indexes in your account. The platform returns indexes sorted by creation date, with the oldest indexes at the top of the list.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="modelOptions"></param>
        /// <param name="modelFamily"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            string? indexName = default,
            string? modelOptions = default,
            string? modelFamily = default,
            string? createdAt = default,
            string? updatedAt = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}