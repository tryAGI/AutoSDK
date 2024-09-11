//HintName: G.PipelinesClient.RetrieveByPointerV4PipelinesByPointerPointerGet.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareRetrieveByPointerV4PipelinesByPointerPointerGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pointer,
            ref bool includePointers,
            ref bool includeExtras,
            ref string? pipelineId,
            ref string? pipelineIdOrPointer);
        partial void PrepareRetrieveByPointerV4PipelinesByPointerPointerGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pointer,
            bool includePointers,
            bool includeExtras,
            string? pipelineId,
            string? pipelineIdOrPointer);
        partial void ProcessRetrieveByPointerV4PipelinesByPointerPointerGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveByPointerV4PipelinesByPointerPointerGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve By Pointer<br/>
        /// Retrieve details for a pipeline by pointer name.<br/>
        /// Note that the fields this endpoint returns are dependent on the provided<br/>
        /// query parameters and will omit any empty fields.<br/>
        /// Accepted query parameters are:<br/>
        /// - include_pointers: include any pointers that point to this pipeline
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="includePointers">
        /// Default Value: false
        /// </param>
        /// <param name="includeExtras">
        /// Default Value: false
        /// </param>
        /// <param name="pipelineId"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AppSchemasPipelineGetDetailed> RetrieveByPointerV4PipelinesByPointerPointerGetAsync(
            string pointer,
            bool includePointers = false,
            bool includeExtras = false,
            string? pipelineId = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRetrieveByPointerV4PipelinesByPointerPointerGetArguments(
                httpClient: _httpClient,
                pointer: ref pointer,
                includePointers: ref includePointers,
                includeExtras: ref includeExtras,
                pipelineId: ref pipelineId,
                pipelineIdOrPointer: ref pipelineIdOrPointer);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pipelines/by-pointer/{pointer}?include_pointers={includePointers}&include_extras={includeExtras}&pipeline_id={pipelineId}&pipeline_id_or_pointer={pipelineIdOrPointer}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRetrieveByPointerV4PipelinesByPointerPointerGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pointer: pointer,
                includePointers: includePointers,
                includeExtras: includeExtras,
                pipelineId: pipelineId,
                pipelineIdOrPointer: pipelineIdOrPointer);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRetrieveByPointerV4PipelinesByPointerPointerGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRetrieveByPointerV4PipelinesByPointerPointerGetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AppSchemasPipelineGetDetailed?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}