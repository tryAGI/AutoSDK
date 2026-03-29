//HintName: G.IProjectsClient.GetProjects.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List all projects<br/>
        /// Retrieve a paginated list of all projects in the system.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (project ID)
        /// </param>
        /// <param name="limit">
        /// The max number of projects to return at a time.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="includeExperimentProjects">
        /// Include experiment projects in the response. Experiment projects are created from running experiments.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeDatasetEvaluatorProjects">
        /// Include dataset evaluator projects in the response. Dataset evaluator projects are created when running experiments with persisted evaluators.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetProjectsResponseBody> GetProjectsAsync(
            string? cursor = default,
            int? limit = default,
            bool? includeExperimentProjects = default,
            bool? includeDatasetEvaluatorProjects = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}