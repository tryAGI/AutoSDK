//HintName: G.IFineTuningClient.ValidateGrader.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Validate a grader.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateGraderResponse> ValidateGraderAsync(
            global::G.ValidateGraderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Validate a grader.
        /// </summary>
        /// <param name="grader">
        /// The grader used for the fine-tuning job.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateGraderResponse> ValidateGraderAsync(
            global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> grader,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}