//HintName: G.IExperimentClient.GetExperimentScore.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="requestId"></param>
        /// <param name="scoreKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultScoreV2OrNullString> GetExperimentScoreAsync(
            string experimentId,
            string requestId,
            string scoreKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}