//HintName: G.IIssuesClient.IssuesListLabelsOnIssue.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List labels for an issue<br/>
        /// Lists all labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesListLabelsOnIssueAsync(
            string owner,
            string repo,
            int issueNumber,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}