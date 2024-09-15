//HintName: G.IActionsClient.ActionsGetOrgVariable.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get an organization variable<br/>
        /// Gets a specific variable in an organization.<br/>
        /// The authenticated user must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationActionsVariable> ActionsGetOrgVariableAsync(
            string org,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}