//HintName: G.IScorersClient.ScorerListV2EntityProjectScorersGet.g.cs
#nullable enable

namespace G
{
    public partial interface IScorersClient
    {
        /// <summary>
        /// Scorer List<br/>
        /// List scorer objects.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ScorerListV2EntityProjectScorersGetAsync(
            string entity,
            string project,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}