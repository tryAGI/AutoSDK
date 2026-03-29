//HintName: G.IRequestClient.AddScores.g.cs
#nullable enable

namespace G
{
    public partial interface IRequestClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> AddScoresAsync(
            string requestId,

            global::G.ScoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="scores">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> AddScoresAsync(
            string requestId,
            global::G.RecordStringNumberOrBooleanOrUndefined scores,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}