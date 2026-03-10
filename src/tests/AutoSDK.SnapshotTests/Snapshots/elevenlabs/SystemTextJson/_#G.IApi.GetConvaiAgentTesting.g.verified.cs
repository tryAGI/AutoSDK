//HintName: G.IApi.GetConvaiAgentTesting.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List Agent Response Tests<br/>
        /// Lists all agent response tests with pagination support and optional search filtering.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many Tests to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search query to filter tests by name.
        /// </param>
        /// <param name="parentFolderId">
        /// Filter by parent folder ID. Use 'root' to get items in the root folder.
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only tests/folders of the given types.
        /// </param>
        /// <param name="includeFolders">
        /// Deprecated. Use the `types` query param and include `folder` instead.
        /// </param>
        /// <param name="sortMode">
        /// Sort mode for listing tests. Use 'folders_first' to place folders before tests.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTestsPageResponseModel> GetConvaiAgentTestingAsync(
            string? cursor = default,
            int? pageSize = default,
            string? search = default,
            string? parentFolderId = default,
            global::System.Collections.Generic.IList<global::G.TestType>? types = default,
            bool? includeFolders = default,
            global::G.ListChatResponseTestsRouteSortMode? sortMode = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}