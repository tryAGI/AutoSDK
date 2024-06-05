//HintName: G.ChannelPointsClient.UpdateCustomReward.g.cs

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        /// <summary>
        /// Updates a custom reward.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateCustomRewardResponse> UpdateCustomRewardAsync(
            string broadcasterId,
            string id,
            UpdateCustomRewardBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/channel_points/custom_rewards?broadcaster_id={broadcasterId}&id={id}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateCustomRewardResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates a custom reward.
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
        public async global::System.Threading.Tasks.Task<UpdateCustomRewardResponse> UpdateCustomRewardAsync(
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
            var request = new UpdateCustomRewardBody
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