//HintName: G.ExamplesClient.UpdateExample.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareUpdateExampleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid exampleId,
            global::G.ExampleUpdate request);
        partial void PrepareUpdateExampleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid exampleId,
            global::G.ExampleUpdate request);
        partial void ProcessUpdateExampleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateExampleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::G.ExampleUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateExampleArguments(
                httpClient: _httpClient,
                exampleId: ref exampleId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/examples/{exampleId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateExampleRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                exampleId: exampleId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateExampleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateExampleResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateExampleApiV1ExamplesExampleIdPatchResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="metadata"></param>
        /// <param name="split"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::G.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::G.AnyOf<global::G.ExampleUpdateInputs, object>? inputs = default,
            global::G.AnyOf<global::G.ExampleUpdateOutputs, object>? outputs = default,
            global::G.AnyOf<global::G.ExampleUpdateMetadata, object>? metadata = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? split = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ExampleUpdate
            {
                DatasetId = datasetId,
                Inputs = inputs,
                Outputs = outputs,
                Metadata = metadata,
                Split = split,
            };

            return await UpdateExampleAsync(
                exampleId: exampleId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}