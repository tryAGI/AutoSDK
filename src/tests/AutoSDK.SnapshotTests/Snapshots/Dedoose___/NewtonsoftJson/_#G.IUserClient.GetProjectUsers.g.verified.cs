//HintName: G.IUserClient.GetProjectUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetProjectUsers<br/>
        /// GetProjectUsers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.User>> GetProjectUsersAsync(
            global::G.GetProjectUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectUsers<br/>
        /// GetProjectUsers
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.User>> GetProjectUsersAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}