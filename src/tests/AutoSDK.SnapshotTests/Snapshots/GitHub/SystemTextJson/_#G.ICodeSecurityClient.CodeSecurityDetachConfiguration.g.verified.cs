//HintName: G.ICodeSecurityClient.CodeSecurityDetachConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Detach configurations from repositories<br/>
        /// Detach code security configuration(s) from a set of repositories.<br/>
        /// Repositories will retain their settings but will no longer be associated with the configuration.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> CodeSecurityDetachConfigurationAsync(
            string org,
            global::G.CodeSecurityDetachConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Detach configurations from repositories<br/>
        /// Detach code security configuration(s) from a set of repositories.<br/>
        /// Repositories will retain their settings but will no longer be associated with the configuration.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs to detach from configurations.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> CodeSecurityDetachConfigurationAsync(
            string org,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}