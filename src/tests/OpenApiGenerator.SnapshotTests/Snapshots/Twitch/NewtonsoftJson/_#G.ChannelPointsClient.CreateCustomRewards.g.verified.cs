//HintName: G.ChannelPointsClient.CreateCustomRewards.g.cs

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/channel_points/custom_rewards?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateCustomRewardsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a Custom Reward in the broadcaster’s channel.<br/>
        /// Creates a Custom Reward in the broadcaster’s channel. The maximum number of custom rewards per channel is 50, which includes both enabled and disabled rewards.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="title"></param>
        /// <param name="cost"></param>
        /// <param name="prompt"></param>
        /// <param name="isEnabled"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="isUserInputRequired"></param>
        /// <param name="isMaxPerStreamEnabled"></param>
        /// <param name="maxPerStream"></param>
        /// <param name="isMaxPerUserPerStreamEnabled"></param>
        /// <param name="maxPerUserPerStream"></param>
        /// <param name="isGlobalCooldownEnabled"></param>
        /// <param name="globalCooldownSeconds"></param>
        /// <param name="shouldRedemptionsSkipRequestQueue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCustomRewardsResponse> CreateCustomRewardsAsync(
            string broadcasterId,
            string title,
            long cost,
            string? prompt = default,
            bool isEnabled = default,
            string? backgroundColor = default,
            bool isUserInputRequired = default,
            bool isMaxPerStreamEnabled = default,
            int maxPerStream = default,
            bool isMaxPerUserPerStreamEnabled = default,
            int maxPerUserPerStream = default,
            bool isGlobalCooldownEnabled = default,
            int globalCooldownSeconds = default,
            bool shouldRedemptionsSkipRequestQueue = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateCustomRewardsBody
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
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}