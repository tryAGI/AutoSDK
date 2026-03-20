//HintName: G.ICCLsClient.GetContentClassificationLabels.g.cs
#nullable enable

namespace G
{
    public partial interface ICCLsClient
    {
        /// <summary>
        /// Gets information about Twitch content classification labels.<br/>
        /// Gets information about Twitch content classification labels.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetContentClassificationLabelsResponse> GetContentClassificationLabelsAsync(
            string? locale = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}