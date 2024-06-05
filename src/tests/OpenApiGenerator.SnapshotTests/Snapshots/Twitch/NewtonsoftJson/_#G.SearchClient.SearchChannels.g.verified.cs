//HintName: G.SearchClient.SearchChannels.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        /// <summary>
        /// Gets the channels that match the specified query and have streamed content within the past 6 months.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="liveOnly"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<SearchChannelsResponse> SearchChannelsAsync(
            string query,
            bool liveOnly,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/search/channels?query={query}&live_only={liveOnly}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<SearchChannelsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}