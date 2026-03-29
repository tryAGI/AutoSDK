//HintName: G.Models.NamespaceMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about a namespace.
    /// </summary>
    public sealed partial class NamespaceMetadata
    {
        /// <summary>
        /// The schema of the namespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.AttributeSchemaConfig> Schema { get; set; } = default!;

        /// <summary>
        /// The approximate number of rows in the namespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approx_row_count", Required = global::Newtonsoft.Json.Required.Always)]
        public long ApproxRowCount { get; set; } = default!;

        /// <summary>
        /// The approximate number of logical bytes in the namespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approx_logical_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long ApproxLogicalBytes { get; set; } = default!;

        /// <summary>
        /// The timestamp when the namespace was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The timestamp when the namespace was last modified by a write operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encryption", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.NamespaceMetadataEncryptionVariant1, global::G.NamespaceMetadataEncryptionVariant2> Encryption { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.NamespaceMetadataIndexIndexUpToDate, global::G.NamespaceMetadataIndexIndexUpdating> Index { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadata" /> class.
        /// </summary>
        /// <param name="schema">
        /// The schema of the namespace.
        /// </param>
        /// <param name="approxRowCount">
        /// The approximate number of rows in the namespace.
        /// </param>
        /// <param name="approxLogicalBytes">
        /// The approximate number of logical bytes in the namespace.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the namespace was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the namespace was last modified by a write operation.
        /// </param>
        /// <param name="encryption"></param>
        /// <param name="index"></param>
        public NamespaceMetadata(
            global::System.Collections.Generic.Dictionary<string, global::G.AttributeSchemaConfig> schema,
            long approxRowCount,
            long approxLogicalBytes,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.OneOf<global::G.NamespaceMetadataEncryptionVariant1, global::G.NamespaceMetadataEncryptionVariant2> encryption,
            global::G.OneOf<global::G.NamespaceMetadataIndexIndexUpToDate, global::G.NamespaceMetadataIndexIndexUpdating> index)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.ApproxRowCount = approxRowCount;
            this.ApproxLogicalBytes = approxLogicalBytes;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Encryption = encryption;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadata" /> class.
        /// </summary>
        public NamespaceMetadata()
        {
        }
    }
}