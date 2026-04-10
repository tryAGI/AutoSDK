//HintName: G.IMemoriesClient.MemoriesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Add memories.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesCreateResponseItem>> MemoriesCreateAsync(

            global::G.MemoryInput request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add memories.
        /// </summary>
        /// <param name="messages">
        /// An array of message objects representing the content of the memory. Each message object typically contains 'role' and 'content' fields, where 'role' indicates the sender either 'user' or 'assistant' and 'content' contains the actual message text. This structure allows for the representation of conversations or multi-part memories.
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with this memory.
        /// </param>
        /// <param name="userId">
        /// The unique identifier of the user associated with this memory.
        /// </param>
        /// <param name="appId">
        /// The unique identifier of the application associated with this memory.
        /// </param>
        /// <param name="runId">
        /// The unique identifier of the run associated with this memory.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory, which can be used to store any additional information or context about the memory. Best practice for incorporating additional information is through metadata (e.g. location, time, ids, etc.). During retrieval, you can either use these metadata alongside the query to fetch relevant memories or retrieve memories based on the query first and then refine the results using metadata during post-processing.
        /// </param>
        /// <param name="includes">
        /// String to include the specific preferences in the memory.
        /// </param>
        /// <param name="excludes">
        /// String to exclude the specific preferences in the memory.
        /// </param>
        /// <param name="infer">
        /// Whether to infer the memories or directly store the messages.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputFormat">
        /// Controls the response format structure. `v1.0` (deprecated) returns a direct array of memory objects: `[{...}, {...}]`. `v1.1` (recommended) returns an object with a 'results' key containing the array: `{"results": [...]}`. The `v1.0` format will be removed in future versions.<br/>
        /// Default Value: v1.1
        /// </param>
        /// <param name="customCategories">
        /// A list of categories with category name and its description.
        /// </param>
        /// <param name="customInstructions">
        /// Defines project-specific guidelines for handling and organizing memories. When set at the project level, they apply to all new memories in that project.
        /// </param>
        /// <param name="immutable">
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="asyncMode">
        /// Whether to add the memory completely asynchronously.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="timestamp">
        /// The timestamp of the memory. Format: Unix timestamp
        /// </param>
        /// <param name="expirationDate">
        /// The date and time when the memory will expire. Format: YYYY-MM-DD
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with this memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with this memory.
        /// </param>
        /// <param name="version">
        /// The version of the memory to use. The default version is v1, which is deprecated. We recommend using v2 for new applications.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesCreateResponseItem>> MemoriesCreateAsync(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string?>>? messages = default,
            string? agentId = default,
            string? userId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            string? includes = default,
            string? excludes = default,
            bool? infer = default,
            string? outputFormat = default,
            object? customCategories = default,
            string? customInstructions = default,
            bool? immutable = default,
            bool? asyncMode = default,
            global::System.DateTimeOffset? timestamp = default,
            string? expirationDate = default,
            string? orgId = default,
            string? projectId = default,
            string? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}