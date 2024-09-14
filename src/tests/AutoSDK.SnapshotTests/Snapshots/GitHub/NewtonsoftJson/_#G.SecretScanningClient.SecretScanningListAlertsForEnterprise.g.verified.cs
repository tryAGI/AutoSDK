//HintName: G.SecretScanningClient.SecretScanningListAlertsForEnterprise.g.cs

#nullable enable

namespace G
{
    public partial class SecretScanningClient
    {
        partial void PrepareSecretScanningListAlertsForEnterpriseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterprise,
            ref global::G.SecretScanningListAlertsForEnterpriseState? state,
            ref string? secretType,
            ref string? resolution,
            ref global::G.SecretScanningListAlertsForEnterpriseSort? sort,
            ref global::G.SecretScanningListAlertsForEnterpriseDirection? direction,
            ref int perPage,
            ref string? before,
            ref string? after,
            ref string? validity);
        partial void PrepareSecretScanningListAlertsForEnterpriseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterprise,
            global::G.SecretScanningListAlertsForEnterpriseState? state,
            string? secretType,
            string? resolution,
            global::G.SecretScanningListAlertsForEnterpriseSort? sort,
            global::G.SecretScanningListAlertsForEnterpriseDirection? direction,
            int perPage,
            string? before,
            string? after,
            string? validity);
        partial void ProcessSecretScanningListAlertsForEnterpriseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecretScanningListAlertsForEnterpriseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List secret scanning alerts for an enterprise<br/>
        /// Lists secret scanning alerts for eligible repositories in an enterprise, from newest to oldest.<br/>
        /// Alerts are only returned for organizations in the enterprise for which the authenticated user is an organization owner or a [security manager](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).<br/>
        /// The authenticated user must be a member of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationSecretScanningAlert>> SecretScanningListAlertsForEnterpriseAsync(
            string enterprise,
            global::G.SecretScanningListAlertsForEnterpriseState? state = default,
            string? secretType = default,
            string? resolution = default,
            global::G.SecretScanningListAlertsForEnterpriseSort? sort = global::G.SecretScanningListAlertsForEnterpriseSort.Created,
            global::G.SecretScanningListAlertsForEnterpriseDirection? direction = global::G.SecretScanningListAlertsForEnterpriseDirection.Desc,
            int perPage = 30,
            string? before = default,
            string? after = default,
            string? validity = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecretScanningListAlertsForEnterpriseArguments(
                httpClient: _httpClient,
                enterprise: ref enterprise,
                state: ref state,
                secretType: ref secretType,
                resolution: ref resolution,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                validity: ref validity);

            var stateValue = state switch
            {
                global::G.SecretScanningListAlertsForEnterpriseState.Open => "open",
                global::G.SecretScanningListAlertsForEnterpriseState.Resolved => "resolved",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.SecretScanningListAlertsForEnterpriseSort.Created => "created",
                global::G.SecretScanningListAlertsForEnterpriseSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.SecretScanningListAlertsForEnterpriseDirection.Asc => "asc",
                global::G.SecretScanningListAlertsForEnterpriseDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/enterprises/{enterprise}/secret-scanning/alerts?state={(global::System.Uri.EscapeDataString(stateValue?.ToString() ?? string.Empty))}&secret_type={secretType}&resolution={resolution}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(directionValue?.ToString() ?? string.Empty))}&per_page={perPage}&before={before}&after={after}&validity={validity}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecretScanningListAlertsForEnterpriseRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                enterprise: enterprise,
                state: state,
                secretType: secretType,
                resolution: resolution,
                sort: sort,
                direction: direction,
                perPage: perPage,
                before: before,
                after: after,
                validity: validity);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecretScanningListAlertsForEnterpriseResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecretScanningListAlertsForEnterpriseResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.OrganizationSecretScanningAlert>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}