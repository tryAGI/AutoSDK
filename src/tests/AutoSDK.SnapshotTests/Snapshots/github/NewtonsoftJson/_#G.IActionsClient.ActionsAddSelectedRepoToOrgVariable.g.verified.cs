//HintName: G.IActionsClient.ActionsAddSelectedRepoToOrgVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Add selected repository to an organization variable<br/>
        /// Adds a repository to an organization variable that is available to selected repositories.<br/>
        /// Organization variables that are available to selected repositories have their `visibility` field set to `selected`.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsAddSelectedRepoToOrgVariableAsync(
            string org,
            string name,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}