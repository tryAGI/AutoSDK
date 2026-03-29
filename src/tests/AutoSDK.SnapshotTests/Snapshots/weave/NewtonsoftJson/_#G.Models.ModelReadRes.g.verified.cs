//HintName: G.Models.ModelReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelReadRes
    {
        /// <summary>
        /// The model ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// The digest of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// The version index of the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionIndex { get; set; } = default!;

        /// <summary>
        /// When the model was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The source code of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceCode { get; set; } = default!;

        /// <summary>
        /// Additional attributes stored with the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelReadRes" /> class.
        /// </summary>
        /// <param name="objectId">
        /// The model ID
        /// </param>
        /// <param name="digest">
        /// The digest of the model
        /// </param>
        /// <param name="versionIndex">
        /// The version index of the object
        /// </param>
        /// <param name="createdAt">
        /// When the model was created
        /// </param>
        /// <param name="name">
        /// The name of the model
        /// </param>
        /// <param name="sourceCode">
        /// The source code of the model
        /// </param>
        /// <param name="description">
        /// Description of the model
        /// </param>
        /// <param name="attributes">
        /// Additional attributes stored with the model
        /// </param>
        public ModelReadRes(
            string objectId,
            string digest,
            int versionIndex,
            global::System.DateTime createdAt,
            string name,
            string sourceCode,
            string? description,
            object? attributes)
        {
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.VersionIndex = versionIndex;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.SourceCode = sourceCode ?? throw new global::System.ArgumentNullException(nameof(sourceCode));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelReadRes" /> class.
        /// </summary>
        public ModelReadRes()
        {
        }
    }
}