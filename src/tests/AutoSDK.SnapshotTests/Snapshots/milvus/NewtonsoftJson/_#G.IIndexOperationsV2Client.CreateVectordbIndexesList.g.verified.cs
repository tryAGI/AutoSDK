//HintName: G.IIndexOperationsV2Client.CreateVectordbIndexesList.g.cs
#nullable enable

namespace G
{
    public partial interface IIndexOperationsV2Client
    {
        /// <summary>
        /// List Indexes<br/>
        /// This operation lists all indexes of a specific collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbIndexesListResponse> CreateVectordbIndexesListAsync(

            global::G.CreateVectordbIndexesListRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Indexes<br/>
        /// This operation lists all indexes of a specific collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection. Setting this to a non-existing collection leads to an error.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbIndexesListResponse> CreateVectordbIndexesListAsync(
            string dbName,
            int? requestTimeout = default,
            string? authorization = default,
            string? collectionName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}