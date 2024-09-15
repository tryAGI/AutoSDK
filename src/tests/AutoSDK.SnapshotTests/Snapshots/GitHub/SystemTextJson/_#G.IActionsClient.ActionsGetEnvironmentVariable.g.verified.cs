//HintName: G.IActionsClient.ActionsGetEnvironmentVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get an environment variable<br/>
        /// Gets a specific variable in an environment.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsVariable> ActionsGetEnvironmentVariableAsync(
            string owner,
            string repo,
            string environmentName,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}