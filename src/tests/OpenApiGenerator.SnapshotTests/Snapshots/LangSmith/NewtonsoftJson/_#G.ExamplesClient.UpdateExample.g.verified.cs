//HintName: G.ExamplesClient.UpdateExample.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareUpdateExampleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string exampleId,
            global::G.ExampleUpdate request);
        partial void PrepareUpdateExampleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string exampleId,
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
        public async global::System.Threading.Tasks.Task<object> UpdateExampleAsync(
            string exampleId,
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
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/examples/{exampleId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<object?>(__content, _jsonSerializerOptions) ??
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
        public async global::System.Threading.Tasks.Task<object> UpdateExampleAsync(
            string exampleId,
            global::System.AnyOf<string?, object?>? datasetId = default,
            global::System.AnyOf<object?, object?>? inputs = default,
            global::System.AnyOf<object?, object?>? outputs = default,
            global::System.AnyOf<object?, object?>? metadata = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string?>?, string?, object?>? split = default,
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