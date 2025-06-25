//HintName: G.IScheduleClient.UpdateChannelStreamSchedule.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduleClient
    {
        /// <summary>
        /// Updates the broadcaster’s schedule settings, such as scheduling a vacation.<br/>
        /// Updates the broadcaster’s schedule settings, such as scheduling a vacation.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:schedule** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="isVacationEnabled"></param>
        /// <param name="vacationStartTime"></param>
        /// <param name="vacationEndTime"></param>
        /// <param name="timezone"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateChannelStreamScheduleAsync(
            string broadcasterId,
            bool? isVacationEnabled = default,
            global::System.DateTime? vacationStartTime = default,
            global::System.DateTime? vacationEndTime = default,
            string? timezone = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}