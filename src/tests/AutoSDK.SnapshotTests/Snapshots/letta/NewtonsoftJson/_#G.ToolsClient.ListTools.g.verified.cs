//HintName: G.ToolsClient.ListTools.g.cs

#nullable enable

namespace G
{
    public partial class ToolsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListToolsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ListToolsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListToolsSecurityRequirement0,
            };
        partial void PrepareListToolsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? before,
            ref string? after,
            int? limit,
            ref global::G.ListToolsOrder? order,
            ref string? orderBy,
            ref string? name,
            global::System.Collections.Generic.IList<string>? names,
            global::System.Collections.Generic.IList<string>? toolIds,
            ref string? search,
            global::System.Collections.Generic.IList<string>? toolTypes,
            global::System.Collections.Generic.IList<string>? excludeToolTypes,
            bool? returnOnlyLettaTools);
        partial void PrepareListToolsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? before,
            string? after,
            int? limit,
            global::G.ListToolsOrder? order,
            string? orderBy,
            string? name,
            global::System.Collections.Generic.IList<string>? names,
            global::System.Collections.Generic.IList<string>? toolIds,
            string? search,
            global::System.Collections.Generic.IList<string>? toolTypes,
            global::System.Collections.Generic.IList<string>? excludeToolTypes,
            bool? returnOnlyLettaTools);
        partial void ProcessListToolsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListToolsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Tools<br/>
        /// Get a list of all tools available to agents.
        /// </summary>
        /// <param name="before">
        /// Tool ID cursor for pagination. Returns tools that come before this tool ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Tool ID cursor for pagination. Returns tools that come after this tool ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of tools to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for tools by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="name">
        /// Filter by single tool name
        /// </param>
        /// <param name="names">
        /// Filter by specific tool names
        /// </param>
        /// <param name="toolIds">
        /// Filter by specific tool IDs - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="search">
        /// Search tool names (case-insensitive partial match)
        /// </param>
        /// <param name="toolTypes">
        /// Filter by tool type(s) - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="excludeToolTypes">
        /// Tool type(s) to exclude - accepts repeated params or comma-separated values
        /// </param>
        /// <param name="returnOnlyLettaTools">
        /// Return only tools with tool_type starting with 'letta_'<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tool>> ListToolsAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListToolsOrder? order = default,
            string? orderBy = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? names = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? toolTypes = default,
            global::System.Collections.Generic.IList<string>? excludeToolTypes = default,
            bool? returnOnlyLettaTools = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListToolsArguments(
                httpClient: HttpClient,
                before: ref before,
                after: ref after,
                limit: limit,
                order: ref order,
                orderBy: ref orderBy,
                name: ref name,
                names: names,
                toolIds: toolIds,
                search: ref search,
                toolTypes: toolTypes,
                excludeToolTypes: excludeToolTypes,
                returnOnlyLettaTools: returnOnlyLettaTools);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListToolsSecurityRequirements,
                operationName: "ListToolsAsync");

            var orderValue = order switch
            {
                global::G.ListToolsOrder.Asc => "asc",
                global::G.ListToolsOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/tools/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("order_by", orderBy)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("names", names?.ToString())
                .AddOptionalParameter("tool_ids", toolIds?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("tool_types", toolTypes?.ToString())
                .AddOptionalParameter("exclude_tool_types", excludeToolTypes?.ToString())
                .AddOptionalParameter("return_only_letta_tools", returnOnlyLettaTools?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareListToolsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                before: before,
                after: after,
                limit: limit,
                order: order,
                orderBy: orderBy,
                name: name,
                names: names,
                toolIds: toolIds,
                search: search,
                toolTypes: toolTypes,
                excludeToolTypes: excludeToolTypes,
                returnOnlyLettaTools: returnOnlyLettaTools);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListToolsResponse(
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
                ProcessListToolsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Tool>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Tool>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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