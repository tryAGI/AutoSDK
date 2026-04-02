//HintName: G.IWorkspacesClient.CreateAdminWorkspaces.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Workspace> CreateAdminWorkspacesAsync(

            global::G.CreateAdminWorkspacesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.Workspace>> CreateAdminWorkspacesAsResponseAsync(

            global::G.CreateAdminWorkspacesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaults"></param>
        /// <param name="users"></param>
        /// <param name="usageLimits"></param>
        /// <param name="rateLimits"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Workspace> CreateAdminWorkspacesAsync(
            string? name = default,
            string? description = default,
            global::G.CreateAdminWorkspacesRequestDefaults? defaults = default,
            global::System.Collections.Generic.IList<string>? users = default,
            global::System.Collections.Generic.IList<global::G.UsageLimits>? usageLimits = default,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}