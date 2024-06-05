//HintName: G.HypeTrainClient.GetHypeTrainEvents.g.cs

#nullable enable

namespace G
{
    public partial class HypeTrainClient
    {
        /// <summary>
        /// Gets information about the broadcaster’s current or most recent Hype Train event.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetHypeTrainEventsResponse> GetHypeTrainEventsAsync(
            string broadcasterId,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/hypetrain/events?broadcaster_id={broadcasterId}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetHypeTrainEventsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}