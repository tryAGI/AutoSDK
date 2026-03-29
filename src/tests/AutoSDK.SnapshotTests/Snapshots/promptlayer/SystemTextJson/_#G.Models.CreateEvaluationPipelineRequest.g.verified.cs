//HintName: G.Models.CreateEvaluationPipelineRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"dataset_group_id":123,"name":"QA Evaluation Pipeline","columns":[{"column_type":"LLM_ASSERTION","name":"Language Check","configuration":{"source":"response","prompt":"Is the response written in {language}?","variable_mappings":{"language":"target_language"}},"is_part_of_score":true}]}
    /// </summary>
    public sealed partial class CreateEvaluationPipelineRequest
    {
        /// <summary>
        /// The ID of the dataset group containing the dataset versions to evaluate. The dataset group must be within a workspace accessible to the authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// Optional name for the evaluation pipeline. If not provided, a unique name will be auto-generated. Must be between 1 and 255 characters if specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional folder ID to organize the pipeline within your workspace. If not specified, the pipeline will be created at the root level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Optional specific dataset version number to use. If not specified, the latest non-draft version will be used. Cannot be -1 (draft version).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version_number")]
        public int? DatasetVersionNumber { get; set; }

        /// <summary>
        /// Optional list of evaluation columns to create with the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<global::G.CreateEvaluationPipelineRequestColumn>? Columns { get; set; }

        /// <summary>
        /// Optional custom scoring logic configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration")]
        public global::G.CreateEvaluationPipelineRequestScoreConfiguration? ScoreConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvaluationPipelineRequest(
            int datasetGroupId,
            string? name,
            int? folderId,
            int? datasetVersionNumber,
            global::System.Collections.Generic.IList<global::G.CreateEvaluationPipelineRequestColumn>? columns,
            global::G.CreateEvaluationPipelineRequestScoreConfiguration? scoreConfiguration)
        {
            this.DatasetGroupId = datasetGroupId;
            this.Name = name;
            this.FolderId = folderId;
            this.DatasetVersionNumber = datasetVersionNumber;
            this.Columns = columns;
            this.ScoreConfiguration = scoreConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequest" /> class.
        /// </summary>
        public CreateEvaluationPipelineRequest()
        {
        }
    }
}