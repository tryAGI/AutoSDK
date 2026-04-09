//HintName: G.IRolesClient.DeleteRoleId.g.cs
#nullable enable

namespace G
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Delete role<br/>
        /// Delete a role object by its id
        /// </summary>
        /// <param name="roleId">
        /// Role id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Role> DeleteRoleIdAsync(
            global::System.Guid roleId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}