//HintName: G.ChannelPointsClient.UpdateCustomReward.g.cs

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        /// <summary>
        /// Updates a custom reward.<br/>
        /// Updates a custom reward. The app used to create the reward is the only app that may update the reward.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/api/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.<br/>
        /// __Request Body:__<br/>
        /// The body of the request should contain only the fields you’re updating.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateCustomRewardResponse> UpdateCustomRewardAsync(
            string broadcasterId,
            string id,
            global::G.UpdateCustomRewardBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/channel_points/custom_rewards?broadcaster_id={broadcasterId}&id={id}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateCustomRewardResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates a custom reward.<br/>
        /// Updates a custom reward. The app used to create the reward is the only app that may update the reward.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/api/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.<br/>
        /// __Request Body:__<br/>
        /// The body of the request should contain only the fields you’re updating.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="prompt"></param>
        /// <param name="cost"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="isEnabled"></param>
        /// <param name="isUserInputRequired"></param>
        /// <param name="isMaxPerStreamEnabled"></param>
        /// <param name="maxPerStream"></param>
        /// <param name="isMaxPerUserPerStreamEnabled"></param>
        /// <param name="maxPerUserPerStream"></param>
        /// <param name="isGlobalCooldownEnabled"></param>
        /// <param name="globalCooldownSeconds"></param>
        /// <param name="isPaused"></param>
        /// <param name="shouldRedemptionsSkipRequestQueue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateCustomRewardResponse> UpdateCustomRewardAsync(
            string broadcasterId,
            string id,
            string? title = default,
            string? prompt = default,
            long cost = default,
            string? backgroundColor = default,
            bool isEnabled = default,
            bool isUserInputRequired = default,
            bool isMaxPerStreamEnabled = default,
            long maxPerStream = default,
            bool isMaxPerUserPerStreamEnabled = default,
            long maxPerUserPerStream = default,
            bool isGlobalCooldownEnabled = default,
            long globalCooldownSeconds = default,
            bool isPaused = default,
            bool shouldRedemptionsSkipRequestQueue = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateCustomRewardBody
            {
                Title = title,
                Prompt = prompt,
                Cost = cost,
                BackgroundColor = backgroundColor,
                IsEnabled = isEnabled,
                IsUserInputRequired = isUserInputRequired,
                IsMaxPerStreamEnabled = isMaxPerStreamEnabled,
                MaxPerStream = maxPerStream,
                IsMaxPerUserPerStreamEnabled = isMaxPerUserPerStreamEnabled,
                MaxPerUserPerStream = maxPerUserPerStream,
                IsGlobalCooldownEnabled = isGlobalCooldownEnabled,
                GlobalCooldownSeconds = globalCooldownSeconds,
                IsPaused = isPaused,
                ShouldRedemptionsSkipRequestQueue = shouldRedemptionsSkipRequestQueue,
            };

            return await UpdateCustomRewardAsync(
                broadcasterId: broadcasterId,
                id: id,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}