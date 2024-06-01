//HintName: G.RaidsClient.StartARaid.g.cs

#nullable enable

namespace G
{
    public partial class RaidsClient
    {
        /// <summary>
        /// Raid another channel by sending the broadcaster’s viewers to the targeted channel.
        /// </summary>
        /// <param name="fromBroadcasterId"></param>
        /// <param name="toBroadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<StartRaidResponse> StartARaidAsync(
            string fromBroadcasterId,
            string toBroadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/raids?from_broadcaster_id={fromBroadcasterId}&to_broadcaster_id={toBroadcasterId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<StartRaidResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}