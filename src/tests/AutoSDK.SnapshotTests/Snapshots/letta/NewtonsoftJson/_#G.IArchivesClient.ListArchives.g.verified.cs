//HintName: G.IArchivesClient.ListArchives.g.cs
#nullable enable

namespace G
{
    public partial interface IArchivesClient
    {
        /// <summary>
        /// List Archives<br/>
        /// Get a list of all archives for the current organization with optional filters and pagination.
        /// </summary>
        /// <param name="before">
        /// Archive ID cursor for pagination. Returns archives that come before this archive ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Archive ID cursor for pagination. Returns archives that come after this archive ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of archives to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for archives by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="name">
        /// Filter by archive name (exact match)
        /// </param>
        /// <param name="agentId">
        /// Only archives attached to this agent ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Archive>> ListArchivesAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListArchivesOrder? order = default,
            string? orderBy = default,
            string? name = default,
            string? agentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}