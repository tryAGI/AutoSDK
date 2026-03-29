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
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// The digest of the dataset object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The version index of the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionIndex { get; set; }

        /// <summary>
        /// When the object was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The name of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Reference to the dataset rows data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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