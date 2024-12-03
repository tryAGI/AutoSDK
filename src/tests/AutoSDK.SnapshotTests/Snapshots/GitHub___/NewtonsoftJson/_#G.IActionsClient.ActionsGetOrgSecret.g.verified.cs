//HintName: G.IActionsClient.ActionsGetOrgSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get an organization secret<br/>
        /// Gets a single organization secret without revealing its encrypted value.<br/>
        /// The authenticated user must have collaborator access to a repository to create, update, or read secrets<br/>
        /// OAuth tokens and personal access tokens (classic) need the`admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationActionsSecret> ActionsGetOrgSecretAsync(
            string org,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}