//HintName: G.IIndexOperationsV2Client.CreateVectordbIndexesDescribe.g.cs
#nullable enable

namespace G
{
    public partial interface IIndexOperationsV2Client
    {
        /// <summary>
        /// Describe Index<br/>
        /// This operation describes the current index.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbIndexesDescribeResponse> CreateVectordbIndexesDescribeAsync(

            global::G.CreateVectordbIndexesDescribeRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe Index<br/>
        /// This operation describes the current index.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
        /// <param name="collectionName">
        /// The name of an the collection to which the index belongs.
        /// </param>
        /// <param name="indexName">
        /// The name of the index to describe.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbIndexesDescribeResponse> CreateVectordbIndexesDescribeAsync(
            string collectionName,
            string indexName,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}