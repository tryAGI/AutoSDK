//HintName: G.PipelinesClient.RetrieveByPointer.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareRetrieveByPointerArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pointer,
            ref bool? includePointers,
            ref bool? includeExtras,
            ref string? pipelineId,
            ref string? pipelineIdOrPointer);
        partial void PrepareRetrieveByPointerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pointer,
            bool? includePointers,
            bool? includeExtras,
            string? pipelineId,
            string? pipelineIdOrPointer);
        partial void ProcessRetrieveByPointerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveByPointerResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::G.AppSchemasPipelineGetDetailed> RetrieveByPointerAsync(
            string pointer,
            bool? includePointers = false,
            bool? includeExtras = false,
            string? pipelineId = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareRetrieveByPointerArguments(
                httpClient: _httpClient,
                pointer: ref pointer,
                includePointers: ref includePointers,
                includeExtras: ref includeExtras,
                pipelineId: ref pipelineId,
                pipelineIdOrPointer: ref pipelineIdOrPointer);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/by-pointer/{pointer}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("include_pointers", includePointers?.ToString()) 
                .AddOptionalParameter("include_extras", includeExtras?.ToString()) 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                .AddOptionalParameter("pipeline_id_or_pointer", pipelineIdOrPointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRetrieveByPointerRequest(
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
            ProcessRetrieveByPointerResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRetrieveByPointerResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.AppSchemasPipelineGetDetailed?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}