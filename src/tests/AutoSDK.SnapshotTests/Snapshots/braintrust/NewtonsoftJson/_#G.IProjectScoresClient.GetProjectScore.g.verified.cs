//HintName: G.IProjectScoresClient.GetProjectScore.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// List project_scores<br/>
        /// List out all project_scores. The project_scores are sorted by creation date, with the most recently-created project_scores coming first
        /// </summary>
        /// <param name="limit">
        /// Limit the number of objects to return
        /// </param>
        /// <param name="startingAfter">
        /// Pagination cursor id.<br/>
        /// For example, if the final item in the last page you fetched had an id of `foo`, pass `starting_after=foo` to fetch the next page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="endingBefore">
        /// Pagination cursor id.<br/>
        /// For example, if the initial item in the last page you fetched had an id of `foo`, pass `ending_before=foo` to fetch the previous page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="ids">
        /// Filter search results to a particular set of object IDs. To specify a list of IDs, include the query param multiple times
        /// </param>
        /// <param name="projectScoreName">
        /// Name of the project_score to search for
        /// </param>
        /// <param name="projectName">
        /// Name of the project to search for
        /// </param>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="orgName">
        /// Filter search results to within a particular organization
        /// </param>
        /// <param name="scoreType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetProjectScoreResponse> GetProjectScoreAsync(
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::G.Ids? ids = default,
            string? projectScoreName = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            string? orgName = default,
            global::G.AnyOf<global::G.ProjectScoreType?, global::System.Collections.Generic.IList<global::G.AllOf<global::G.ProjectScoreType?, object>>>? scoreType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}