//HintName: G.IWorkspacesClient.GetWorkspaceVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get workspace version<br/>
        /// Determines whether the workspace should use Opik V1 (legacy workspace-scoped)<br/>
        /// or Opik V2 (project-first) navigation. The backend is the single authority for this<br/>
        /// determination, clients must never derive the version themselves.<br/>
        /// Determination logic (priority order):<br/>
        /// 1) Feature flag override (TOGGLE_FORCE_WORKSPACE_VERSION)<br/>
        /// 2) Auth one-way V2 gate (authenticated mode only, not yet implemented)<br/>
        /// 3) Version 1 entity check (entities without project_id)<br/>
        /// 4) Fallback on failure<br/>
        /// In unauthenticated mode (authentication.enabled=false), auth steps are skipped.<br/>
        /// Called by the frontend on workspace load.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceVersion> GetWorkspaceVersionAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}