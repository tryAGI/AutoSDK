//HintName: G.Models.DatasetReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetReadRes
    {
        /// <summary>
        /// The dataset ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// The digest of the dataset object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// The version index of the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionIndex { get; set; } = default!;

        /// <summary>
        /// When the object was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Reference to the dataset rows data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public string Rows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetReadRes" /> class.
        /// </summary>
        /// <param name="objectId">
        /// The dataset ID
        /// </param>
        /// <param name="digest">
        /// The digest of the dataset object
        /// </param>
        /// <param name="versionIndex">
        /// The version index of the object
        /// </param>
        /// <param name="createdAt">
        /// When the object was created
        /// </param>
        /// <param name="name">
        /// The name of the dataset
        /// </param>
        /// <param name="rows">
        /// Reference to the dataset rows data
        /// </param>
        /// <param name="description">
        /// Description of the dataset
        /// </param>
        public DatasetReadRes(
            string objectId,
            string digest,
            int versionIndex,
            global::System.DateTime createdAt,
            string name,
            string rows,
            string? description)
        {
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.VersionIndex = versionIndex;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetReadRes" /> class.
        /// </summary>
        public DatasetReadRes()
        {
        }
    }
}