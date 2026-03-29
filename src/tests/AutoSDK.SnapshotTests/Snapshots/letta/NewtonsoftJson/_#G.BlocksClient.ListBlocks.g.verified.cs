//HintName: G.BlocksClient.ListBlocks.g.cs

#nullable enable

namespace G
{
    public partial class BlocksClient
    {
        partial void PrepareListBlocksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? label,
            ref bool? templatesOnly,
            ref string? name,
            ref string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            ref string? projectId,
            global::System.Collections.Generic.IList<string>? tags,
            ref bool? matchAllTags,
            int? limit,
            ref string? before,
            ref string? after,
            ref global::G.ListBlocksOrder? order,
            ref string? orderBy,
            ref string? labelSearch,
            ref string? descriptionSearch,
            ref string? valueSearch,
            int? connectedToAgentsCountGt,
            int? connectedToAgentsCountLt,
            global::System.Collections.Generic.IList<int>? connectedToAgentsCountEq);
        partial void PrepareListBlocksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? label,
            bool? templatesOnly,
            string? name,
            string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            string? projectId,
            global::System.Collections.Generic.IList<string>? tags,
            bool? matchAllTags,
            int? limit,
            string? before,
            string? after,
            global::G.ListBlocksOrder? order,
            string? orderBy,
            string? labelSearch,
            string? descriptionSearch,
            string? valueSearch,
            int? connectedToAgentsCountGt,
            int? connectedToAgentsCountLt,
            global::System.Collections.Generic.IList<int>? connectedToAgentsCountEq);
        partial void ProcessListBlocksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListBlocksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Blocks
        /// </summary>
        /// <param name="label">
        /// Label to include (alphanumeric, hyphens, underscores, forward slashes)
        /// </param>
        /// <param name="templatesOnly">
        /// Whether to include only templates<br/>
        /// Default Value: false
        /// </param>
        /// <param name="name">
        /// Name filter (alphanumeric, spaces, hyphens, underscores)
        /// </param>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="identifierKeys">
        /// Search agents by identifier keys
        /// </param>
        /// <param name="projectId">
        /// Search blocks by project id
        /// </param>
        /// <param name="tags">
        /// List of tags to filter blocks by
        /// </param>
        /// <param name="matchAllTags">
        /// If True, only returns blocks that match ALL given tags. Otherwise, return blocks that have ANY of the passed-in tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Number of blocks to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="before">
        /// Block ID cursor for pagination. Returns blocks that come before this block ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Block ID cursor for pagination. Returns blocks that come after this block ID in the specified sort order
        /// </param>
        /// <param name="order">
        /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="labelSearch">
        /// Search blocks by label. If provided, returns blocks whose label matches the search query. This is a full-text search on block labels.
        /// </param>
        /// <param name="descriptionSearch">
        /// Search blocks by description. If provided, returns blocks whose description matches the search query. This is a full-text search on block descriptions.
        /// </param>
        /// <param name="valueSearch">
        /// Search blocks by value. If provided, returns blocks whose value matches the search query. This is a full-text search on block values.
        /// </param>
        /// <param name="connectedToAgentsCountGt">
        /// Filter blocks by the number of connected agents. If provided, returns blocks that have more than this number of connected agents.
        /// </param>
        /// <param name="connectedToAgentsCountLt">
        /// Filter blocks by the number of connected agents. If provided, returns blocks that have less than this number of connected agents.
        /// </param>
        /// <param name="connectedToAgentsCountEq">
        /// Filter blocks by the exact number of connected agents. If provided, returns blocks that have exactly this number of connected agents.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.BlockResponse>> ListBlocksAsync(
            string? label = default,
            bool? templatesOnly = default,
            string? name = default,
            string? identityId = default,
            global::System.Collections.Generic.IList<string>? identifierKeys = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? matchAllTags = default,
            int? limit = default,
            string? before = default,
            string? after = default,
            global::G.ListBlocksOrder? order = default,
            string? orderBy = default,
            string? labelSearch = default,
            string? descriptionSearch = default,
            string? valueSearch = default,
            int? connectedToAgentsCountGt = default,
            int? connectedToAgentsCountLt = default,
            global::System.Collections.Generic.IList<int>? connectedToAgentsCountEq = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListBlocksArguments(
                httpClient: HttpClient,
                label: ref label,
                templatesOnly: ref templatesOnly,
                name: ref name,
                identityId: ref identityId,
                identifierKeys: identifierKeys,
                projectId: ref projectId,
                tags: tags,
                matchAllTags: ref matchAllTags,
                limit: limit,
                before: ref before,
                after: ref after,
                order: ref order,
                orderBy: ref orderBy,
                labelSearch: ref labelSearch,
                descriptionSearch: ref descriptionSearch,
                valueSearch: ref valueSearch,
                connectedToAgentsCountGt: connectedToAgentsCountGt,
                connectedToAgentsCountLt: connectedToAgentsCountLt,
                connectedToAgentsCountEq: connectedToAgentsCountEq);

            var orderValue = order switch
            {
                global::G.ListBlocksOrder.Asc => "asc",
                global::G.ListBlocksOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/blocks/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("label", label)
                .AddOptionalParameter("templates_only", templatesOnly?.ToString().ToLowerInvariant())
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("identity_id", identityId)
                .AddOptionalParameter("identifier_keys", identifierKeys?.ToString())
                .AddOptionalParameter("project_id", projectId)
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("match_all_tags", matchAllTags?.ToString().ToLowerInvariant())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("order_by", orderBy)
                .AddOptionalParameter("label_search", labelSearch)
                .AddOptionalParameter("description_search", descriptionSearch)
                .AddOptionalParameter("value_search", valueSearch)
                .AddOptionalParameter("connected_to_agents_count_gt", connectedToAgentsCountGt?.ToString())
                .AddOptionalParameter("connected_to_agents_count_lt", connectedToAgentsCountLt?.ToString())
                .AddOptionalParameter("connected_to_agents_count_eq", connectedToAgentsCountEq?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListBlocksRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                label: label,
                templatesOnly: templatesOnly,
                name: name,
                identityId: identityId,
                identifierKeys: identifierKeys,
                projectId: projectId,
                tags: tags,
                matchAllTags: matchAllTags,
                limit: limit,
                before: before,
                after: after,
                order: order,
                orderBy: orderBy,
                labelSearch: labelSearch,
                descriptionSearch: descriptionSearch,
                valueSearch: valueSearch,
                connectedToAgentsCountGt: connectedToAgentsCountGt,
                connectedToAgentsCountLt: connectedToAgentsCountLt,
                connectedToAgentsCountEq: connectedToAgentsCountEq);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListBlocksResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessListBlocksResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.BlockResponse>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.BlockResponse>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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
    }
}