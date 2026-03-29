//HintName: G.IRolesClient.GetRoleId.g.cs
#nullable enable

namespace G
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Get role<br/>
        /// Get a role object by its id
        /// </summary>
        /// <param name="roleId">
        /// Role id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Role> GetRoleIdAsync(
            global::System.Guid roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}