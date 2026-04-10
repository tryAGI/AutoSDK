//HintName: G.IScorersClient.ScorerCreateV2EntityProjectScorersPost.g.cs
#nullable enable

namespace G
{
    public partial interface IScorersClient
    {
        /// <summary>
        /// Scorer Create<br/>
        /// Create a scorer object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScorerCreateRes> ScorerCreateV2EntityProjectScorersPostAsync(
            string entity,
            string project,

            global::G.ScorerCreateBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scorer Create<br/>
        /// Create a scorer object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="name">
        /// The name of this scorer.  Scorers with the same name will be versioned together.
        /// </param>
        /// <param name="description">
        /// A description of this scorer
        /// </param>
        /// <param name="opSourceCode">
        /// Complete source code for the Scorer.score op including imports
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScorerCreateRes> ScorerCreateV2EntityProjectScorersPostAsync(
            string entity,
            string project,
            string name,
            string opSourceCode,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}