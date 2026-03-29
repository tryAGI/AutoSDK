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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the dataset run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata of the dataset run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// Id of the associated dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// Name of the associated dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// The date and time when the dataset run was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time when the dataset run was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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