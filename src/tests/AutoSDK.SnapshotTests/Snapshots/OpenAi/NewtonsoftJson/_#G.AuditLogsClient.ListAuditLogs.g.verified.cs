//HintName: G.AuditLogsClient.ListAuditLogs.g.cs

#nullable enable

namespace G
{
    public partial class AuditLogsClient
    {
        partial void PrepareListAuditLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ListAuditLogsEffectiveAt? effectiveAt,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType>? eventTypes,
            global::System.Collections.Generic.IList<string>? actorIds,
            global::System.Collections.Generic.IList<string>? actorEmails,
            global::System.Collections.Generic.IList<string>? resourceIds,
            ref int? limit,
            ref string? after,
            ref string? before);
        partial void PrepareListAuditLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ListAuditLogsEffectiveAt? effectiveAt,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType>? eventTypes,
            global::System.Collections.Generic.IList<string>? actorIds,
            global::System.Collections.Generic.IList<string>? actorEmails,
            global::System.Collections.Generic.IList<string>? resourceIds,
            int? limit,
            string? after,
            string? before);
        partial void ProcessListAuditLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListAuditLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List user actions and configuration changes within this organization.
        /// </summary>
        /// <param name="effectiveAt"></param>
        /// <param name="projectIds"></param>
        /// <param name="eventTypes"></param>
        /// <param name="actorIds"></param>
        /// <param name="actorEmails"></param>
        /// <param name="resourceIds"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListAuditLogsResponse> ListAuditLogsAsync(
            global::G.ListAuditLogsEffectiveAt? effectiveAt = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType>? eventTypes = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            global::System.Collections.Generic.IList<string>? actorEmails = default,
            global::System.Collections.Generic.IList<string>? resourceIds = default,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListAuditLogsArguments(
                httpClient: HttpClient,
                effectiveAt: effectiveAt,
                projectIds: projectIds,
                eventTypes: eventTypes,
                actorIds: actorIds,
                actorEmails: actorEmails,
                resourceIds: resourceIds,
                limit: ref limit,
                after: ref after,
                before: ref before);

            var __pathBuilder = new PathBuilder(
                path: "/organization/audit_logs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("gt", effectiveAt?.Gt?.ToString()) 
                .AddOptionalParameter("gte", effectiveAt?.Gte?.ToString()) 
                .AddOptionalParameter("lt", effectiveAt?.Lt?.ToString()) 
                .AddOptionalParameter("lte", effectiveAt?.Lte?.ToString()) 
                .AddOptionalParameter("project_ids[]", projectIds, delimiter: ",", explode: true) 
                .AddOptionalParameter("actor_ids[]", actorIds, delimiter: ",", explode: true) 
                .AddOptionalParameter("actor_emails[]", actorEmails, delimiter: ",", explode: true) 
                .AddOptionalParameter("resource_ids[]", resourceIds, delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("before", before) 
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
            PrepareListAuditLogsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                effectiveAt: effectiveAt,
                projectIds: projectIds,
                eventTypes: eventTypes,
                actorIds: actorIds,
                actorEmails: actorEmails,
                resourceIds: resourceIds,
                limit: limit,
                after: after,
                before: before);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListAuditLogsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListAuditLogsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.ListAuditLogsResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                var __responseValue = await global::G.ListAuditLogsResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}