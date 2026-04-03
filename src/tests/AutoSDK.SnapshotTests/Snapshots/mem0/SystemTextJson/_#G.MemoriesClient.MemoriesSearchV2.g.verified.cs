//HintName: G.MemoriesClient.MemoriesSearchV2.g.cs

#nullable enable

namespace G
{
    public partial class MemoriesClient
    {
        partial void PrepareMemoriesSearchV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.MemorySearchInputV2 request);
        partial void PrepareMemoriesSearchV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.MemorySearchInputV2 request);
        partial void ProcessMemoriesSearchV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoriesSearchV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search memories based on a query and filters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesSearchV2ResponseItem>> MemoriesSearchV2Async(

            global::G.MemorySearchInputV2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMemoriesSearchV2Arguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/memories/search/",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMemoriesSearchV2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMemoriesSearchV2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessMemoriesSearchV2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.MemoriesSearchV2ResponseItem>?>(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.MemoriesSearchV2ResponseItem>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Search memories based on a query and filters.
        /// </summary>
        /// <param name="query">
        /// The query to search for in the memory.
        /// </param>
        /// <param name="version">
        /// The version of the memory to use. This should always be v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="filters">
        /// A dictionary of filters to apply to the search. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at, categories, keywords. Supports logical operators (AND, OR) and comparison operators (in, gte, lte, gt, lt, ne, contains, icontains). For categories field, use 'contains' for partial matching (e.g., {"categories": {"contains": "finance"}}) or 'in' for exact matching (e.g., {"categories": {"in": ["personal_information"]}}).
        /// </param>
        /// <param name="topK">
        /// The number of top results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="fields">
        /// A list of field names to include in the response. If not provided, all fields will be returned.
        /// </param>
        /// <param name="rerank">
        /// Whether to rerank the memories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keywordSearch">
        /// Whether to search for memories based on keywords.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filterMemories">
        /// Whether to filter the memories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="threshold">
        /// The minimum similarity threshold for returned results.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with the memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with the memory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesSearchV2ResponseItem>> MemoriesSearchV2Async(
            string query,
            global::G.MemorySearchInputV2Filters filters,
            string? version = default,
            int? topK = default,
            global::System.Collections.Generic.IList<string>? fields = default,
            bool? rerank = default,
            bool? keywordSearch = default,
            bool? filterMemories = default,
            double? threshold = default,
            string? orgId = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.MemorySearchInputV2
            {
                Query = query,
                Version = version,
                Filters = filters,
                TopK = topK,
                Fields = fields,
                Rerank = rerank,
                KeywordSearch = keywordSearch,
                FilterMemories = filterMemories,
                Threshold = threshold,
                OrgId = orgId,
                ProjectId = projectId,
            };

            return await MemoriesSearchV2Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}