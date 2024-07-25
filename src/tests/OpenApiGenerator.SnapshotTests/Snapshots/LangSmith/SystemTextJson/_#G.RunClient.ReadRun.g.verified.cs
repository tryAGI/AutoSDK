//HintName: G.RunClient.ReadRun.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareReadRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string runId,
            ref bool excludeS3StoredAttributes);
        partial void PrepareReadRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string runId,
            bool excludeS3StoredAttributes);
        partial void ProcessReadRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Run<br/>
        /// Get a specific run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunSchema> ReadRunAsync(
            string runId,
            bool excludeS3StoredAttributes,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadRunArguments(
                httpClient: _httpClient,
                runId: ref runId,
                excludeS3StoredAttributes: ref excludeS3StoredAttributes);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/runs/{runId}?exclude_s3_stored_attributes={excludeS3StoredAttributes}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadRunRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                runId: runId,
                excludeS3StoredAttributes: excludeS3StoredAttributes);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadRunResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunSchema?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}