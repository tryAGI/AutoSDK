//HintName: G.IPredictionsClient.GetPredictions.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Gets a list of Channel Points Predictions that the broadcaster created.<br/>
        /// Gets a list of Channel Points Predictions that the broadcaster created.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:predictions** or **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPredictionsResponse> GetPredictionsAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id = default,
            string? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}