//HintName: G.ConduitsClient.UpdateConduitShards.g.cs

#nullable enable

namespace G
{
    public partial class ConduitsClient
    {
        /// <summary>
        /// NEW Updates shard(s) for a conduit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateConduitShardsResponse> UpdateConduitShardsAsync(
            UpdateConduitShardsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/eventsub/conduits/shards", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<UpdateConduitShardsResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// NEW Updates shard(s) for a conduit.
        /// </summary>
        /// <param name="conduitId"></param>
        /// <param name="shards"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateConduitShardsResponse> UpdateConduitShardsAsync(
            string conduitId,
            global::System.Collections.Generic.IList<UpdateConduitShardsBodyShards> shards,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new UpdateConduitShardsBody
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