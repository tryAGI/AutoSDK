//HintName: G.Models.ComparativeExperiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ComparativeExperiment schema.
    /// </summary>
    public sealed partial class ComparativeExperiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ModifiedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ReferenceDatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiments_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimpleExperimentInfo> ExperimentsInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_stats")]
        public object? FeedbackStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparativeExperiment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="tenantId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="extra"></param>
        /// <param name="experimentsInfo"></param>
        /// <param name="feedbackStats"></param>
        public ComparativeExperiment(
            global::System.Guid id,
            global::System.Guid tenantId,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::System.Guid referenceDatasetId,
            global::System.Collections.Generic.IList<global::G.SimpleExperimentInfo> experimentsInfo,
            string? name,
            string? description,
            object? extra,
            object? feedbackStats)
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.ReferenceDatasetId = referenceDatasetId;
            this.ExperimentsInfo = experimentsInfo ?? throw new global::System.ArgumentNullException(nameof(experimentsInfo));
            this.Name = name;
            this.Description = description;
            this.Extra = extra;
            this.FeedbackStats = feedbackStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparativeExperiment" /> class.
        /// </summary>
        public ComparativeExperiment()
        {
        }
    }
}