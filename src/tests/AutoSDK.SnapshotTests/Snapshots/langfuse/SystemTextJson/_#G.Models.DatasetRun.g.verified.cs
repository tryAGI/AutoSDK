//HintName: G.Models.DatasetRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetRun
    {
        /// <summary>
        /// Unique identifier of the dataset run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the dataset run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata of the dataset run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Id of the associated dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Name of the associated dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// The date and time when the dataset run was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the dataset run was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the dataset run
        /// </param>
        /// <param name="name">
        /// Name of the dataset run
        /// </param>
        /// <param name="metadata">
        /// Metadata of the dataset run
        /// </param>
        /// <param name="datasetId">
        /// Id of the associated dataset
        /// </param>
        /// <param name="datasetName">
        /// Name of the associated dataset
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the dataset run was created
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the dataset run was last updated
        /// </param>
        /// <param name="description">
        /// Description of the run
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetRun(
            string id,
            string name,
            object metadata,
            string datasetId,
            string datasetName,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRun" /> class.
        /// </summary>
        public DatasetRun()
        {
        }
    }
}