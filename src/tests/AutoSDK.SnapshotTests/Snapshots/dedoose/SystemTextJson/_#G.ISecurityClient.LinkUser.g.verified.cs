//HintName: G.ISecurityClient.LinkUser.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// LinkUser<br/>
        /// LinkUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LinkUserAsync(
            global::G.LinkUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// LinkUser<br/>
        /// LinkUser
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> LinkUserAsync(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}