//HintName: G.IToolsClient.ListTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List tools<br/>
        /// List all tools available to the authenticated user, with optional filtering and pagination. Tools represent capabilities that agents can invoke during conversation, including built-in system tools and user-defined Lambda tools. Use filters to locate tools by name, type, status, or tool server.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: rag.*
        /// </param>
        /// <param name="type">
        /// Example: mcp
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="category">
        /// Example: [retrieval, utilities]
        /// </param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListToolsResponse> ListToolsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            global::G.ListToolsType? type = default,
            bool? enabled = default,
            global::System.Collections.Generic.IList<string>? category = default,
            string? toolServerId = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}