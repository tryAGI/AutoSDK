//HintName: G.IIssuesClient.IssuesAddAssignees.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Add assignees to an issue<br/>
        /// Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Issue> IssuesAddAssigneesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.IssuesAddAssigneesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add assignees to an issue<br/>
        /// Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="assignees">
        /// Usernames of people to assign this issue to. _NOTE: Only users with push access can add assignees to an issue. Assignees are silently ignored otherwise._
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Issue> IssuesAddAssigneesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Collections.Generic.IList<string>? assignees = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}