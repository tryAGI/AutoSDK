//HintName: G.ICodespacesClient.CodespacesSetCodespacesAccess.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Manage access control for organization codespaces<br/>
        /// Sets which users can access codespaces in an organization. This is synonymous with granting or revoking codespaces access permissions for users according to the visibility.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.BasicError> CodespacesSetCodespacesAccessAsync(
            string org,
            global::G.CodespacesSetCodespacesAccessRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Manage access control for organization codespaces<br/>
        /// Sets which users can access codespaces in an organization. This is synonymous with granting or revoking codespaces access permissions for users according to the visibility.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="visibility">
        /// Which users can access codespaces in the organization. `disabled` means that no users can access codespaces in the organization.
        /// </param>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members who should have access to codespaces in the organization. Required when `visibility` is `selected_members`. The provided list of usernames will replace any existing value.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.BasicError> CodespacesSetCodespacesAccessAsync(
            string org,
            global::G.CodespacesSetCodespacesAccessRequestVisibility visibility,
            global::System.Collections.Generic.IList<string>? selectedUsernames = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}