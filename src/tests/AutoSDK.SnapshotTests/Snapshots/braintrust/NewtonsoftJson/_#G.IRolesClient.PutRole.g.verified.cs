//HintName: G.IRolesClient.PutRole.g.cs
#nullable enable

namespace G
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Create or replace role<br/>
        /// Create or replace role. If there is an existing role with the same name as the one specified in the request, will replace the existing role with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Role> PutRoleAsync(

            global::G.CreateRole request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace role<br/>
        /// Create or replace role. If there is an existing role with the same name as the one specified in the request, will replace the existing role with the provided fields
        /// </summary>
        /// <param name="name">
        /// Name of the role
        /// </param>
        /// <param name="description">
        /// Textual description of the role
        /// </param>
        /// <param name="memberPermissions">
        /// (permission, restrict_object_type) tuples which belong to this role
        /// </param>
        /// <param name="memberRoles">
        /// Ids of the roles this role inherits from<br/>
        /// An inheriting role has all the permissions contained in its member roles, as well as all of their inherited permissions
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the role belongs in.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Role> PutRoleAsync(
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.CreateRoleMemberPermission>? memberPermissions = default,
            global::System.Collections.Generic.IList<global::System.Guid>? memberRoles = default,
            string? orgName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}