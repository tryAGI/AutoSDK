//HintName: G.Models.Optimization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Optimization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectiveName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OptimizationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OptimizationStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonListStringJsonConverter))]
        public global::G.JsonListString? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_config")]
        public global::G.OptimizationStudioConfig? StudioConfig { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_trials")]
        public long? NumTrials { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? FeedbackScores { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? ExperimentScores { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_objective_score")]
        public double? BaselineObjectiveScore { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_objective_score")]
        public double? BestObjectiveScore { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_duration")]
        public double? BaselineDuration { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_duration")]
        public double? BestDuration { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_cost")]
        public double? BaselineCost { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_cost")]
        public double? BestCost { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_optimization_cost")]
        public double? TotalOptimizationCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Optimization" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="objectiveName"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="studioConfig"></param>
        /// <param name="datasetId">
        /// Included only in responses
        /// </param>
        /// <param name="numTrials">
        /// Included only in responses
        /// </param>
        /// <param name="feedbackScores">
        /// Included only in responses
        /// </param>
        /// <param name="experimentScores">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="baselineObjectiveScore">
        /// Included only in responses
        /// </param>
        /// <param name="bestObjectiveScore">
        /// Included only in responses
        /// </param>
        /// <param name="baselineDuration">
        /// Included only in responses
        /// </param>
        /// <param name="bestDuration">
        /// Included only in responses
        /// </param>
        /// <param name="baselineCost">
        /// Included only in responses
        /// </param>
        /// <param name="bestCost">
        /// Included only in responses
        /// </param>
        /// <param name="totalOptimizationCost">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Optimization(
            string datasetName,
            string objectiveName,
            global::G.OptimizationStatus status,
            global::System.Guid? id,
            string? name,
            string? projectName,
            global::System.Guid? projectId,
            global::G.JsonListString? metadata,
            global::G.OptimizationStudioConfig? studioConfig,
            global::System.Guid? datasetId,
            long? numTrials,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? feedbackScores,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? experimentScores,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            double? baselineObjectiveScore,
            double? bestObjectiveScore,
            double? baselineDuration,
            double? bestDuration,
            double? baselineCost,
            double? bestCost,
            double? totalOptimizationCost)
        {
            this.Id = id;
            this.Name = name;
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.ObjectiveName = objectiveName ?? throw new global::System.ArgumentNullException(nameof(objectiveName));
            this.Status = status;
            this.Metadata = metadata;
            this.StudioConfig = studioConfig;
            this.DatasetId = datasetId;
            this.NumTrials = numTrials;
            this.FeedbackScores = feedbackScores;
            this.ExperimentScores = experimentScores;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.BaselineObjectiveScore = baselineObjectiveScore;
            this.BestObjectiveScore = bestObjectiveScore;
            this.BaselineDuration = baselineDuration;
            this.BestDuration = bestDuration;
            this.BaselineCost = baselineCost;
            this.BestCost = bestCost;
            this.TotalOptimizationCost = totalOptimizationCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Optimization" /> class.
        /// </summary>
        public Optimization()
        {
        }
    }
}