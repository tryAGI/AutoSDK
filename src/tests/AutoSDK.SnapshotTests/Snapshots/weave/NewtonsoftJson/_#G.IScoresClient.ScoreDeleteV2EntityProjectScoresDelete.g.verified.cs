//HintName: G.IScoresClient.ScoreDeleteV2EntityProjectScoresDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Score Delete<br/>
        /// Delete scores.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="scoreIds">
        /// List of score IDs to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScoreDeleteRes> ScoreDeleteV2EntityProjectScoresDeleteAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string> scoreIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}