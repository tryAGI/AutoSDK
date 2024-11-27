//HintName: G.IAdminClient.UnlinkUserFromProjectAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// UnlinkUserFromProject<br/>
        /// UnlinkUserFromProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnlinkUserFromProjectAsAdminAsync(
            global::G.UnlinkUserFromProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UnlinkUserFromProject<br/>
        /// UnlinkUserFromProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UnlinkUserFromProjectAsAdminAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}