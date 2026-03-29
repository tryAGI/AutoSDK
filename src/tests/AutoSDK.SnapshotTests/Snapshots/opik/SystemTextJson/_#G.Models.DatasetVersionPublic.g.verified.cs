//HintName: G.Models.DatasetVersionPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionPublic
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_hash")]
        public string? VersionHash { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Indicates whether this is the latest version of the dataset<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_latest")]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// Sequential version name formatted as 'v1', 'v2', etc.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_name")]
        public string? VersionName { get; set; }

        /// <summary>
        /// Total number of items in this version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items_total")]
        public int? ItemsTotal { get; set; }

        /// <summary>
        /// Number of items added since last version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items_added")]
        public int? ItemsAdded { get; set; }

        /// <summary>
        /// Number of items modified since last version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items_modified")]
        public int? ItemsModified { get; set; }

        /// <summary>
        /// Number of items deleted since last version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items_deleted")]
        public int? ItemsDeleted { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_description")]
        public string? ChangeDescription { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Default evaluators for items in this version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorItemPublic>? Evaluators { get; set; }

        /// <summary>
        /// Default execution policy for items in this version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_policy")]
        public global::G.ExecutionPolicyPublic? ExecutionPolicy { get; set; }

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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionPublic" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="datasetId">
        /// Included only in responses
        /// </param>
        /// <param name="versionHash">
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// Included only in responses
        /// </param>
        /// <param name="isLatest">
        /// Indicates whether this is the latest version of the dataset<br/>
        /// Included only in responses
        /// </param>
        /// <param name="versionName">
        /// Sequential version name formatted as 'v1', 'v2', etc.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="itemsTotal">
        /// Total number of items in this version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="itemsAdded">
        /// Number of items added since last version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="itemsModified">
        /// Number of items modified since last version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="itemsDeleted">
        /// Number of items deleted since last version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="changeDescription">
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Included only in responses
        /// </param>
        /// <param name="evaluators">
        /// Default evaluators for items in this version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="executionPolicy">
        /// Default execution policy for items in this version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetVersionPublic(
            global::System.Guid? id,
            global::System.Guid? datasetId,
            string? versionHash,
            global::System.Collections.Generic.IList<string>? tags,
            bool? isLatest,
            string? versionName,
            int? itemsTotal,
            int? itemsAdded,
            int? itemsModified,
            int? itemsDeleted,
            string? changeDescription,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::G.EvaluatorItemPublic>? evaluators,
            global::G.ExecutionPolicyPublic? executionPolicy,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy)
        {
            this.Id = id;
            this.DatasetId = datasetId;
            this.VersionHash = versionHash;
            this.Tags = tags;
            this.IsLatest = isLatest;
            this.VersionName = versionName;
            this.ItemsTotal = itemsTotal;
            this.ItemsAdded = itemsAdded;
            this.ItemsModified = itemsModified;
            this.ItemsDeleted = itemsDeleted;
            this.ChangeDescription = changeDescription;
            this.Metadata = metadata;
            this.Evaluators = evaluators;
            this.ExecutionPolicy = executionPolicy;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionPublic" /> class.
        /// </summary>
        public DatasetVersionPublic()
        {
        }
    }
}