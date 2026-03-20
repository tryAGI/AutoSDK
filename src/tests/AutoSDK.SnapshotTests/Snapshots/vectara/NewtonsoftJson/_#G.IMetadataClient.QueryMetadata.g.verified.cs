//HintName: G.IMetadataClient.QueryMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Query across metadata fields in a corpus<br/>
        /// Query for documents in a specific corpus using fuzzy matching across specified metadata fields. The search first applies any exact metadata filters to narrow the results, then performs fuzzy matching on the remaining documents using the specified field queries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataQueryResponse> QueryMetadataAsync(
            string corpusKey,

            global::G.MetadataQueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query across metadata fields in a corpus<br/>
        /// Query for documents in a specific corpus using fuzzy matching across specified metadata fields. The search first applies any exact metadata filters to narrow the results, then performs fuzzy matching on the remaining documents using the specified field queries.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="level">
        /// Whether to search document-level or part-level metadata. Document-level returns unique documents, part-level can return multiple parts from the same document.<br/>
        /// Default Value: document
        /// </param>
        /// <param name="queries">
        /// List of field-specific queries to apply fuzzy matching.<br/>
        /// Example: [{"field":"title","query":"lease agreement","weight":2}, {"field":"category","query":"contract","weight":1}]
        /// </param>
        /// <param name="metadataFilter">
        /// Optional filter expression to narrow down results before fuzzy matching is applied. <br/>
        /// This uses the same expression format as document listing filters and applies exact matching.<br/>
        /// Example: doc.Status = 'Active'
        /// </param>
        /// <param name="limit">
        /// Sets the maximum number of documents to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="offset">
        /// Starting position for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataQueryResponse> QueryMetadataAsync(
            string corpusKey,
            global::System.Collections.Generic.IList<global::G.FieldQuery> queries,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.MetadataQueryRequestLevel? level = default,
            string? metadataFilter = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}