//HintName: G.Api.UpdateRunRunsRunIdPatch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareUpdateRunRunsRunIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string runId,
            global::G.RunUpdateSchemaExtended request);
        partial void PrepareUpdateRunRunsRunIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string runId,
            global::G.RunUpdateSchemaExtended request);
        partial void ProcessUpdateRunRunsRunIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRunRunsRunIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> UpdateRunRunsRunIdPatchAsync(
            string runId,
            global::G.RunUpdateSchemaExtended request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateRunRunsRunIdPatchArguments(
                httpClient: _httpClient,
                runId: ref runId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/runs/{runId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateRunRunsRunIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                runId: runId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateRunRunsRunIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateRunRunsRunIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> UpdateRunRunsRunIdPatchAsync(
            string runId,
            global::System.DateTime endTime = default,
            string? error = default,
            global::System.AnyOf<object?, global::G.CreateChatCompletionRequest?, global::G.CreateCompletionRequest?>? inputs = default,
            global::System.AnyOf<object?, global::G.CreateChatCompletionResponse?, global::G.CreateCompletionResponse?>? outputs = default,
            global::System.Collections.Generic.IList<object?>? events = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.RunUpdateSchemaExtended
            {
                EndTime = endTime,
                Error = error,
                Inputs = inputs,
                Outputs = outputs,
                Events = events,
            };

            return await UpdateRunRunsRunIdPatchAsync(
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}