//HintName: G.Models.CloudDocumentCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new cloud document.
    /// </summary>
    public sealed partial class CloudDocumentCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_embed_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedEmbedMetadataKeys { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_llm_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedLlmMetadataKeys { get; set; }

        /// <summary>
        /// indices in the CloudDocument.text where a new page begins. e.g. Second page starts at index specified by page_positions[1].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_positions")]
        public global::System.Collections.Generic.IList<int>? PagePositions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDocumentCreate" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="metadata"></param>
        /// <param name="excludedEmbedMetadataKeys">
        /// Default Value: []
        /// </param>
        /// <param name="excludedLlmMetadataKeys">
        /// Default Value: []
        /// </param>
        /// <param name="pagePositions">
        /// indices in the CloudDocument.text where a new page begins. e.g. Second page starts at index specified by page_positions[1].
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudDocumentCreate(
            string text,
            object metadata,
            global::System.Collections.Generic.IList<string>? excludedEmbedMetadataKeys,
            global::System.Collections.Generic.IList<string>? excludedLlmMetadataKeys,
            global::System.Collections.Generic.IList<int>? pagePositions,
            string? id)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ExcludedEmbedMetadataKeys = excludedEmbedMetadataKeys;
            this.ExcludedLlmMetadataKeys = excludedLlmMetadataKeys;
            this.PagePositions = pagePositions;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudDocumentCreate" /> class.
        /// </summary>
        public CloudDocumentCreate()
        {
        }
    }
}