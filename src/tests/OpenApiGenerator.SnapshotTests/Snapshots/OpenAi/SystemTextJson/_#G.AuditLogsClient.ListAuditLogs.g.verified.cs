//HintName: G.AuditLogsClient.ListAuditLogs.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class AuditLogsClient
    {
        partial void PrepareListAuditLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ListAuditLogsEffectiveAt effectiveAt,
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType> eventTypes,
            global::System.Collections.Generic.IList<string> actorIds,
            global::System.Collections.Generic.IList<string> actorEmails,
            global::System.Collections.Generic.IList<string> resourceIds,
            ref int limit,
            ref string after,
            ref string before);
        partial void PrepareListAuditLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ListAuditLogsEffectiveAt effectiveAt,
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType> eventTypes,
            global::System.Collections.Generic.IList<string> actorIds,
            global::System.Collections.Generic.IList<string> actorEmails,
            global::System.Collections.Generic.IList<string> resourceIds,
            int limit,
            string after,
            string before);
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
            global::G.ListAuditLogsEffectiveAt effectiveAt,
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType> eventTypes,
            global::System.Collections.Generic.IList<string> actorIds,
            global::System.Collections.Generic.IList<string> actorEmails,
            global::System.Collections.Generic.IList<string> resourceIds,
            int limit,
            string after,
            string before,
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/organization/audit_logs?effective_at={effectiveAt}&{string.Join("&", projectIds.Select(static x => $"projectIds={x}"))}&{string.Join("&", eventTypes.Select(static x => $"eventTypes={x}"))}&{string.Join("&", actorIds.Select(static x => $"actorIds={x}"))}&{string.Join("&", actorEmails.Select(static x => $"actorEmails={x}"))}&{string.Join("&", resourceIds.Select(static x => $"resourceIds={x}"))}&limit={limit}&after={after}&before={before}", global::System.UriKind.RelativeOrAbsolute));

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

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListAuditLogsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}