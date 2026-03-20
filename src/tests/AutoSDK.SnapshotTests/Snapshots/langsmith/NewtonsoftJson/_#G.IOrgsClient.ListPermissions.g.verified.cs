//HintName: G.IOrgsClient.ListPermissions.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List Permissions
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PermissionResponse>> ListPermissionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}