//HintName: G.OrgsClient.OrgsEnableOrDisableSecurityProductOnAllOrgRepos.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsEnableOrDisableSecurityProductOnAllOrgReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            ref global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest request);
        partial void PrepareOrgsEnableOrDisableSecurityProductOnAllOrgReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest request);
        partial void ProcessOrgsEnableOrDisableSecurityProductOnAllOrgReposResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Enable or disable a security feature for an organization<br/>
        /// Enables or disables the specified security feature for all eligible repositories in an organization. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// The authenticated user must be an organization owner or be member of a team with the security manager role to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="securityProduct"></param>
        /// <param name="enablement"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsEnableOrDisableSecurityProductOnAllOrgReposArguments(
                httpClient: _httpClient,
                org: ref org,
                securityProduct: ref securityProduct,
                enablement: ref enablement,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/{securityProduct}/{enablement}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsEnableOrDisableSecurityProductOnAllOrgReposRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                securityProduct: securityProduct,
                enablement: enablement,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsEnableOrDisableSecurityProductOnAllOrgReposResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Enable or disable a security feature for an organization<br/>
        /// Enables or disables the specified security feature for all eligible repositories in an organization. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// The authenticated user must be an organization owner or be member of a team with the security manager role to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="securityProduct"></param>
        /// <param name="enablement"></param>
        /// <param name="querySuite">
        /// CodeQL query suite to be used. If you specify the `query_suite` parameter, the default setup will be configured with this query suite only on all repositories that didn't have default setup already configured. It will not change the query suite on repositories that already have default setup configured.<br/>
        /// If you don't specify any `query_suite` in your request, the preferred query suite of the organization will be applied.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite? querySuite = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest
            {
                QuerySuite = querySuite,
            };

            await OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
                org: org,
                securityProduct: securityProduct,
                enablement: enablement,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}