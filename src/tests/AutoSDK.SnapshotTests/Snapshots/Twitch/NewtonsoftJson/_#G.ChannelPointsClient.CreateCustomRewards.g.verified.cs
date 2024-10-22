//HintName: G.ChannelPointsClient.CreateCustomRewards.g.cs

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        partial void PrepareCreateCustomRewardsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::G.CreateCustomRewardsBody request);
        partial void PrepareCreateCustomRewardsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::G.CreateCustomRewardsBody request);
        partial void ProcessCreateCustomRewardsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateCustomRewardsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a Custom Reward in the broadcaster’s channel.<br/>
        /// Creates a Custom Reward in the broadcaster’s channel. The maximum number of custom rewards per channel is 50, which includes both enabled and disabled rewards.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCustomRewardsResponse> CreateCustomRewardsAsync(
            string broadcasterId,
            global::G.CreateCustomRewardsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateCustomRewardsArguments(
                httpClient: HttpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/channel_points/custom_rewards",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateCustomRewardsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                broadcasterId: broadcasterId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateCustomRewardsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateCustomRewardsResponseContent(
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
                global::G.CreateCustomRewardsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a Custom Reward in the broadcaster’s channel.<br/>
        /// Creates a Custom Reward in the broadcaster’s channel. The maximum number of custom rewards per channel is 50, which includes both enabled and disabled rewards.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="title">
        /// The custom reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.
        /// </param>
        /// <param name="cost">
        /// The cost of the reward, in Channel Points. The minimum is 1 point.
        /// </param>
        /// <param name="prompt">
        /// The prompt shown to the viewer when they redeem the reward. Specify a prompt if `is_user_input_required` is **true**. The prompt is limited to a maximum of 200 characters.
        /// </param>
        /// <param name="isEnabled">
        /// A Boolean value that determines whether the reward is enabled. Viewers see only enabled rewards. The default is **true**.
        /// </param>
        /// <param name="backgroundColor">
        /// The background color to use for the reward. Specify the color using Hex format (for example, #9147FF).
        /// </param>
        /// <param name="isUserInputRequired">
        /// A Boolean value that determines whether the user needs to enter information when redeeming the reward. See the `prompt` field. The default is **false**.
        /// </param>
        /// <param name="isMaxPerStreamEnabled">
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the `max_per_stream` field). The default is **false**.
        /// </param>
        /// <param name="maxPerStream">
        /// The maximum number of redemptions allowed per live stream. Applied only if `is_max_per_stream_enabled` is **true**. The minimum value is 1.
        /// </param>
        /// <param name="isMaxPerUserPerStreamEnabled">
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see the `max_per_user_per_stream` field). The default is **false**.
        /// </param>
        /// <param name="maxPerUserPerStream">
        /// The maximum number of redemptions allowed per user per stream. Applied only if `is_max_per_user_per_stream_enabled` is **true**. The minimum value is 1.
        /// </param>
        /// <param name="isGlobalCooldownEnabled">
        /// A Boolean value that determines whether to apply a cooldown period between redemptions (see the `global_cooldown_seconds` field for the duration of the cooldown period). The default is **false**.
        /// </param>
        /// <param name="globalCooldownSeconds">
        /// The cooldown period, in seconds. Applied only if the `is_global_cooldown_enabled` field is **true**. The minimum value is 1; however, the minimum value is 60 for it to be shown in the Twitch UX.
        /// </param>
        /// <param name="shouldRedemptionsSkipRequestQueue">
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process. The default is **false**.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCustomRewardsResponse> CreateCustomRewardsAsync(
            string broadcasterId,
            string title,
            long cost,
            string? prompt = default,
            bool? isEnabled = default,
            string? backgroundColor = default,
            bool? isUserInputRequired = default,
            bool? isMaxPerStreamEnabled = default,
            int? maxPerStream = default,
            bool? isMaxPerUserPerStreamEnabled = default,
            int? maxPerUserPerStream = default,
            bool? isGlobalCooldownEnabled = default,
            int? globalCooldownSeconds = default,
            bool? shouldRedemptionsSkipRequestQueue = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateCustomRewardsBody
            {
                Title = title,
                Cost = cost,
                Prompt = prompt,
                IsEnabled = isEnabled,
                BackgroundColor = backgroundColor,
                IsUserInputRequired = isUserInputRequired,
                IsMaxPerStreamEnabled = isMaxPerStreamEnabled,
                MaxPerStream = maxPerStream,
                IsMaxPerUserPerStreamEnabled = isMaxPerUserPerStreamEnabled,
                MaxPerUserPerStream = maxPerUserPerStream,
                IsGlobalCooldownEnabled = isGlobalCooldownEnabled,
                GlobalCooldownSeconds = globalCooldownSeconds,
                ShouldRedemptionsSkipRequestQueue = shouldRedemptionsSkipRequestQueue,
            };

            return await CreateCustomRewardsAsync(
                broadcasterId: broadcasterId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}