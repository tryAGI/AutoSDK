//HintName: G.AgentsClient.CountAgents.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CountAgentsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CountAgentsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CountAgentsSecurityRequirement0,
            };
        partial void PrepareCountAgentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? name,
            global::System.Collections.Generic.IList<string>? tags,
            ref bool? matchAllTags,
            ref string? queryText,
            ref string? projectId,
            ref string? templateId,
            ref string? baseTemplateId,
            ref string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            global::G.StopReasonType? lastStopReason);
        partial void PrepareCountAgentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            bool? matchAllTags,
            string? queryText,
            string? projectId,
            string? templateId,
            string? baseTemplateId,
            string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            global::G.StopReasonType? lastStopReason);
        partial void ProcessCountAgentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCountAgentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Count Agents<br/>
        /// Get the total number of agents with optional filtering.<br/>
        /// Supports the same filters as list_agents for consistent querying.
        /// </summary>
        /// <param name="name">
        /// Name of the agent
        /// </param>
        /// <param name="tags">
        /// List of tags to filter agents by
        /// </param>
        /// <param name="matchAllTags">
        /// If True, only counts agents that match ALL given tags. Otherwise, counts agents that have ANY of the passed-in tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queryText">
        /// Search agents by name
        /// </param>
        /// <param name="projectId">
        /// Search agents by project ID - this will default to your default project on cloud
        /// </param>
        /// <param name="templateId">
        /// Search agents by template ID
        /// </param>
        /// <param name="baseTemplateId">
        /// Search agents by base template ID
        /// </param>
        /// <param name="identityId">
        /// Search agents by identity ID
        /// </param>
        /// <param name="identifierKeys">
        /// Search agents by identifier keys
        /// </param>
        /// <param name="lastStopReason">
        /// Filter agents by their last stop reason.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<int> CountAgentsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? matchAllTags = default,
            string? queryText = default,
            string? projectId = default,
            string? templateId = default,
            string? baseTemplateId = default,
            string? identityId = default,
            global::System.Collections.Generic.IList<string>? identifierKeys = default,
            global::G.StopReasonType? lastStopReason = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCountAgentsArguments(
                httpClient: HttpClient,
                name: ref name,
                tags: tags,
                matchAllTags: ref matchAllTags,
                queryText: ref queryText,
                projectId: ref projectId,
                templateId: ref templateId,
                baseTemplateId: ref baseTemplateId,
                identityId: ref identityId,
                identifierKeys: identifierKeys,
                lastStopReason: lastStopReason);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CountAgentsSecurityRequirements,
                operationName: "CountAgentsAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/agents/count",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("match_all_tags", matchAllTags?.ToString().ToLowerInvariant())
                .AddOptionalParameter("query_text", queryText)
                .AddOptionalParameter("project_id", projectId)
                .AddOptionalParameter("template_id", templateId)
                .AddOptionalParameter("base_template_id", baseTemplateId)
                .AddOptionalParameter("identity_id", identityId)
                .AddOptionalParameter("identifier_keys", identifierKeys?.ToString())
                .AddOptionalParameter("last_stop_reason", lastStopReason?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCountAgentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                tags: tags,
                matchAllTags: matchAllTags,
                queryText: queryText,
                projectId: projectId,
                templateId: templateId,
                baseTemplateId: baseTemplateId,
                identityId: identityId,
                identifierKeys: identifierKeys,
                lastStopReason: lastStopReason);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCountAgentsResponse(
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
                ProcessCountAgentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<int?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<int?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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