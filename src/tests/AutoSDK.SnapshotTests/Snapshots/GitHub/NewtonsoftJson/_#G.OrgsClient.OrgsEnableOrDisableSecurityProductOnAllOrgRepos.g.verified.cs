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
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** The ability to enable or disable a security feature for all eligible repositories in an organization is deprecated. Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead. For more information, see the [changelog](https://github.blog/changelog/2024-07-22-deprecation-of-api-endpoint-to-enable-or-disable-a-security-feature-for-an-organization/).<br/>
        /// Enables or disables the specified security feature for all eligible repositories in an organization. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// The authenticated user must be an organization owner or be member of a team with the security manager role to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org`, `write:org`, or `repo` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="securityProduct"></param>
        /// <param name="enablement"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsEnableOrDisableSecurityProductOnAllOrgReposArguments(
                httpClient: HttpClient,
                org: ref org,
                securityProduct: ref securityProduct,
                enablement: ref enablement,
                request: request);

            var securityProductValue = securityProduct switch
            {
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependencyGraph => "dependency_graph",
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotAlerts => "dependabot_alerts",
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotSecurityUpdates => "dependabot_security_updates",
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.AdvancedSecurity => "advanced_security",
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.CodeScanningDefaultSetup => "code_scanning_default_setup",
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanning => "secret_scanning",
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanningPushProtection => "secret_scanning_push_protection",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var enablementValue = enablement switch
            {
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.EnableAll => "enable_all",
                global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.DisableAll => "disable_all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/{securityProductValue}/{enablementValue}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsEnableOrDisableSecurityProductOnAllOrgReposRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                securityProduct: securityProduct,
                enablement: enablement,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsEnableOrDisableSecurityProductOnAllOrgReposResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
        }

        /// <summary>
        /// Enable or disable a security feature for an organization<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** The ability to enable or disable a security feature for all eligible repositories in an organization is deprecated. Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead. For more information, see the [changelog](https://github.blog/changelog/2024-07-22-deprecation-of-api-endpoint-to-enable-or-disable-a-security-feature-for-an-organization/).<br/>
        /// Enables or disables the specified security feature for all eligible repositories in an organization. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// The authenticated user must be an organization owner or be member of a team with the security manager role to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org`, `write:org`, or `repo` scopes to use this endpoint.
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
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite? querySuite = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest
            {
                QuerySuite = querySuite,
            };

            await OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
                org: org,
                securityProduct: securityProduct,
                enablement: enablement,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}