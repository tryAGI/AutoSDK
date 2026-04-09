//HintName: G.ToolsClient.CountTools.g.cs

#nullable enable

namespace G
{
    public partial class ToolsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CountToolsSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_CountToolsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CountToolsSecurityRequirement0,
            };
        partial void PrepareCountToolsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? name,
            global::System.Collections.Generic.IList<string>? names,
            global::System.Collections.Generic.IList<string>? toolIds,
            ref string? search,
            global::System.Collections.Generic.IList<string>? toolTypes,
            global::System.Collections.Generic.IList<string>? excludeToolTypes,
            bool? returnOnlyLettaTools,
            bool? excludeLettaTools);
        partial void PrepareCountToolsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? name,
            global::System.Collections.Generic.IList<string>? names,
            global::System.Collections.Generic.IList<string>? toolIds,
            string? search,
            global::System.Collections.Generic.IList<string>? toolTypes,
            global::System.Collections.Generic.IList<string>? excludeToolTypes,
            bool? returnOnlyLettaTools,
            bool? excludeLettaTools);
        partial void ProcessCountToolsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCountToolsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Count Tools<br/>
        /// Get a count of all tools available to agents belonging to the org of the user.
        /// </summary>
        /// <param name="name"></param>
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
        /// Count only tools with tool_type starting with 'letta_'<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeLettaTools">
        /// Exclude built-in Letta tools from the count<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<int> CountToolsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? names = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? toolTypes = default,
            global::System.Collections.Generic.IList<string>? excludeToolTypes = default,
            bool? returnOnlyLettaTools = default,
            bool? excludeLettaTools = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCountToolsArguments(
                httpClient: HttpClient,
                name: ref name,
                names: names,
                toolIds: toolIds,
                search: ref search,
                toolTypes: toolTypes,
                excludeToolTypes: excludeToolTypes,
                returnOnlyLettaTools: returnOnlyLettaTools,
                excludeLettaTools: excludeLettaTools);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CountToolsSecurityRequirements,
                operationName: "CountToolsAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/tools/count",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("names", names?.ToString())
                .AddOptionalParameter("tool_ids", toolIds?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("tool_types", toolTypes?.ToString())
                .AddOptionalParameter("exclude_tool_types", excludeToolTypes?.ToString())
                .AddOptionalParameter("return_only_letta_tools", returnOnlyLettaTools?.ToString().ToLowerInvariant())
                .AddOptionalParameter("exclude_letta_tools", excludeLettaTools?.ToString().ToLowerInvariant()) 
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
            PrepareCountToolsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                names: names,
                toolIds: toolIds,
                search: search,
                toolTypes: toolTypes,
                excludeToolTypes: excludeToolTypes,
                returnOnlyLettaTools: returnOnlyLettaTools,
                excludeLettaTools: excludeLettaTools);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCountToolsResponse(
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
                ProcessCountToolsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize<int?>(__content, JsonSerializerOptions) ??
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
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<int?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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