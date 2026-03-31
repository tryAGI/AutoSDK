//HintName: G.IProjectTagsClient.PostProjectTag.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectTagsClient
    {
        /// <summary>
        /// Create project_tag<br/>
        /// Create a new project_tag. If there is an existing project_tag in the project with the same name as the one specified in the request, will return the existing project_tag unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectTag> PostProjectTagAsync(

            global::G.CreateProjectTag request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project_tag<br/>
        /// Create a new project_tag. If there is an existing project_tag in the project with the same name as the one specified in the request, will return the existing project_tag unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project tag belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project tag
        /// </param>
        /// <param name="description">
        /// Textual description of the project tag
        /// </param>
        /// <param name="color">
        /// Color of the tag for the UI
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectTag> PostProjectTagAsync(
            global::System.Guid projectId,
            string name,
            string? description = default,
            string? color = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}