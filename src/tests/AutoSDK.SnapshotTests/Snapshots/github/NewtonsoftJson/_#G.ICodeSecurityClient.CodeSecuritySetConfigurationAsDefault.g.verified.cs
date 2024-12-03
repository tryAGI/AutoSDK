//HintName: G.ICodeSecurityClient.CodeSecuritySetConfigurationAsDefault.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Set a code security configuration as a default for an organization<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your organization.<br/>
        /// This configuration will be applied to the matching repository type (all, none, public, private and internal) by default when they are created.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeSecuritySetConfigurationAsDefaultResponse> CodeSecuritySetConfigurationAsDefaultAsync(
            string org,
            int configurationId,
            global::G.CodeSecuritySetConfigurationAsDefaultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set a code security configuration as a default for an organization<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your organization.<br/>
        /// This configuration will be applied to the matching repository type (all, none, public, private and internal) by default when they are created.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="defaultForNewRepos">
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeSecuritySetConfigurationAsDefaultResponse> CodeSecuritySetConfigurationAsDefaultAsync(
            string org,
            int configurationId,
            global::G.CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos? defaultForNewRepos = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}