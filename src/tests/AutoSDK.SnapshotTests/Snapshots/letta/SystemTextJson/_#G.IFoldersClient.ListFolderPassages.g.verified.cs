//HintName: G.IFoldersClient.ListFolderPassages.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// List Folder Passages<br/>
        /// List all passages associated with a data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Passage ID cursor for pagination. Returns passages that come before this passage ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Passage ID cursor for pagination. Returns passages that come after this passage ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of passages to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for passages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Passage>> ListFolderPassagesAsync(
            string folderId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListFolderPassagesOrder? order = default,
            string? orderBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}