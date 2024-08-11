//HintName: G.DependabotClient.DependabotListAlertsForEnterprise.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotListAlertsForEnterpriseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterprise,
            ref string? state,
            ref string? severity,
            ref string? ecosystem,
            ref string? package,
            ref global::G.DependabotListAlertsForEnterpriseScope? scope,
            ref global::G.DependabotListAlertsForEnterpriseSort? sort,
            ref global::G.DependabotListAlertsForEnterpriseDirection? direction,
            ref string? before,
            ref string? after,
            ref int first,
            ref int last,
            ref int perPage);
        partial void PrepareDependabotListAlertsForEnterpriseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterprise,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            global::G.DependabotListAlertsForEnterpriseScope? scope,
            global::G.DependabotListAlertsForEnterpriseSort? sort,
            global::G.DependabotListAlertsForEnterpriseDirection? direction,
            string? before,
            string? after,
            int first,
            int last,
            int perPage);
        partial void ProcessDependabotListAlertsForEnterpriseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotListAlertsForEnterpriseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Dependabot alerts for an enterprise<br/>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.<br/>
        /// The authenticated user must be a member of the enterprise to use this endpoint.<br/>
        /// Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="scope"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="first">
        /// Default Value: 30
        /// </param>
        /// <param name="last"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>> DependabotListAlertsForEnterpriseAsync(
            string enterprise,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            global::G.DependabotListAlertsForEnterpriseScope? scope,
            global::G.DependabotListAlertsForEnterpriseSort? sort,
            global::G.DependabotListAlertsForEnterpriseDirection? direction,
            string? before,
            string? after,
            int first,
            int last,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDependabotListAlertsForEnterpriseArguments(
                httpClient: _httpClient,
                enterprise: ref enterprise,
                state: ref state,
                severity: ref severity,
                ecosystem: ref ecosystem,
                package: ref package,
                scope: ref scope,
                sort: ref sort,
                direction: ref direction,
                before: ref before,
                after: ref after,
                first: ref first,
                last: ref last,
                perPage: ref perPage);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/enterprises/{enterprise}/dependabot/alerts?state={state}&severity={severity}&ecosystem={ecosystem}&package={package}&scope={scope}&sort={sort}&direction={direction}&before={before}&after={after}&first={first}&last={last}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependabotListAlertsForEnterpriseRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                enterprise: enterprise,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                scope: scope,
                sort: sort,
                direction: direction,
                before: before,
                after: after,
                first: first,
                last: last,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDependabotListAlertsForEnterpriseResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDependabotListAlertsForEnterpriseResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}