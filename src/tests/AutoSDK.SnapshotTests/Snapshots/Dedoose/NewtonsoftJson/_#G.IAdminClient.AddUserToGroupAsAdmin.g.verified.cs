//HintName: G.IAdminClient.AddUserToGroupAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// AddUserToGroup<br/>
        /// AddUserToGroup
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddUserToGroupAsAdminAsync(
            global::G.AddUserToGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddUserToGroup<br/>
        /// AddUserToGroup
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddUserToGroupAsAdminAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}