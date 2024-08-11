//HintName: G.ChannelPointsClient.GetCustomRewardRedemption.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        partial void PrepareGetCustomRewardRedemptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string rewardId,
            ref global::G.GetCustomRewardRedemptionStatus? status,
            global::System.Collections.Generic.IList<string>? id,
            ref global::G.GetCustomRewardRedemptionSort? sort,
            ref string? after,
            ref int first);
        partial void PrepareGetCustomRewardRedemptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string rewardId,
            global::G.GetCustomRewardRedemptionStatus? status,
            global::System.Collections.Generic.IList<string>? id,
            global::G.GetCustomRewardRedemptionSort? sort,
            string? after,
            int first);
        partial void ProcessGetCustomRewardRedemptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCustomRewardRedemptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
            global::G.GetCustomRewardRedemptionStatus? status,
            global::System.Collections.Generic.IList<string>? id,
            global::G.GetCustomRewardRedemptionSort? sort,
            string? after,
            int first,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetCustomRewardRedemptionArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                rewardId: ref rewardId,
                status: ref status,
                id: id,
                sort: ref sort,
                after: ref after,
                first: ref first);

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
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/channel_points/custom_rewards/redemptions?broadcaster_id={broadcasterId}&reward_id={rewardId}&status={statusValue}&{string.Join("&", id?.Select(static x => $"id={x}") ?? global::System.Array.Empty<string>())}&sort={sortValue}&after={after}&first={first}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetCustomRewardRedemptionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                status: status,
                id: id,
                sort: sort,
                after: after,
                first: first);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetCustomRewardRedemptionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetCustomRewardRedemptionResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetCustomRewardRedemptionResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}