//HintName: G.IScoresClient.ScoreCreateV2EntityProjectScoresPost.g.cs
#nullable enable

namespace G
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Score Create<br/>
        /// Create a score.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScoreCreateRes> ScoreCreateV2EntityProjectScoresPostAsync(
            string entity,
            string project,

            global::G.ScoreCreateBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Score Create<br/>
        /// Create a score.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="predictionId">
        /// The prediction ID
        /// </param>
        /// <param name="scorer">
        /// The scorer reference (weave:// URI)
        /// </param>
        /// <param name="value">
        /// The value of the score
        /// </param>
        /// <param name="evaluationRunId">
        /// Optional evaluation run ID to link this score as a child call
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScoreCreateRes> ScoreCreateV2EntityProjectScoresPostAsync(
            string entity,
            string project,
            string predictionId,
            string scorer,
            double value,
            string? evaluationRunId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}