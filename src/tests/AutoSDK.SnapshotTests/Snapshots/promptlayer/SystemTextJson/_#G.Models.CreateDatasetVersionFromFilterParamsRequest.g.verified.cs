//HintName: G.Models.CreateDatasetVersionFromFilterParamsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsRequest
    {
        /// <summary>
        /// ID of the dataset group where the new version will be created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// List of variables to parse from the request logs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables_to_parse")]
        public global::System.Collections.Generic.IList<string>? VariablesToParse { get; set; }

        /// <summary>
        /// Filter by specific prompt ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public int? PromptId { get; set; }

        /// <summary>
        /// Filter by specific prompt version ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        public int? PromptVersionId { get; set; }

        /// <summary>
        /// Filter by specific prompt label ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_label_id")]
        public int? PromptLabelId { get; set; }

        /// <summary>
        /// Filter by specific workspace ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Filter logs after this timestamp (ISO format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Filter logs before this timestamp (ISO format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Filter by specific tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Filter by metadata key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Filter by score ranges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.Dictionary<string, global::G.CreateDatasetVersionFromFilterParamsRequestScores2>? Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group where the new version will be created
        /// </param>
        /// <param name="variablesToParse">
        /// List of variables to parse from the request logs
        /// </param>
        /// <param name="promptId">
        /// Filter by specific prompt ID
        /// </param>
        /// <param name="promptVersionId">
        /// Filter by specific prompt version ID
        /// </param>
        /// <param name="promptLabelId">
        /// Filter by specific prompt label ID
        /// </param>
        /// <param name="workspaceId">
        /// Filter by specific workspace ID
        /// </param>
        /// <param name="startTime">
        /// Filter logs after this timestamp (ISO format)
        /// </param>
        /// <param name="endTime">
        /// Filter logs before this timestamp (ISO format)
        /// </param>
        /// <param name="tags">
        /// Filter by specific tags
        /// </param>
        /// <param name="metadata">
        /// Filter by metadata key-value pairs
        /// </param>
        /// <param name="scores">
        /// Filter by score ranges
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFilterParamsRequest(
            int datasetGroupId,
            global::System.Collections.Generic.IList<string>? variablesToParse,
            int? promptId,
            int? promptVersionId,
            int? promptLabelId,
            int? workspaceId,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.Dictionary<string, global::G.CreateDatasetVersionFromFilterParamsRequestScores2>? scores)
        {
            this.DatasetGroupId = datasetGroupId;
            this.VariablesToParse = variablesToParse;
            this.PromptId = promptId;
            this.PromptVersionId = promptVersionId;
            this.PromptLabelId = promptLabelId;
            this.WorkspaceId = workspaceId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Tags = tags;
            this.Metadata = metadata;
            this.Scores = scores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsRequest" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsRequest()
        {
        }
    }
}