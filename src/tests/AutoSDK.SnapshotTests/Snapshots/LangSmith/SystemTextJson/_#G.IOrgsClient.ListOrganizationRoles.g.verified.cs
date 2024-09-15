//HintName: G.IOrgsClient.ListOrganizationRoles.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List Organization Roles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Role>> ListOrganizationRolesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}