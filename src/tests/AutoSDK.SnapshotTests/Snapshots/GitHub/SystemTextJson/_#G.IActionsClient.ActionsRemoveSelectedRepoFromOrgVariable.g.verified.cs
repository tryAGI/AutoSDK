//HintName: G.IActionsClient.ActionsRemoveSelectedRepoFromOrgVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove selected repository from an organization variable<br/>
        /// Removes a repository from an organization variable that is<br/>
        /// available to selected repositories. Organization variables that are available to<br/>
        /// selected repositories have their `visibility` field set to `selected`.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsRemoveSelectedRepoFromOrgVariableAsync(
            string org,
            string name,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}