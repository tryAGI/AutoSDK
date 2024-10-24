//HintName: G.ICodeSecurityClient.CodeSecurityGetRepositoriesForConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Get repositories associated with a code security configuration<br/>
        /// Lists the repositories associated with a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="status">
        /// Default Value: all
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeSecurityConfigurationRepositories>> CodeSecurityGetRepositoriesForConfigurationAsync(
            string org,
            int configurationId,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}