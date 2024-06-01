//HintName: G.GistsClient.GistsUpdate.g.cs

#nullable enable

namespace G
{
    public partial class GistsClient
    {
        /// <summary>
        /// Update a gist
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GistSimple> GistsUpdateAsync(
            string gistId,
            GistsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/gists/{gistId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GistSimple?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a gist
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="description"></param>
        /// <param name="files"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GistSimple> GistsUpdateAsync(
            string gistId,
            string? description = default,
            object? files = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new GistsUpdateRequest
            {
                Description = description,
                Files = files,
            };

            return await GistsUpdateAsync(
                gistId: gistId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}