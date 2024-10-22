//HintName: G.PipelinesClient.Retrieve.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineId,
            ref bool? includePointers,
            ref bool? includeExtras,
            ref string? pointer,
            ref string? pipelineIdOrPointer);
        partial void PrepareRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineId,
            bool? includePointers,
            bool? includeExtras,
            string? pointer,
            string? pipelineIdOrPointer);
        partial void ProcessRetrieveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve<br/>
        /// Retrieve details for a pipeline.<br/>
        /// Note that the fields this endpoint returns are dependent on the provided<br/>
        /// query parameters and will omit any empty fields.<br/>
        /// Accepted query parameters are:<br/>
        /// - include_pointers: include any pointers that point to this pipeline
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="includePointers">
        /// Default Value: false
        /// </param>
        /// <param name="includeExtras">
        /// Default Value: false
        /// </param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AppSchemasPipelineGetDetailed> RetrieveAsync(
            string pipelineId,
            bool? includePointers = false,
            bool? includeExtras = false,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRetrieveArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                includePointers: ref includePointers,
                includeExtras: ref includeExtras,
                pointer: ref pointer,
                pipelineIdOrPointer: ref pipelineIdOrPointer);

            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/{pipelineId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("include_pointers", includePointers?.ToString()) 
                .AddOptionalParameter("include_extras", includeExtras?.ToString()) 
                .AddOptionalParameter("pointer", pointer) 
                .AddOptionalParameter("pipeline_id_or_pointer", pipelineIdOrPointer) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRetrieveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                includePointers: includePointers,
                includeExtras: includeExtras,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRetrieveResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessRetrieveResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.AppSchemasPipelineGetDetailed.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}