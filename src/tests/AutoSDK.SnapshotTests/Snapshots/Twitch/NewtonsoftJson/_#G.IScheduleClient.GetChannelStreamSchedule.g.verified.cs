//HintName: G.IScheduleClient.GetChannelStreamSchedule.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduleClient
    {
        /// <summary>
        /// Gets the broadcaster’s streaming schedule.<br/>
        /// Gets the broadcaster’s streaming schedule. You can get the entire schedule or specific segments of the schedule. [Learn More](https://help.twitch.tv/s/article/channel-page-setup#Schedule)<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="utcOffset"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChannelStreamScheduleResponse> GetChannelStreamScheduleAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.DateTime? startTime = default,
            string? utcOffset = default,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}