//HintName: G.Models.ComparativeExperimentCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create class for ComparativeExperiment.
    /// </summary>
    public sealed partial class ComparativeExperimentCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExperimentIds { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparativeExperimentCreate" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="experimentIds"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="extra"></param>
        public ComparativeExperimentCreate(
            global::System.Collections.Generic.IList<global::System.Guid> experimentIds,
            global::System.Guid referenceDatasetId,
            global::System.Guid? id,
            string? name,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt,
            object? extra)
        {
            this.ExperimentIds = experimentIds ?? throw new global::System.ArgumentNullException(nameof(experimentIds));
            this.ReferenceDatasetId = referenceDatasetId;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Extra = extra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparativeExperimentCreate" /> class.
        /// </summary>
        public ComparativeExperimentCreate()
        {
        }
    }
}