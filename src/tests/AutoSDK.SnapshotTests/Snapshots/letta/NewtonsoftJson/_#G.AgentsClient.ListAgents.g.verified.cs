//HintName: G.AgentsClient.ListAgents.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class AgentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListAgentsSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ListAgentsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListAgentsSecurityRequirement0,
            };
        partial void PrepareListAgentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? name,
            global::System.Collections.Generic.IList<string>? tags,
            ref bool? matchAllTags,
            ref string? before,
            ref string? after,
            int? limit,
            ref string? queryText,
            ref string? projectId,
            ref string? templateId,
            ref string? baseTemplateId,
            ref string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            global::System.Collections.Generic.IList<string>? includeRelationships,
            global::System.Collections.Generic.IList<global::G.ListAgentsIncludeItem>? include,
            ref global::G.ListAgentsOrder? order,
            ref global::G.ListAgentsOrderBy? orderBy,
            ref bool? ascending,
            ref string? sortBy,
            global::G.StopReasonType? lastStopReason);
        partial void PrepareListAgentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            bool? matchAllTags,
            string? before,
            string? after,
            int? limit,
            string? queryText,
            string? projectId,
            string? templateId,
            string? baseTemplateId,
            string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            global::System.Collections.Generic.IList<string>? includeRelationships,
            global::System.Collections.Generic.IList<global::G.ListAgentsIncludeItem>? include,
            global::G.ListAgentsOrder? order,
            global::G.ListAgentsOrderBy? orderBy,
            bool? ascending,
            string? sortBy,
            global::G.StopReasonType? lastStopReason);
        partial void ProcessListAgentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListAgentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Agents<br/>
        /// Get a list of all agents.
        /// </summary>
        /// <param name="name">
        /// Name of the agent
        /// </param>
        /// <param name="tags">
        /// List of tags to filter agents by
        /// </param>
        /// <param name="matchAllTags">
        /// If True, only returns agents that match ALL given tags. Otherwise, return agents that have ANY of the passed-in tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="before">
        /// Cursor for pagination
        /// </param>
        /// <param name="after">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Limit for pagination<br/>
        /// Default Value: 50
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
        /// <param name="includeRelationships">
        /// Specify which relational fields (e.g., 'tools', 'sources', 'memory') to include in the response. If not provided, all relationships are loaded by default. Using this can optimize performance by reducing unnecessary joins.This is a legacy parameter, and no longer supported after 1.0.0 SDK versions.
        /// </param>
        /// <param name="include">
        /// Specify which relational fields to include in the response. No relationships are included by default.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="order">
        /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ascending">
        /// Whether to sort agents oldest to newest (True) or newest to oldest (False, default)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by. Options: 'created_at' (default), 'last_run_completion'<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="lastStopReason">
        /// Filter agents by their last stop reason.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AgentState>> ListAgentsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? matchAllTags = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            string? queryText = default,
            string? projectId = default,
            string? templateId = default,
            string? baseTemplateId = default,
            string? identityId = default,
            global::System.Collections.Generic.IList<string>? identifierKeys = default,
            global::System.Collections.Generic.IList<string>? includeRelationships = default,
            global::System.Collections.Generic.IList<global::G.ListAgentsIncludeItem>? include = default,
            global::G.ListAgentsOrder? order = default,
            global::G.ListAgentsOrderBy? orderBy = default,
            bool? ascending = default,
            string? sortBy = default,
            global::G.StopReasonType? lastStopReason = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListAgentsArguments(
                httpClient: HttpClient,
                name: ref name,
                tags: tags,
                matchAllTags: ref matchAllTags,
                before: ref before,
                after: ref after,
                limit: limit,
                queryText: ref queryText,
                projectId: ref projectId,
                templateId: ref templateId,
                baseTemplateId: ref baseTemplateId,
                identityId: ref identityId,
                identifierKeys: identifierKeys,
                includeRelationships: includeRelationships,
                include: include,
                order: ref order,
                orderBy: ref orderBy,
                ascending: ref ascending,
                sortBy: ref sortBy,
                lastStopReason: lastStopReason);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListAgentsSecurityRequirements,
                operationName: "ListAgentsAsync");

            var orderValue = order switch
            {
                global::G.ListAgentsOrder.Asc => "asc",
                global::G.ListAgentsOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderByValue = orderBy switch
            {
                global::G.ListAgentsOrderBy.CreatedAt => "created_at",
                global::G.ListAgentsOrderBy.UpdatedAt => "updated_at",
                global::G.ListAgentsOrderBy.LastRunCompletion => "last_run_completion",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/agents/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("match_all_tags", matchAllTags?.ToString().ToLowerInvariant())
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("query_text", queryText)
                .AddOptionalParameter("project_id", projectId)
                .AddOptionalParameter("template_id", templateId)
                .AddOptionalParameter("base_template_id", baseTemplateId)
                .AddOptionalParameter("identity_id", identityId)
                .AddOptionalParameter("identifier_keys", identifierKeys?.ToString())
                .AddOptionalParameter("include_relationships", includeRelationships?.ToString())
                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("order_by", orderBy?.ToValueString())
                .AddOptionalParameter("ascending", ascending?.ToString().ToLowerInvariant())
                .AddOptionalParameter("sort_by", sortBy)
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
            PrepareListAgentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                tags: tags,
                matchAllTags: matchAllTags,
                before: before,
                after: after,
                limit: limit,
                queryText: queryText,
                projectId: projectId,
                templateId: templateId,
                baseTemplateId: baseTemplateId,
                identityId: identityId,
                identifierKeys: identifierKeys,
                includeRelationships: includeRelationships,
                include: include,
                order: order,
                orderBy: orderBy,
                ascending: ascending,
                sortBy: sortBy,
                lastStopReason: lastStopReason);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListAgentsResponse(
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
                ProcessListAgentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.AgentState>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.AgentState>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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