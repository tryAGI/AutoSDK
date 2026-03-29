//HintName: G.IProjectScoresClient.PostProjectScore.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Create project_score<br/>
        /// Create a new project_score. If there is an existing project_score in the project with the same name as the one specified in the request, will return the existing project_score unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectScore> PostProjectScoreAsync(

            global::G.CreateProjectScore request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project_score<br/>
        /// Create a new project_score. If there is an existing project_score in the project with the same name as the one specified in the request, will return the existing project_score unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project score belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project score
        /// </param>
        /// <param name="description">
        /// Textual description of the project score
        /// </param>
        /// <param name="scoreType">
        /// The type of the configured score
        /// </param>
        /// <param name="categories"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectScore> PostProjectScoreAsync(
            global::System.Guid projectId,
            string name,
            global::G.ProjectScoreType scoreType,
            string? description = default,
            global::G.ProjectScoreCategories? categories = default,
            global::G.ProjectScoreConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}