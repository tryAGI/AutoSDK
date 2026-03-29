//HintName: G.IMemoriesClient.MemoriesSearchCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Perform a semantic search on memories.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesSearchCreateResponseItem>> MemoriesSearchCreateAsync(

            global::G.MemorySearchInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform a semantic search on memories.
        /// </summary>
        /// <param name="query">
        /// The query to search for in the memory.
        /// </param>
        /// <param name="agentId">
        /// The agent ID associated with the memory.
        /// </param>
        /// <param name="userId">
        /// The user ID associated with the memory.
        /// </param>
        /// <param name="appId">
        /// The app ID associated with the memory.
        /// </param>
        /// <param name="runId">
        /// The run ID associated with the memory.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory.
        /// </param>
        /// <param name="topK">
        /// The number of top results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="fields">
        /// A list of field names to include in the response. If not provided, all fields will be returned.
        /// </param>
        /// <param name="rerank">
        /// Whether to rerank the memories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keywordSearch">
        /// Whether to search for memories based on keywords.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputFormat">
        /// The search method supports two output formats: `v1.0` (default) and `v1.1`. We recommend using `v1.1` as `v1.0` will be deprecated soon.<br/>
        /// Default Value: v1.1
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with the memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with the memory.
        /// </param>
        /// <param name="filterMemories">
        /// Whether to properly filter the memories according to the input.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="categories">
        /// A list of categories to filter the memories by.
        /// </param>
        /// <param name="onlyMetadataBasedSearch">
        /// Whether to only search for memories based on metadata.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesSearchCreateResponseItem>> MemoriesSearchCreateAsync(
            string query,
            string? agentId = default,
            string? userId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            int? topK = default,
            global::System.Collections.Generic.IList<string>? fields = default,
            bool? rerank = default,
            bool? keywordSearch = default,
            string? outputFormat = default,
            string? orgId = default,
            string? projectId = default,
            bool? filterMemories = default,
            global::System.Collections.Generic.IList<string>? categories = default,
            bool? onlyMetadataBasedSearch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}