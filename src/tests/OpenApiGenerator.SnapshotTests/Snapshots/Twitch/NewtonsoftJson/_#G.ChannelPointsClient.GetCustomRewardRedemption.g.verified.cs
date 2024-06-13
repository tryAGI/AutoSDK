//HintName: G.ChannelPointsClient.GetCustomRewardRedemption.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        /// <summary>
        /// Gets a list of redemptions for a custom reward.<br/>
        /// Gets a list of redemptions for the specified custom reward. The app used to create the reward is the only app that may get the redemptions.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:redemptions** or **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="rewardId"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="sort"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetCustomRewardRedemptionResponse> GetCustomRewardRedemptionAsync(
            string broadcasterId,
            string rewardId,
            global::G.GetCustomRewardRedemptionStatus status,
            global::System.Collections.Generic.IList<string> id,
            global::G.GetCustomRewardRedemptionSort sort,
            string after,
            int first,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var statusValue = status switch
            {
                global::G.GetCustomRewardRedemptionStatus.CANCELED => "CANCELED",
                global::G.GetCustomRewardRedemptionStatus.FULFILLED => "FULFILLED",
                global::G.GetCustomRewardRedemptionStatus.UNFULFILLED => "UNFULFILLED",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.GetCustomRewardRedemptionSort.OLDEST => "OLDEST",
                global::G.GetCustomRewardRedemptionSort.NEWEST => "NEWEST",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/channel_points/custom_rewards/redemptions?broadcaster_id={broadcasterId}&reward_id={rewardId}&status={statusValue}&{string.Join("&", id.Select(static x => $"id={x}"))}&sort={sortValue}&after={after}&first={first}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetCustomRewardRedemptionResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}