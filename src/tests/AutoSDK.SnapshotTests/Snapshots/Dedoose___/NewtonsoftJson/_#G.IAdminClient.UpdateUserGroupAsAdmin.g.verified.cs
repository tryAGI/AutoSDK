//HintName: G.IAdminClient.UpdateUserGroupAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// UpdateUserGroup<br/>
        /// UpdateUserGroup
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserGroupAsAdminAsync(
            global::G.UpdateUserGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateUserGroup<br/>
        /// UpdateUserGroup
        /// </summary>
        /// <param name="group"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserGroupAsAdminAsync(
            global::G.UserGroup group,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}