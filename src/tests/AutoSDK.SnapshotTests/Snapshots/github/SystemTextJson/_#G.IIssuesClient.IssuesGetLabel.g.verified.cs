//HintName: G.IIssuesClient.IssuesGetLabel.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Get a label<br/>
        /// Gets a label using the given name.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Label> IssuesGetLabelAsync(
            string owner,
            string repo,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}