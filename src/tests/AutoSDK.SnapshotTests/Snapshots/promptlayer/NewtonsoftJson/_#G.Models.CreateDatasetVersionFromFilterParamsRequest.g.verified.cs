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
        [global::Newtonsoft.Json.JsonProperty("dataset_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetGroupId { get; set; } = default!;

        /// <summary>
        /// List of variables to parse from the request logs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables_to_parse")]
        public global::System.Collections.Generic.IList<string>? VariablesToParse { get; set; }

        /// <summary>
        /// Filter by specific prompt ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_id")]
        public int? PromptId { get; set; }

        /// <summary>
        /// Filter by specific prompt version ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_id")]
        public int? PromptVersionId { get; set; }

        /// <summary>
        /// Filter by specific prompt label ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_label_id")]
        public int? PromptLabelId { get; set; }

        /// <summary>
        /// Filter by specific workspace ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Filter logs after this timestamp (ISO format)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Filter logs before this timestamp (ISO format)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Filter by specific tags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Filter by metadata key-value pairs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Filter by score ranges
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public global::System.Collections.Generic.Dictionary<string, global::G.CreateDatasetVersionFromFilterParamsRequestScores2>? Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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