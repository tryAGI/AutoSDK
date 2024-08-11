//HintName: G.ConduitsClient.GetConduitShards.g.cs

#nullable enable

namespace G
{
    public partial class ConduitsClient
    {
        partial void PrepareGetConduitShardsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string conduitId,
            ref string? status,
            ref string? after);
        partial void PrepareGetConduitShardsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string conduitId,
            string? status,
            string? after);
        partial void ProcessGetConduitShardsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetConduitShardsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// NEW Gets a lists of all shards for a conduit.<br/>
        /// NEW Gets a lists of all shards for a [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="conduitId"></param>
        /// <param name="status"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetConduitShardsResponse> GetConduitShardsAsync(
            string conduitId,
            string? status,
            string? after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetConduitShardsArguments(
                httpClient: _httpClient,
                conduitId: ref conduitId,
                status: ref status,
                after: ref after);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/eventsub/conduits/shards?conduit_id={conduitId}&status={status}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetConduitShardsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                conduitId: conduitId,
                status: status,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetConduitShardsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetConduitShardsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetConduitShardsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}