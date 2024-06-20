//HintName: G.ConduitsClient.UpdateConduitShards.g.cs

#nullable enable

namespace G
{
    public partial class ConduitsClient
    {
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/eventsub/conduits/shards", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateConduitShardsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// NEW Updates shard(s) for a conduit.<br/>
        /// NEW Updates shard(s) for a [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).<br/>
        /// **NOTE:** Shard IDs are indexed starting at 0, so a conduit with a `shard_count` of 5 will have shards with IDs 0 through 4.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).
        /// </summary>
        /// <param name="conduitId"></param>
        /// <param name="shards"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateConduitShardsResponse> UpdateConduitShardsAsync(
            string conduitId,
            global::System.Collections.Generic.IList<global::G.UpdateConduitShardsBodyShards> shards,
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