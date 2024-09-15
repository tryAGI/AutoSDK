//HintName: G.IOrgsClient.OrgsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
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
        global::System.Threading.Tasks.Task<global::G.OrganizationFull> OrgsGetAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}