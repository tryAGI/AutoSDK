//HintName: G.Models.ExperimentItemPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TraceId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_visibility_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExperimentItemPublicTraceVisibilityModeJsonConverter))]
        public global::G.ExperimentItemPublicTraceVisibilityMode? TraceVisibilityMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemPublic" /> class.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="datasetItemId"></param>
        /// <param name="traceId"></param>
        /// <param name="id"></param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="traceVisibilityMode">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItemPublic(
            global::System.Guid experimentId,
            global::System.Guid datasetItemId,
            global::System.Guid traceId,
            global::System.Guid? id,
            global::System.Guid? projectId,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? createdBy,
            string? lastUpdatedBy,
            global::G.ExperimentItemPublicTraceVisibilityMode? traceVisibilityMode)
        {
            this.Id = id;
            this.ExperimentId = experimentId;
            this.DatasetItemId = datasetItemId;
            this.TraceId = traceId;
            this.ProjectId = projectId;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedBy = lastUpdatedBy;
            this.TraceVisibilityMode = traceVisibilityMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemPublic" /> class.
        /// </summary>
        public ExperimentItemPublic()
        {
        }
    }
}