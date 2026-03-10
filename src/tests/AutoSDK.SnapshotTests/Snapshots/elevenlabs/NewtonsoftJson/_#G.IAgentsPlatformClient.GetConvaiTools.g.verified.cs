//HintName: G.IAgentsPlatformClient.GetConvaiTools.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Tools<br/>
        /// Get all available tools in the workspace.
        /// </summary>
        /// <param name="search">
        /// If specified, the endpoint returns only tools whose names start with this string.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only tools owned by you (and not shared from somebody else).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only tools of the given types.
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolsResponseModel> GetConvaiToolsAsync(
            string? search = default,
            int? pageSize = default,
            bool? showOnlyOwnedDocuments = default,
            global::System.Collections.Generic.IList<global::G.ToolTypeFilter>? types = default,
            global::G.SortDirection? sortDirection = default,
            global::G.ToolSortBy? sortBy = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}