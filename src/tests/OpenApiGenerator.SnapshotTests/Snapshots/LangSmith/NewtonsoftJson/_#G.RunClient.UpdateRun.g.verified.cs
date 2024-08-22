//HintName: G.RunClient.UpdateRun.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareUpdateRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string runId,
            global::G.UpdateRunRequest request);
        partial void PrepareUpdateRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string runId,
            global::G.UpdateRunRequest request);
        partial void ProcessUpdateRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRunResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::G.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunAsync(
            string runId,
            global::G.UpdateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateRunArguments(
                httpClient: _httpClient,
                runId: ref runId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/runs/{runId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateRunRequest(
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
            ProcessUpdateRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateRunResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateRunApiV1RunsRunIdPatchResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="parentRunId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="extra"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateRunApiV1RunsRunIdPatchResponse> UpdateRunAsync(
            string runId,
            global::System.OneOf<string, object>? traceId = default,
            global::System.OneOf<string?, object>? dottedOrder = default,
            global::System.OneOf<string, object>? parentRunId = default,
            global::System.OneOf<string?, double?, object>? endTime = default,
            global::System.OneOf<string?, object>? error = default,
            global::System.OneOf<global::G.UpdateRunRequestInputs, object>? inputs = default,
            global::System.OneOf<global::G.UpdateRunRequestOutputs, object>? outputs = default,
            global::System.OneOf<global::System.Collections.Generic.IList<global::G.UpdateRunRequestEventsVariant1Item>, object>? events = default,
            global::System.OneOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::System.OneOf<global::G.UpdateRunRequestExtra, object>? extra = default,
            global::System.OneOf<global::G.UpdateRunRequestInputAttachments, object>? inputAttachments = default,
            global::System.OneOf<global::G.UpdateRunRequestOutputAttachments, object>? outputAttachments = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateRunRequest
            {
                TraceId = traceId,
                DottedOrder = dottedOrder,
                ParentRunId = parentRunId,
                EndTime = endTime,
                Error = error,
                Inputs = inputs,
                Outputs = outputs,
                Events = events,
                Tags = tags,
                Extra = extra,
                InputAttachments = inputAttachments,
                OutputAttachments = outputAttachments,
            };

            return await UpdateRunAsync(
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}