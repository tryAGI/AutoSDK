//HintName: G.ScheduleClient.UpdateChannelStreamSchedule.g.cs

#nullable enable

namespace G
{
    public partial class ScheduleClient
    {
        partial void PrepareUpdateChannelStreamScheduleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref bool? isVacationEnabled,
            ref global::System.DateTime? vacationStartTime,
            ref global::System.DateTime? vacationEndTime,
            ref string? timezone);
        partial void PrepareUpdateChannelStreamScheduleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            bool? isVacationEnabled,
            global::System.DateTime? vacationStartTime,
            global::System.DateTime? vacationEndTime,
            string? timezone);
        partial void ProcessUpdateChannelStreamScheduleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
            bool? isVacationEnabled = default,
            global::System.DateTime? vacationStartTime = default,
            global::System.DateTime? vacationEndTime = default,
            string? timezone = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUpdateChannelStreamScheduleArguments(
                httpClient: HttpClient,
                broadcasterId: ref broadcasterId,
                isVacationEnabled: ref isVacationEnabled,
                vacationStartTime: ref vacationStartTime,
                vacationEndTime: ref vacationEndTime,
                timezone: ref timezone);

            var __pathBuilder = new PathBuilder(
                path: "/schedule/settings",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddOptionalParameter("is_vacation_enabled", isVacationEnabled?.ToString()) 
                .AddOptionalParameter("vacation_start_time", vacationStartTime?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("vacation_end_time", vacationEndTime?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("timezone", timezone) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateChannelStreamScheduleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                broadcasterId: broadcasterId,
                isVacationEnabled: isVacationEnabled,
                vacationStartTime: vacationStartTime,
                vacationEndTime: vacationEndTime,
                timezone: timezone);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateChannelStreamScheduleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}