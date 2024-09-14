//HintName: G.OrgsClient.OrgsGet.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org);
        partial void PrepareOrgsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org);
        partial void ProcessOrgsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get an organization<br/>
        /// Gets information about an organization.<br/>
        /// When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).<br/>
        /// To see the full details about an organization, the authenticated user must be an organization owner.<br/>
        /// The values returned by this endpoint are set by the "Update an organization" endpoint. If your organization set a default security configuration (beta), the following values retrieved from the "Update an organization" endpoint have been overwritten by that configuration:<br/>
        /// - advanced_security_enabled_for_new_repositories<br/>
        /// - dependabot_alerts_enabled_for_new_repositories<br/>
        /// - dependabot_security_updates_enabled_for_new_repositories<br/>
        /// - dependency_graph_enabled_for_new_repositories<br/>
        /// - secret_scanning_enabled_for_new_repositories<br/>
        /// - secret_scanning_push_protection_enabled_for_new_repositories<br/>
        /// For more information on security configurations, see "[Enabling security features at scale](https://docs.github.com/code-security/securing-your-organization/introduction-to-securing-your-organization-at-scale/about-enabling-security-features-at-scale)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to see the full details about an organization.<br/>
        /// To see information about an organization's GitHub plan, GitHub Apps need the `Organization plan` permission.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrganizationFull> OrgsGetAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOrgsGetArguments(
                httpClient: _httpClient,
                org: ref org);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsGetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.OrganizationFull?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}