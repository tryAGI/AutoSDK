//HintName: G.IScoreConfigsClient.ScoreConfigsGetById.g.cs
#nullable enable

namespace G
{
    public partial interface IScoreConfigsClient
    {
        /// <summary>
        /// Get a score config
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScoreConfig> ScoreConfigsGetByIdAsync(
            string configId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}