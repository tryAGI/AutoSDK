//HintName: G.IActionsClient.ActionsDeleteEnvironmentVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete an environment variable<br/>
        /// Deletes an environment variable using the variable name.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="environmentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsDeleteEnvironmentVariableAsync(
            string owner,
            string repo,
            string name,
            string environmentName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}