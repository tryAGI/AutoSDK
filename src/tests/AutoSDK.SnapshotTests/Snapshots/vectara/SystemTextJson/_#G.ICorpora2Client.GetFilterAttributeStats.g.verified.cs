//HintName: G.ICorpora2Client.GetFilterAttributeStats.g.cs
#nullable enable

namespace G
{
    public partial interface ICorpora2Client
    {
        /// <summary>
        /// Get filter attribute statistics for corpus metadata<br/>
        /// Retrieve statistics and value distributions for filter attributes in a corpus. This endpoint provides insights into the metadata structure and content distribution, enabling users to understand available filter values and build effective metadata queries.<br/>
        /// This endpoint analyzes document and part metadata fields defined as filter attributes and returns:<br/>
        /// - **Value distributions**: Top occurring values with their counts<br/>
        /// - **Statistics**: Min, max, average, and sum for numeric fields<br/>
        /// By default, statistics are computed across all filter attributes at both document and part levels. You can optionally:<br/>
        /// - Request statistics for specific fields only<br/>
        /// - Apply metadata filters to analyze a subset of the corpus<br/>
        /// - Limit the number of distinct values returned per field<br/>
        /// **Performance and Caching**: Results may be cached for improved performance, with cache duration varying by corpus size. Cached results can take up to 1 hour to refresh for large corpora. Smaller corpora with faster query times have shorter cache durations (2-15 minutes) to ensure fresher data.<br/>
        /// The `corpus_key` uniquely identifies the corpus. For more information, see [Create a corpus](https://docs.vectara.com/docs/rest-api/create-corpus).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="fields"></param>
        /// <param name="metadataFilter"></param>
        /// <param name="maxValues">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetFilterAttributeStatsResponse> GetFilterAttributeStatsAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? fields = default,
            string? metadataFilter = default,
            int? maxValues = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}