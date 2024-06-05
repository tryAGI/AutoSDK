//HintName: G.ConduitsClient.UpdateConduits.g.cs

#nullable enable

namespace G
{
    public partial class ConduitsClient
    {
        /// <summary>
        /// NEW Updates a conduit’s shard count.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateConduitsResponse> UpdateConduitsAsync(
            UpdateConduitsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/eventsub/conduits", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateConduitsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// NEW Updates a conduit’s shard count.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="shardCount"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateConduitsResponse> UpdateConduitsAsync(
            string id,
            int shardCount,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new UpdateConduitsBody
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