//HintName: G.IStreamsClient.GetStreamMarkers.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamsClient
    {
        /// <summary>
        /// Gets a list of markers from the user’s most recent stream or from the specified VOD/video.<br/>
        /// Gets a list of markers from the user’s most recent stream or from the specified VOD/video. A marker is an arbitrary point in a live stream that the broadcaster or editor marked, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:broadcast** or **channel:manage:broadcast** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="videoId"></param>
        /// <param name="first"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetStreamMarkersResponse> GetStreamMarkersAsync(
            string? userId = default,
            string? videoId = default,
            string? first = default,
            string? before = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}