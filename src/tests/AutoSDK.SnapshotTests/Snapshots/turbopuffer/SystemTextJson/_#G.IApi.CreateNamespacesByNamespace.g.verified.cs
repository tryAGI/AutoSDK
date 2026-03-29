//HintName: G.IApi.CreateNamespacesByNamespace.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create, update, or delete documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WriteResult> CreateNamespacesByNamespaceAsync(
            string @namespace,

            global::G.Write request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create, update, or delete documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="upsertColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="upsertRows"></param>
        /// <param name="patchColumns">
        /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
        /// </param>
        /// <param name="patchRows"></param>
        /// <param name="deletes"></param>
        /// <param name="upsertCondition">
        /// A condition evaluated against the current value of each document targeted by an upsert write. Only documents that pass the condition are upserted.
        /// </param>
        /// <param name="patchCondition">
        /// A condition evaluated against the current value of each document targeted by a patch write. Only documents that pass the condition are patched.
        /// </param>
        /// <param name="deleteCondition">
        /// A condition evaluated against the current value of each document targeted by a delete write. Only documents that pass the condition are deleted.
        /// </param>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
        /// <param name="schema">
        /// The schema of the attributes attached to the documents.
        /// </param>
        /// <param name="copyFromNamespace"></param>
        /// <param name="deleteByFilter">
        /// The filter specifying which documents to delete.
        /// </param>
        /// <param name="deleteByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="patchByFilter">
        /// The patch and filter specifying which documents to patch.
        /// </param>
        /// <param name="patchByFilterAllowPartial">
        /// Allow partial completion when filter matches too many documents.
        /// </param>
        /// <param name="returnAffectedIds">
        /// If true, return the IDs of affected rows (deleted, patched, upserted) in the response. For filtered and conditional writes, only IDs for writes that succeeded will be included.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encryption">
        /// The encryption configuration for a namespace.
        /// </param>
        /// <param name="disableBackpressure">
        /// Disables write throttling (HTTP 429 responses) during high-volume ingestion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WriteResult> CreateNamespacesByNamespaceAsync(
            string @namespace,
            global::G.Columns? upsertColumns = default,
            global::System.Collections.Generic.IList<global::G.Row>? upsertRows = default,
            global::G.Columns? patchColumns = default,
            global::System.Collections.Generic.IList<global::G.Row>? patchRows = default,
            global::System.Collections.Generic.IList<global::G.Id>? deletes = default,
            object? upsertCondition = default,
            object? patchCondition = default,
            object? deleteCondition = default,
            global::G.DistanceMetric? distanceMetric = default,
            object? schema = default,
            global::G.OneOf<string, global::G.WriteCopyFromNamespace>? copyFromNamespace = default,
            object? deleteByFilter = default,
            bool? deleteByFilterAllowPartial = default,
            global::G.PatchByFilter? patchByFilter = default,
            bool? patchByFilterAllowPartial = default,
            bool? returnAffectedIds = default,
            global::G.Encryption2? encryption = default,
            bool? disableBackpressure = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}