//HintName: G.IProjectsClient.ProjectsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update a project by ID (requires organization-scoped API key).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> ProjectsUpdateAsync(
            string projectId,

            global::G.ProjectsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project by ID (requires organization-scoped API key).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="metadata">
        /// Optional metadata for the project
        /// </param>
        /// <param name="retention">
        /// Number of days to retain data.<br/>
        /// Must be 0 or at least 3 days.<br/>
        /// Requires data-retention entitlement for non-zero values.<br/>
        /// Optional. Will retain existing retention setting if omitted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> ProjectsUpdateAsync(
            string projectId,
            string name,
            object? metadata = default,
            int? retention = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}