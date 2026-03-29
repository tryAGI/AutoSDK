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
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// Name of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentName { get; set; } = default!;

        /// <summary>
        /// URL to the project's page in the Braintrust app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// URL to the experiment's page in the Braintrust app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentUrl { get; set; } = default!;

        /// <summary>
        /// The experiment which scores are baselined against
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comparison_experiment_name")]
        public string? ComparisonExperimentName { get; set; }

        /// <summary>
        /// Summary of the experiment's scores
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ScoreSummary>? Scores { get; set; }

        /// <summary>
        /// Summary of the experiment's metrics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics")]
        public global::System.Collections.Generic.Dictionary<string, global::G.MetricSummary>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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