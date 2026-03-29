//HintName: G.IReportsClient.CreateEvaluationPipeline.g.cs
#nullable enable

namespace G
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Create Evaluation Pipeline<br/>
        /// Creates a new evaluation pipeline (report) with optional evaluation columns and custom scoring.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEvaluationPipelineResponse> CreateEvaluationPipelineAsync(

            global::G.CreateEvaluationPipelineRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation Pipeline<br/>
        /// Creates a new evaluation pipeline (report) with optional evaluation columns and custom scoring.
        /// </summary>
        /// <param name="datasetGroupId">
        /// The ID of the dataset group containing the dataset versions to evaluate. The dataset group must be within a workspace accessible to the authenticated user.
        /// </param>
        /// <param name="name">
        /// Optional name for the evaluation pipeline. If not provided, a unique name will be auto-generated. Must be between 1 and 255 characters if specified.
        /// </param>
        /// <param name="folderId">
        /// Optional folder ID to organize the pipeline within your workspace. If not specified, the pipeline will be created at the root level.
        /// </param>
        /// <param name="datasetVersionNumber">
        /// Optional specific dataset version number to use. If not specified, the latest non-draft version will be used. Cannot be -1 (draft version).
        /// </param>
        /// <param name="columns">
        /// Optional list of evaluation columns to create with the pipeline.
        /// </param>
        /// <param name="scoreConfiguration">
        /// Optional custom scoring logic configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEvaluationPipelineResponse> CreateEvaluationPipelineAsync(
            int datasetGroupId,
            string? name = default,
            int? folderId = default,
            int? datasetVersionNumber = default,
            global::System.Collections.Generic.IList<global::G.CreateEvaluationPipelineRequestColumn>? columns = default,
            global::G.CreateEvaluationPipelineRequestScoreConfiguration? scoreConfiguration = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}