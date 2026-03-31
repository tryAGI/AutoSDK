//HintName: G.Models.SummarizeExperimentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of an experiment
    /// </summary>
    public sealed partial class SummarizeExperimentResponse
    {
        /// <summary>
        /// Name of the project that the experiment belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Name of the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentName { get; set; }

        /// <summary>
        /// URL to the project's page in the Braintrust app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// URL to the experiment's page in the Braintrust app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentUrl { get; set; }

        /// <summary>
        /// The experiment which scores are baselined against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_experiment_name")]
        public string? ComparisonExperimentName { get; set; }

        /// <summary>
        /// Summary of the experiment's scores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ScoreSummary>? Scores { get; set; }

        /// <summary>
        /// Summary of the experiment's metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.Dictionary<string, global::G.MetricSummary>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeExperimentResponse" /> class.
        /// </summary>
        /// <param name="projectName">
        /// Name of the project that the experiment belongs to
        /// </param>
        /// <param name="experimentName">
        /// Name of the experiment
        /// </param>
        /// <param name="projectUrl">
        /// URL to the project's page in the Braintrust app
        /// </param>
        /// <param name="experimentUrl">
        /// URL to the experiment's page in the Braintrust app
        /// </param>
        /// <param name="comparisonExperimentName">
        /// The experiment which scores are baselined against
        /// </param>
        /// <param name="scores">
        /// Summary of the experiment's scores
        /// </param>
        /// <param name="metrics">
        /// Summary of the experiment's metrics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizeExperimentResponse(
            string projectName,
            string experimentName,
            string projectUrl,
            string experimentUrl,
            string? comparisonExperimentName,
            global::System.Collections.Generic.Dictionary<string, global::G.ScoreSummary>? scores,
            global::System.Collections.Generic.Dictionary<string, global::G.MetricSummary>? metrics)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.ExperimentUrl = experimentUrl ?? throw new global::System.ArgumentNullException(nameof(experimentUrl));
            this.ComparisonExperimentName = comparisonExperimentName;
            this.Scores = scores;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeExperimentResponse" /> class.
        /// </summary>
        public SummarizeExperimentResponse()
        {
        }
    }
}