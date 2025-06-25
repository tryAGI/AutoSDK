//HintName: G.IIssuesClient.IssuesSetLabels.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.OneOf<global::G.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::G.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant4Item>, string> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}