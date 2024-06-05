//HintName: G.ChannelPointsClient.GetCustomReward.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ChannelPointsClient
    {
        /// <summary>
        /// Gets a list of custom rewards that the specified broadcaster created.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="onlyManageableRewards"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetCustomRewardResponse> GetCustomRewardAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<string> id,
            bool onlyManageableRewards,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/channel_points/custom_rewards?broadcaster_id={broadcasterId}&{string.Join("&", id.Select(static x => $"id={x}"))}&only_manageable_rewards={onlyManageableRewards}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GetCustomRewardResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}