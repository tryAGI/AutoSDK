//HintName: G.IProjectsClient.FindFeedbackScoreNamesByProjectIds.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find Feedback Score names By Project Ids<br/>
        /// Find Feedback Score names By Project Ids
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackScoreNames> FindFeedbackScoreNamesByProjectIdsAsync(
            string? projectIds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}