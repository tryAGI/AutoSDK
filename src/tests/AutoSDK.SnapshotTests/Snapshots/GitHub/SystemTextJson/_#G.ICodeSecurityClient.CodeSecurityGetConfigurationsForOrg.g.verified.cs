//HintName: G.ICodeSecurityClient.CodeSecurityGetConfigurationsForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Get code security configurations for an organization<br/>
        /// Lists all code security configurations available in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="targetType">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeSecurityConfiguration>> CodeSecurityGetConfigurationsForOrgAsync(
            string org,
            global::G.CodeSecurityGetConfigurationsForOrgTargetType? targetType = global::G.CodeSecurityGetConfigurationsForOrgTargetType.All,
            int? perPage = 30,
            string? before = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}