//HintName: G.IAgentsClient.ListPassages.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Passages<br/>
        /// Retrieve the memories in an agent's archival memory store (paginated query).
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="after">
        /// Unique ID of the memory to start the query range at.
        /// </param>
        /// <param name="before">
        /// Unique ID of the memory to end the query range at.
        /// </param>
        /// <param name="limit">
        /// How many results to include in the response.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Search passages by text
        /// </param>
        /// <param name="ascending">
        /// Whether to sort passages oldest to newest (True, default) or newest to oldest (False)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Passage>> ListPassagesAsync(
            string agentId,
            string? after = default,
            string? before = default,
            int? limit = default,
            string? search = default,
            bool? ascending = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}