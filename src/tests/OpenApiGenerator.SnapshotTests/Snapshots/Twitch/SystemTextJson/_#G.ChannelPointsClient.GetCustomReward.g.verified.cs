//HintName: G.ChannelPointsClient.GetCustomReward.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        partial void PrepareGetCustomRewardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::System.Collections.Generic.IList<string>? id,
            ref bool onlyManageableRewards);
        partial void PrepareGetCustomRewardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id,
            bool onlyManageableRewards);
        partial void ProcessGetCustomRewardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCustomRewardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of custom rewards that the specified broadcaster created.<br/>
        /// Gets a list of custom rewards that the specified broadcaster created.<br/>
        /// **NOTE**: A channel may offer a maximum of 50 rewards, which includes both enabled and disabled rewards.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:redemptions** or **channel:manage:redemptions** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="onlyManageableRewards"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetCustomRewardResponse> GetCustomRewardAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id = default,
            bool onlyManageableRewards = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetCustomRewardArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                id: id,
                onlyManageableRewards: ref onlyManageableRewards);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/channel_points/custom_rewards?broadcaster_id={broadcasterId}&{string.Join("&", id?.Select(static x => $"id={x}") ?? global::System.Array.Empty<string>())}&only_manageable_rewards={onlyManageableRewards}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetCustomRewardRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                id: id,
                onlyManageableRewards: onlyManageableRewards);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetCustomRewardResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetCustomRewardResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetCustomRewardResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}