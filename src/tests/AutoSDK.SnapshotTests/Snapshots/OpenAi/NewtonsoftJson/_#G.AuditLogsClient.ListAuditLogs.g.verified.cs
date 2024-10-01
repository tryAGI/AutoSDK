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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListAuditLogsResponse> ListAuditLogsAsync(
            global::G.ListAuditLogsEffectiveAt? effectiveAt = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType>? eventTypes = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            global::System.Collections.Generic.IList<string>? actorEmails = default,
            global::System.Collections.Generic.IList<string>? resourceIds = default,
            int? limit = 20,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListAuditLogsArguments(
                httpClient: _httpClient,
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
                baseUri: _httpClient.BaseAddress); 
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
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListAuditLogsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                effectiveAt: effectiveAt,
                projectIds: projectIds,
                eventTypes: eventTypes,
                actorIds: actorIds,
                actorEmails: actorEmails,
                resourceIds: resourceIds,
                limit: limit,
                after: after,
                before: before);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListAuditLogsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListAuditLogsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListAuditLogsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}