//HintName: G.IProjectsClient.UpdateProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update Project<br/>
        /// Update a specific project's settings.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateProjectResponse> UpdateProjectAsync(
            string orgId,
            string projectId,

            global::G.UpdateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Update a specific project's settings.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Description of the project
        /// </param>
        /// <param name="customInstructions">
        /// Custom instructions for memory processing in this project
        /// </param>
        /// <param name="customCategories">
        /// List of custom categories to be used for memory categorization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateProjectResponse> UpdateProjectAsync(
            string orgId,
            string projectId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? customInstructions = default,
            global::System.Collections.Generic.IList<object>? customCategories = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}