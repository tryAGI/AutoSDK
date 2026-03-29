//HintName: G.IBetaClient.GetIssues.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get issues<br/>
        /// Get a report of performance issues and configuration suggestions
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetIssuesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}