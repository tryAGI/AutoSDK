//HintName: G.IRolesClient.PatchRoleId.g.cs
#nullable enable

namespace G
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Partially update role<br/>
        /// Partially update a role object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="roleId">
        /// Role id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Role> PatchRoleIdAsync(
            global::System.Guid roleId,

            global::G.PatchRole request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update role<br/>
        /// Partially update a role object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="roleId">
        /// Role id
        /// </param>
        /// <param name="description">
        /// Textual description of the role
        /// </param>
        /// <param name="name">
        /// Name of the role
        /// </param>
        /// <param name="addMemberPermissions">
        /// A list of permissions to add to the role
        /// </param>
        /// <param name="removeMemberPermissions">
        /// A list of permissions to remove from the role
        /// </param>
        /// <param name="addMemberRoles">
        /// A list of role IDs to add to the role's inheriting-from set
        /// </param>
        /// <param name="removeMemberRoles">
        /// A list of role IDs to remove from the role's inheriting-from set
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Role> PatchRoleIdAsync(
            global::System.Guid roleId,
            string? description = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.PatchRoleAddMemberPermission>? addMemberPermissions = default,
            global::System.Collections.Generic.IList<global::G.PatchRoleRemoveMemberPermission>? removeMemberPermissions = default,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberRoles = default,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberRoles = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}