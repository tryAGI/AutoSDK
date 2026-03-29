//HintName: G.IScoresClient.CallsScoreCallsScorePost.g.cs
#nullable enable

namespace G
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Calls Score
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallsScoreRes> CallsScoreCallsScorePostAsync(

            global::G.CallsScoreReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Score
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callIds">
        /// List of call IDs to score
        /// </param>
        /// <param name="scorerRefs">
        /// List of scorer refs to apply
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallsScoreRes> CallsScoreCallsScorePostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            global::System.Collections.Generic.IList<string> scorerRefs,
            string? wbUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}