//HintName: G.IBetaClient.ClearIssues.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Clear issues<br/>
        /// Removes all issues reported so far
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClearIssuesResponse> ClearIssuesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}