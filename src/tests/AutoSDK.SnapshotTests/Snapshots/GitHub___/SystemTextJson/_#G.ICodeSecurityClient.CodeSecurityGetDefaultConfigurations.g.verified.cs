//HintName: G.ICodeSecurityClient.CodeSecurityGetDefaultConfigurations.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Get default code security configurations<br/>
        /// Lists the default code security configurations for an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeSecurityDefaultConfiguration>> CodeSecurityGetDefaultConfigurationsAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}