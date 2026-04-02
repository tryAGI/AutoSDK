//HintName: G.IWorkspacesClient.PutAdminWorkspacesByWorkspaceId.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Update Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutAdminWorkspacesByWorkspaceIdAsync(
            string workspaceId,

            global::G.PutAdminWorkspacesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> PutAdminWorkspacesByWorkspaceIdAsResponseAsync(
            string workspaceId,

            global::G.PutAdminWorkspacesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workspace
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaults"></param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutAdminWorkspacesByWorkspaceIdAsync(
            string workspaceId,
            string? name = default,
            string? description = default,
            global::G.PutAdminWorkspacesRequestDefaults? defaults = default,
            global::System.Collections.Generic.IList<global::G.UsageLimits>? usageLimits = default,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}