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
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.AttributeSchemaConfig> Schema { get; set; }

        /// <summary>
        /// The approximate number of rows in the namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approx_row_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ApproxRowCount { get; set; }

        /// <summary>
        /// The approximate number of logical bytes in the namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approx_logical_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ApproxLogicalBytes { get; set; }

        /// <summary>
        /// The timestamp when the namespace was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the namespace was last modified by a write operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NamespaceMetadataEncryptionVariant1, global::G.NamespaceMetadataEncryptionVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.NamespaceMetadataEncryptionVariant1, global::G.NamespaceMetadataEncryptionVariant2> Encryption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NamespaceMetadataIndexIndexUpToDate, global::G.NamespaceMetadataIndexIndexUpdating>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.NamespaceMetadataIndexIndexUpToDate, global::G.NamespaceMetadataIndexIndexUpdating> Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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