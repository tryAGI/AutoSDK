//HintName: G.ISecurityClient.SecurityUnlinkUserFromProject.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// UnlinkUserFromProject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SecurityUnlinkUserFromProjectResponse> SecurityUnlinkUserFromProjectAsync(
            string? token = default,
            global::System.Guid userId = default,
            global::System.Guid projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}