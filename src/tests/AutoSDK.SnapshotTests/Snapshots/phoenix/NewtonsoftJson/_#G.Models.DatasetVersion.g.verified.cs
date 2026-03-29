//HintName: G.Models.DatasetVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersion" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        public DatasetVersion(
            string versionId,
            object metadata,
            global::System.DateTime createdAt,
            string? description)
        {
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Description = description;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersion" /> class.
        /// </summary>
        public DatasetVersion()
        {
        }
    }
}