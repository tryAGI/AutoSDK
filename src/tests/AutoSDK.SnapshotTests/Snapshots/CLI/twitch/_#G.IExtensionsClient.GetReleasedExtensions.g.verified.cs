//HintName: G.IExtensionsClient.GetReleasedExtensions.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
    {
        /// <summary>
        /// Gets information about a released extension.<br/>
        /// Gets information about a released extension. Returns the extension if its `state` is Released.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="extensionVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetReleasedExtensionsResponse> GetReleasedExtensionsAsync(
            string extensionId,
            string? extensionVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}