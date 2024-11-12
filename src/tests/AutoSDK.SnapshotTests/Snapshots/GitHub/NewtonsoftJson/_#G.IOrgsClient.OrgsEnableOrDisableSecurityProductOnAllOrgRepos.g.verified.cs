//HintName: G.IOrgsClient.OrgsEnableOrDisableSecurityProductOnAllOrgRepos.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
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
        global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite? querySuite = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}