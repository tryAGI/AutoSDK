//HintName: G.IProjectScoresClient.DeleteProjectScoreId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Delete project_score<br/>
        /// Delete a project_score object by its id
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectScore> DeleteProjectScoreIdAsync(
            global::System.Guid projectScoreId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}