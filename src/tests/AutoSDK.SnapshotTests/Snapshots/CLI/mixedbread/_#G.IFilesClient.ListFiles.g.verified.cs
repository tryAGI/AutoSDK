//HintName: G.IFilesClient.ListFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List files<br/>
        /// List all files for the authenticated user.<br/>
        /// Args:<br/>
        ///     pagination: The pagination options<br/>
        /// Returns:<br/>
        ///     A list of files belonging to the user.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="q">
        /// Search query for fuzzy matching over name and description fields
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileListResponse> ListFilesAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            string? q = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}