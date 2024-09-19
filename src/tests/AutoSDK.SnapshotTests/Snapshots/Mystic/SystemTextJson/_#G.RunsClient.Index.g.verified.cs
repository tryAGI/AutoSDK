//HintName: G.RunsClient.Index.g.cs

#nullable enable

namespace G
{
    public partial class RunsClient
    {
        partial void PrepareIndexArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? pipelineId,
            ref bool? includePointers,
            ref int? skip,
            ref int? limit,
            ref string? orderBy);
        partial void PrepareIndexRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? pipelineId,
            bool? includePointers,
            int? skip,
            int? limit,
            string? orderBy);
        partial void ProcessIndexResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIndexResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of runs that satisfy query parameters.<br/>
        /// Supported query params:<br/>
        /// - `pipeline_id`: filter by a given pipeline ID<br/>
        ///     - e.g. `pipeline_id=pipeline_some-random-string`<br/>
        /// - `order_by`: order by a given field<br/>
        ///     - supported fields are `created_at`, `state`, `compute_time_ms`; default<br/>
        ///         is `created_at:desc`<br/>
        ///     - e.g. `order_by=compute_time_ms:desc`<br/>
        /// - include_pointers: include any pointers that point to the pipelines the runs were<br/>
        /// executed against
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="includePointers">
        /// Default Value: false
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedRunGet> IndexAsync(
            string? pipelineId = default,
            bool? includePointers = false,
            int? skip = 0,
            int? limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareIndexArguments(
                httpClient: _httpClient,
                pipelineId: ref pipelineId,
                includePointers: ref includePointers,
                skip: ref skip,
                limit: ref limit,
                orderBy: ref orderBy);

            var __pathBuilder = new PathBuilder(
                path: "/v4/runs",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                .AddOptionalParameter("include_pointers", includePointers?.ToString()) 
                .AddOptionalParameter("skip", skip?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order_by", orderBy) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIndexRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pipelineId: pipelineId,
                includePointers: includePointers,
                skip: skip,
                limit: limit,
                orderBy: orderBy);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessIndexResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIndexResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.PaginatedRunGet?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}