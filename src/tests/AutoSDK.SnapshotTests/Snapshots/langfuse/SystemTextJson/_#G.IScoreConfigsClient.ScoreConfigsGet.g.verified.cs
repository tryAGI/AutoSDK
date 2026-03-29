//HintName: G.IScoreConfigsClient.ScoreConfigsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IScoreConfigsClient
    {
        /// <summary>
        /// Get all score configs
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScoreConfigs> ScoreConfigsGetAsync(
            int? page = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}