//HintName: G.BitsClient.GetBitsLeaderboard.g.cs

#nullable enable

namespace G
{
    public partial class BitsClient
    {
        partial void PrepareGetBitsLeaderboardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? count,
            ref global::G.GetBitsLeaderboardPeriod? period,
            ref global::System.DateTime? startedAt,
            ref string? userId);
        partial void PrepareGetBitsLeaderboardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? count,
            global::G.GetBitsLeaderboardPeriod? period,
            global::System.DateTime? startedAt,
            string? userId);
        partial void ProcessGetBitsLeaderboardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetBitsLeaderboardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the Bits leaderboard for the authenticated broadcaster.<br/>
        /// Gets the Bits leaderboard for the authenticated broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **bits:read** scope.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="period"></param>
        /// <param name="startedAt"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetBitsLeaderboardResponse> GetBitsLeaderboardAsync(
            int? count = default,
            global::G.GetBitsLeaderboardPeriod? period = default,
            global::System.DateTime? startedAt = default,
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetBitsLeaderboardArguments(
                httpClient: HttpClient,
                count: ref count,
                period: ref period,
                startedAt: ref startedAt,
                userId: ref userId);

            var periodValue = period switch
            {
                global::G.GetBitsLeaderboardPeriod.Day => "day",
                global::G.GetBitsLeaderboardPeriod.Week => "week",
                global::G.GetBitsLeaderboardPeriod.Month => "month",
                global::G.GetBitsLeaderboardPeriod.Year => "year",
                global::G.GetBitsLeaderboardPeriod.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/bits/leaderboard",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("count", count?.ToString()) 
                .AddOptionalParameter("period", periodValue?.ToString()) 
                .AddOptionalParameter("started_at", startedAt?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("user_id", userId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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
            PrepareGetBitsLeaderboardRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                count: count,
                period: period,
                startedAt: startedAt,
                userId: userId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetBitsLeaderboardResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetBitsLeaderboardResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.GetBitsLeaderboardResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}