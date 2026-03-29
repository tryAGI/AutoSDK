//HintName: G.IProjectsClient.GetPromptsByProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get prompts by project<br/>
        /// Get prompts scoped to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter prompts by name (partial match, case insensitive)
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptPagePublic> GetPromptsByProjectAsync(
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            string? name = default,
            string? sorting = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}