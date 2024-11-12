//HintName: G.ICodespacesClient.CodespacesDeleteCodespacesAccessUsers.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Remove users from Codespaces access for an organization<br/>
        /// Codespaces for the specified users will no longer be billed to the organization.<br/>
        /// To use this endpoint, the access settings for the organization must be set to `selected_members`.<br/>
        /// For information on how to change this setting, see "[Manage access control for organization codespaces](https://docs.github.com/rest/codespaces/organizations#manage-access-control-for-organization-codespaces)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task CodespacesDeleteCodespacesAccessUsersAsync(
            string org,
            global::G.CodespacesDeleteCodespacesAccessUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove users from Codespaces access for an organization<br/>
        /// Codespaces for the specified users will no longer be billed to the organization.<br/>
        /// To use this endpoint, the access settings for the organization must be set to `selected_members`.<br/>
        /// For information on how to change this setting, see "[Manage access control for organization codespaces](https://docs.github.com/rest/codespaces/organizations#manage-access-control-for-organization-codespaces)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members whose codespaces should not be billed to the organization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task CodespacesDeleteCodespacesAccessUsersAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedUsernames,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}