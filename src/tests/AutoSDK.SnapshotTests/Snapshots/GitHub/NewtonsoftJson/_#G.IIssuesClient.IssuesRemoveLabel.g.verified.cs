//HintName: G.IIssuesClient.IssuesRemoveLabel.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Remove a label from an issue<br/>
        /// Removes the specified label from the issue, and returns the remaining labels on the issue. This endpoint returns a `404 Not Found` status if the label does not exist.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesRemoveLabelAsync(
            string owner,
            string repo,
            int issueNumber,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}