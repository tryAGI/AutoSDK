//HintName: G.IOrgsClient.DeleteOrganizationRoles.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete Organization Roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Role> DeleteOrganizationRolesAsync(
            global::System.Guid roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}