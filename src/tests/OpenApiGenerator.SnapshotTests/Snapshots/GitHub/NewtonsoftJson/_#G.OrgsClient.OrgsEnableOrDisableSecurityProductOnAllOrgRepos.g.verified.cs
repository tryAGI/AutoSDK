//HintName: G.OrgsClient.OrgsEnableOrDisableSecurityProductOnAllOrgRepos.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Enable or disable a security feature for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="securityProduct"></param>
        /// <param name="enablement"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            object request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            var securityProductValue = securityProduct switch
            {
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependencyGraph => "dependency_graph",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotAlerts => "dependabot_alerts",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.DependabotSecurityUpdates => "dependabot_security_updates",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.AdvancedSecurity => "advanced_security",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.CodeScanningDefaultSetup => "code_scanning_default_setup",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanning => "secret_scanning",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct.SecretScanningPushProtection => "secret_scanning_push_protection",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var enablementValue = enablement switch
            {
                OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.EnableAll => "enable_all",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.DisableAll => "disable_all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/{securityProductValue}/{enablementValue}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Enable or disable a security feature for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="securityProduct"></param>
        /// <param name="enablement"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new object
            {
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