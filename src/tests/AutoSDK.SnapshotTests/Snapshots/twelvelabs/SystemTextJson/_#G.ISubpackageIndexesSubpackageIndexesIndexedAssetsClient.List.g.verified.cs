//HintName: G.ISubpackageIndexesSubpackageIndexesIndexedAssetsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// List indexed assets<br/>
        /// This method returns a list of the indexed assets in the specified index. By default, the platform returns your indexed assets sorted by creation date, with the newest at the top of the list.
        /// </summary>
        /// <param name="indexId"></param>
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
        /// <param name="status"></param>
        /// <param name="filename"></param>
        /// <param name="duration"></param>
        /// <param name="fps"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="size"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userMetadata"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesIndexedAssetsListResponse200> ListAsync(
            string indexId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? status = default,
            string? filename = default,
            double? duration = default,
            double? fps = default,
            double? width = default,
            int? height = default,
            double? size = default,
            string? createdAt = default,
            string? updatedAt = default,
            object? userMetadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}