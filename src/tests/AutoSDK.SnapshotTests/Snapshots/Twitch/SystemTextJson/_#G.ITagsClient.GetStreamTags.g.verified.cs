//HintName: G.ITagsClient.GetStreamTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Gets the list of stream tags that the broadcaster or Twitch added to their channel.<br/>
        /// **IMPORTANT** Twitch is moving from Twitch-defined tags to channel-defined tags. **IMPORTANT** As of February 28, 2023, this endpoint returns an empty array. On July 13, 2023, it will return a 410 response. If you use this endpoint, please update your code to use [Get Channel Information](https://dev.twitch.tv/docs/api/reference#get-channel-information).<br/>
        /// Gets the list of stream tags that the broadcaster or Twitch added to their channel.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.GetStreamTagsResponse> GetStreamTagsAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}