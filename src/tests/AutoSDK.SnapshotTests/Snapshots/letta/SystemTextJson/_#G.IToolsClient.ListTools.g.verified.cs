//HintName: G.IToolsClient.ListTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Tools<br/>
        /// Get a list of all tools available to agents.
        /// </summary>
        /// <param name="before">
        /// Tool ID cursor for pagination. Returns tools that come before this tool ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Tool ID cursor for pagination. Returns tools that come after this tool ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of tools to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for tools by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="name">
        /// Filter by single tool name
        /// </param>
        /// <param name="names">
        /// Filter by specific tool names
        /// </param>
        /// <param name="toolIds">
        /// Filter by specific tool IDs - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="search">
        /// Search tool names (case-insensitive partial match)
        /// </param>
        /// <param name="toolTypes">
        /// Filter by tool type(s) - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="excludeToolTypes">
        /// Tool type(s) to exclude - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="returnOnlyLettaTools">
        /// Return only tools with tool_type starting with 'letta_'<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tool>> ListToolsAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListToolsOrder? order = default,
            string? orderBy = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? names = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? toolTypes = default,
            global::System.Collections.Generic.IList<string>? excludeToolTypes = default,
            bool? returnOnlyLettaTools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}