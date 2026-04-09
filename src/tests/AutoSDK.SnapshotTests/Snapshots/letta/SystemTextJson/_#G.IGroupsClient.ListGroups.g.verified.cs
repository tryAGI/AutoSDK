//HintName: G.IGroupsClient.ListGroups.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// List Groups<br/>
        /// Fetch all multi-agent groups matching query.
        /// </summary>
        /// <param name="managerType">
        /// Search groups by manager type
        /// </param>
        /// <param name="before">
        /// Group ID cursor for pagination. Returns groups that come before this group ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Group ID cursor for pagination. Returns groups that come after this group ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of groups to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for groups by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="projectId">
        /// Search groups by project id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Group>> ListGroupsAsync(
            global::G.ManagerType? managerType = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListGroupsOrder? order = default,
            string? orderBy = default,
            string? projectId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}