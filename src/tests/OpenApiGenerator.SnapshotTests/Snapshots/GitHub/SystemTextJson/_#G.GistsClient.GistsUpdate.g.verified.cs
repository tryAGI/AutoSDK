//HintName: G.GistsClient.GistsUpdate.g.cs

#nullable enable

namespace G
{
    public partial class GistsClient
    {
        partial void PrepareGistsUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string gistId,
            global::G.GistsUpdateRequest request);
        partial void PrepareGistsUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string gistId,
            global::G.GistsUpdateRequest request);
        partial void ProcessGistsUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGistsUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a gist<br/>
        /// Allows you to update a gist's description and to update, delete, or rename gist files. Files<br/>
        /// from the previous version of the gist that aren't explicitly changed during an edit<br/>
        /// are unchanged.<br/>
        /// At least one of `description` or `files` is required.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.base64+json`**: Returns the base64-encoded contents. This can be useful if your gist contains any invalid UTF-8 sequences.
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GistSimple> GistsUpdateAsync(
            string gistId,
            global::G.GistsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGistsUpdateArguments(
                httpClient: _httpClient,
                gistId: ref gistId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/gists/{gistId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGistsUpdateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                gistId: gistId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGistsUpdateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGistsUpdateResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GistSimple?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a gist<br/>
        /// Allows you to update a gist's description and to update, delete, or rename gist files. Files<br/>
        /// from the previous version of the gist that aren't explicitly changed during an edit<br/>
        /// are unchanged.<br/>
        /// At least one of `description` or `files` is required.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.base64+json`**: Returns the base64-encoded contents. This can be useful if your gist contains any invalid UTF-8 sequences.
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="description">
        /// The description of the gist.<br/>
        /// Example: Example Ruby script
        /// </param>
        /// <param name="files">
        /// The gist files to be updated, renamed, or deleted. Each `key` must match the current filename<br/>
        /// (including extension) of the targeted gist file. For example: `hello.py`.<br/>
        /// To delete a file, set the whole file to null. For example: `hello.py : null`. The file will also be<br/>
        /// deleted if the specified object does not contain at least one of `content` or `filename`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GistSimple> GistsUpdateAsync(
            string gistId,
            string? description = default,
            object? files = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.GistsUpdateRequest
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