//HintName: G.ICodeSecurityClient.CodeSecurityGetConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Get a code security configuration<br/>
        /// Gets a code security configuration available in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeSecurityConfiguration> CodeSecurityGetConfigurationAsync(
            string org,
            int configurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}