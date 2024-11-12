//HintName: G.ICodeSecurityClient.CodeSecurityDeleteConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Delete a code security configuration<br/>
        /// Deletes the desired code security configuration from an organization.<br/>
        /// Repositories attached to the configuration will retain their settings but will no longer be associated with<br/>
        /// the configuration.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CodeSecurityDeleteConfigurationAsync(
            string org,
            int configurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}