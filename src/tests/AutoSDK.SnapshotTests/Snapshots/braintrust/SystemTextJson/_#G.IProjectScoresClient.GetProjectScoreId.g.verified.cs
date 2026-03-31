//HintName: G.IProjectScoresClient.GetProjectScoreId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Get project_score<br/>
        /// Get a project_score object by its id
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectScore> GetProjectScoreIdAsync(
            global::System.Guid projectScoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}