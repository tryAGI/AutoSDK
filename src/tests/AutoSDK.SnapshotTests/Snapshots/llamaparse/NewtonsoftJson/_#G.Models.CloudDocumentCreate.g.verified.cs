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
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded_embed_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedEmbedMetadataKeys { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded_llm_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedLlmMetadataKeys { get; set; }

        /// <summary>
        /// indices in the CloudDocument.text where a new page begins. e.g. Second page starts at index specified by page_positions[1].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_positions")]
        public global::System.Collections.Generic.IList<int>? PagePositions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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