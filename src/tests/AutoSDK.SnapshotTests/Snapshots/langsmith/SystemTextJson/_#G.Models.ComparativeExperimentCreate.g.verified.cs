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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExperimentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ReferenceDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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