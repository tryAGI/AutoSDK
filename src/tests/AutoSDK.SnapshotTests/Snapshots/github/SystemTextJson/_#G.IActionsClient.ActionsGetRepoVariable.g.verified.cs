//HintName: G.IActionsClient.ActionsGetRepoVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a repository variable<br/>
        /// Gets a specific variable in a repository.<br/>
        /// The authenticated user must have collaborator access to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsVariable> ActionsGetRepoVariableAsync(
            string owner,
            string repo,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}