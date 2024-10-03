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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BatchReferenceResponse>> BatchReferencesCreateAsync(
            global::System.Collections.Generic.IList<global::G.BatchReference> request,
            global::G.BatchReferencesCreateConsistencyLevel? consistencyLevel = global::G.BatchReferencesCreateConsistencyLevel.QUORUM,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}