//HintName: G.IExtensionsClient.GetExtensionLiveChannels.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
    {
        /// <summary>
        /// Gets a list of broadcasters that are streaming live and have installed or activated the extension.<br/>
        /// Gets a list of broadcasters that are streaming live and have installed or activated the extension.<br/>
        /// It may take a few minutes for the list to include or remove broadcasters that have recently gone live or stopped broadcasting.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetExtensionLiveChannelsResponse> GetExtensionLiveChannelsAsync(
            string extensionId,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}