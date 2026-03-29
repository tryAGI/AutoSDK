//HintName: G.IProjectScoresClient.PatchProjectScoreId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Partially update project_score<br/>
        /// Partially update a project_score object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectScore> PatchProjectScoreIdAsync(
            global::System.Guid projectScoreId,

            global::G.PatchProjectScore request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project_score<br/>
        /// Partially update a project_score object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
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
        global::System.Threading.Tasks.Task<global::G.ProjectScore> PatchProjectScoreIdAsync(
            global::System.Guid projectScoreId,
            string? name = default,
            string? description = default,
            global::G.ProjectScoreType? scoreType = default,
            global::G.ProjectScoreCategories? categories = default,
            global::G.ProjectScoreConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}