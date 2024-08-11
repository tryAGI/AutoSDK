//HintName: G.ConduitsClient.UpdateConduits.g.cs

#nullable enable

namespace G
{
    public partial class ConduitsClient
    {
        partial void PrepareUpdateConduitsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UpdateConduitsBody request);
        partial void PrepareUpdateConduitsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UpdateConduitsBody request);
        partial void ProcessUpdateConduitsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateConduitsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// NEW Updates a conduit’s shard count.<br/>
        /// NEW Updates a [conduit’s](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) shard count. To delete shards, update the count to a lower number, and the shards above the count will be deleted. For example, if the existing shard count is 100, by resetting shard count to 50, shards 50-99 are disabled.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateConduitsResponse> UpdateConduitsAsync(
            global::G.UpdateConduitsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateConduitsArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/eventsub/conduits", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateConduitsRequest(
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
            ProcessUpdateConduitsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateConduitsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateConduitsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// NEW Updates a conduit’s shard count.<br/>
        /// NEW Updates a [conduit’s](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) shard count. To delete shards, update the count to a lower number, and the shards above the count will be deleted. For example, if the existing shard count is 100, by resetting shard count to 50, shards 50-99 are disabled.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="id">
        /// Conduit ID.
        /// </param>
        /// <param name="shardCount">
        /// The new number of shards for this conduit.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateConduitsResponse> UpdateConduitsAsync(
            string id,
            int shardCount,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateConduitsBody
            {
                Id = id,
                ShardCount = shardCount,
            };

            return await UpdateConduitsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}