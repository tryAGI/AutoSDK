//HintName: G.IIssuesClient.IssuesCheckUserCanBeAssignedToIssue.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Check if a user can be assigned to a issue<br/>
        /// Checks if a user has permission to be assigned to a specific issue.<br/>
        /// If the `assignee` can be assigned to this issue, a `204` status code with no content is returned.<br/>
        /// Otherwise a `404` status code is returned.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="assignee"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> IssuesCheckUserCanBeAssignedToIssueAsync(
            string owner,
            string repo,
            int issueNumber,
            string assignee,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}