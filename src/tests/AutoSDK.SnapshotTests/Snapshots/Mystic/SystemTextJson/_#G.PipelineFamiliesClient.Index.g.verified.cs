//HintName: G.PipelineFamiliesClient.Index.g.cs

#nullable enable

namespace G
{
    public partial class PipelineFamiliesClient
    {
        partial void PrepareIndexArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? userId,
            ref string? teamId,
            ref global::G.AllOf<global::G.OrderBy?>? orderBy,
            ref string? search,
            ref bool? includeAllRun,
            ref int? skip,
            ref int? limit);
        partial void PrepareIndexRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? userId,
            string? teamId,
            global::G.AllOf<global::G.OrderBy?>? orderBy,
            string? search,
            bool? includeAllRun,
            int? skip,
            int? limit);
        partial void ProcessIndexResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIndexResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Index<br/>
        /// List pipeline families.<br/>
        /// Depending on parameters this can mean all public families, or a user/team's<br/>
        /// specific families.<br/>
        /// Can also be ordered and filtered based on family name.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="orderBy">
        /// Default Value: popular
        /// </param>
        /// <param name="search"></param>
        /// <param name="includeAllRun">
        /// Default Value: false
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedPipelineFamilyGet> IndexAsync(
            string? userId = default,
            string? teamId = default,
            global::G.AllOf<global::G.OrderBy?>? orderBy = default,
            string? search = default,
            bool? includeAllRun = false,
            int? skip = 0,
            int? limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareIndexArguments(
                httpClient: _httpClient,
                userId: ref userId,
                teamId: ref teamId,
                orderBy: ref orderBy,
                search: ref search,
                includeAllRun: ref includeAllRun,
                skip: ref skip,
                limit: ref limit);

            var __pathBuilder = new PathBuilder(
                path: "/v4/pipeline-families",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("user_id", userId) 
                .AddOptionalParameter("team_id", teamId) 
                .AddOptionalParameter("order_by", orderBy?.ToString() ?? string.Empty) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("include_all_run", includeAllRun?.ToString()) 
                .AddOptionalParameter("skip", skip?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIndexRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                teamId: teamId,
                orderBy: orderBy,
                search: search,
                includeAllRun: includeAllRun,
                skip: skip,
                limit: limit);

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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.PaginatedPipelineFamilyGet?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}