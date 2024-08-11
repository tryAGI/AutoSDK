//HintName: G.ConduitsClient.UpdateConduitShards.g.cs

#nullable enable

namespace G
{
    public partial class ConduitsClient
    {
        partial void PrepareUpdateConduitShardsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UpdateConduitShardsBody request);
        partial void PrepareUpdateConduitShardsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UpdateConduitShardsBody request);
        partial void ProcessUpdateConduitShardsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateConduitShardsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// NEW Updates shard(s) for a conduit.<br/>
        /// NEW Updates shard(s) for a [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).<br/>
        /// **NOTE:** Shard IDs are indexed starting at 0, so a conduit with a `shard_count` of 5 will have shards with IDs 0 through 4.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateConduitShardsResponse> UpdateConduitShardsAsync(
            global::G.UpdateConduitShardsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateConduitShardsArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/eventsub/conduits/shards", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateConduitShardsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateConduitShardsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateConduitShardsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateConduitShardsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// NEW Updates shard(s) for a conduit.<br/>
        /// NEW Updates shard(s) for a [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).<br/>
        /// **NOTE:** Shard IDs are indexed starting at 0, so a conduit with a `shard_count` of 5 will have shards with IDs 0 through 4.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="conduitId">
        /// Conduit ID.
        /// </param>
        /// <param name="shards">
        /// List of shards to update.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateConduitShardsResponse> UpdateConduitShardsAsync(
            string conduitId,
            global::System.Collections.Generic.IList<global::G.UpdateConduitShardsBodyShard> shards,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateConduitShardsBody
            {
                ConduitId = conduitId,
                Shards = shards,
            };

            return await UpdateConduitShardsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}