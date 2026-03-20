//HintName: G.IWorkspacesClient.GetCurrentWorkspaceUsageLimitsInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Current Workspace Usage Limits Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TenantUsageLimitInfo> GetCurrentWorkspaceUsageLimitsInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}