//HintName: G.IScheduleClient.DeleteChannelStreamScheduleSegment.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduleClient
    {
        /// <summary>
        /// Deletes a broadcast from the broadcaster’s streaming schedule.<br/>
        /// Removes a broadcast segment from the broadcaster’s streaming schedule.<br/>
        /// **NOTE**: For recurring segments, removing a segment removes all segments in the recurring schedule.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteChannelStreamScheduleSegmentAsync(
            string broadcasterId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}