//HintName: G.IProjectsClient.ProjectsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new project (requires organization-scoped API key)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> ProjectsCreateAsync(

            global::G.ProjectsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new project (requires organization-scoped API key)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metadata">
        /// Optional metadata for the project
        /// </param>
        /// <param name="retention">
        /// Number of days to retain data. Must be 0 or at least 3 days. Requires data-retention entitlement for non-zero values. Optional.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> ProjectsCreateAsync(
            string name,
            int retention,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}