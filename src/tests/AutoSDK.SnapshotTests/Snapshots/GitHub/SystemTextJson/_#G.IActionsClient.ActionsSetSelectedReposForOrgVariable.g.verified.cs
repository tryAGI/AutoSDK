//HintName: G.IActionsClient.ActionsSetSelectedReposForOrgVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set selected repositories for an organization variable<br/>
        /// Replaces all repositories for an organization variable that is available<br/>
        /// to selected repositories. Organization variables that are available to selected<br/>
        /// repositories have their `visibility` field set to `selected`.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelectedReposForOrgVariableAsync(
            string org,
            string name,
            global::G.ActionsSetSelectedReposForOrgVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set selected repositories for an organization variable<br/>
        /// Replaces all repositories for an organization variable that is available<br/>
        /// to selected repositories. Organization variables that are available to selected<br/>
        /// repositories have their `visibility` field set to `selected`.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="selectedRepositoryIds">
        /// The IDs of the repositories that can access the organization variable.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelectedReposForOrgVariableAsync(
            string org,
            string name,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}