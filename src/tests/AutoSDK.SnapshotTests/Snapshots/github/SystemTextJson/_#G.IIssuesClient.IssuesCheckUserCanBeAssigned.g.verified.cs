//HintName: G.IIssuesClient.IssuesCheckUserCanBeAssigned.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Check if a user can be assigned<br/>
        /// Checks if a user has permission to be assigned to an issue in this repository.<br/>
        /// If the `assignee` can be assigned to issues in the repository, a `204` header with no content is returned.<br/>
        /// Otherwise a `404` status code is returned.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assignee"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task IssuesCheckUserCanBeAssignedAsync(
            string owner,
            string repo,
            string assignee,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}