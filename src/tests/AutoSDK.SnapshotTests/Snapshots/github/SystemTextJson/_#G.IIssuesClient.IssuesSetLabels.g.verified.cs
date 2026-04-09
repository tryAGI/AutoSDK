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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,

            global::G.OneOf<global::G.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::G.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant4Item>, string> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}