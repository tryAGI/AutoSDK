//HintName: G.IVideosClient.DeleteVideos.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Deletes one or more videos.<br/>
        /// Deletes one or more videos. You may delete past broadcasts, highlights, or uploads.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:videos** scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteVideosResponse> DeleteVideosAsync(
            global::System.Collections.Generic.IList<string> id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}