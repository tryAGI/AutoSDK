//HintName: G.IExperimentsClient.CreateExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create experiment<br/>
        /// Create experiment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateExperimentAsync(

            global::G.ExperimentWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create experiment<br/>
        /// Create experiment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetName"></param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="evaluationMethod"></param>
        /// <param name="optimizationId"></param>
        /// <param name="status"></param>
        /// <param name="experimentScores"></param>
        /// <param name="promptVersion"></param>
        /// <param name="promptVersions"></param>
        /// <param name="datasetVersionId">
        /// ID of the dataset version this experiment is linked to. If not provided at creation, experiment will be automatically linked to the latest version.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateExperimentAsync(
            global::System.Guid? id = default,
            string? datasetName = default,
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? name = default,
            global::G.JsonListStringWrite? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.ExperimentWriteType? type = default,
            global::G.ExperimentWriteEvaluationMethod? evaluationMethod = default,
            global::System.Guid? optimizationId = default,
            global::G.ExperimentWriteStatus? status = default,
            global::System.Collections.Generic.IList<global::G.ExperimentScoreWrite>? experimentScores = default,
            global::G.PromptVersionLinkWrite? promptVersion = default,
            global::System.Collections.Generic.IList<global::G.PromptVersionLinkWrite>? promptVersions = default,
            global::System.Guid? datasetVersionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}