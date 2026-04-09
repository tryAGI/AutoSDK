//HintName: G.IBatchClient.BatchReferencesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Batch create cross-references.<br/>
        /// Batch create cross-references between collections items (objects or objects) in bulk.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BatchReferenceResponse>> BatchReferencesCreateAsync(

            global::System.Collections.Generic.IList<global::G.BatchReference> request,
            global::G.BatchReferencesCreateConsistencyLevel? consistencyLevel = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}