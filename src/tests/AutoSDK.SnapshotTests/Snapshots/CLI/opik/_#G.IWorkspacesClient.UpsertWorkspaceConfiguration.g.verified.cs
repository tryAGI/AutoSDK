//HintName: G.IWorkspacesClient.UpsertWorkspaceConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Upsert workspace configuration<br/>
        /// Upsert workspace configuration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceConfiguration> UpsertWorkspaceConfigurationAsync(

            global::G.WorkspaceConfiguration request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert workspace configuration<br/>
        /// Upsert workspace configuration
        /// </summary>
        /// <param name="timeoutToMarkThreadAsInactive">
        /// Duration in ISO-8601 format (e.g., PT30M for 30 minutes, PT2H for 2 hours, P1D for 1 day). Minimum precision supported is seconds, please use a duration with seconds precision or higher. Also, the max duration allowed is 7 days.
        /// </param>
        /// <param name="truncationOnTables">
        /// Enable or disable data truncation in table views. When disabled, the frontend will limit pagination to prevent performance issues. Default: true (truncation enabled).<br/>
        /// Example: true
        /// </param>
        /// <param name="colorMap">
        /// Workspace-level color map. Maps label names to hex color values (e.g. #FF0000). Max 10000 entries.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceConfiguration> UpsertWorkspaceConfigurationAsync(
            string? timeoutToMarkThreadAsInactive = default,
            bool? truncationOnTables = default,
            global::System.Collections.Generic.Dictionary<string, string>? colorMap = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}