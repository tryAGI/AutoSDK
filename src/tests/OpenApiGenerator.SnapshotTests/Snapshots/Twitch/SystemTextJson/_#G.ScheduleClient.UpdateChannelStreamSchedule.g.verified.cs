//HintName: G.ScheduleClient.UpdateChannelStreamSchedule.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateChannelStreamScheduleAsync(
            string broadcasterId,
            bool isVacationEnabled,
            global::System.DateTime vacationStartTime,
            global::System.DateTime vacationEndTime,
            string timezone,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/schedule/settings?broadcaster_id={broadcasterId}&is_vacation_enabled={isVacationEnabled}&vacation_start_time={vacationStartTime}&vacation_end_time={vacationEndTime}&timezone={timezone}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}