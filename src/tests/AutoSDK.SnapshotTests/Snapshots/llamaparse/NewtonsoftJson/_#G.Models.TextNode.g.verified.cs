//HintName: G.Models.TextNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provided for backward compatibility.<br/>
    /// Note: we keep the field with the typo "seperator" to maintain backward compatibility for<br/>
    /// serialized objects.
    /// </summary>
    public sealed partial class TextNode
    {
        /// <summary>
        /// Unique ID of the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id_")]
        public string? Id { get; set; }

        /// <summary>
        /// Embedding of the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// A flat dictionary of metadata fields
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_info")]
        public object? ExtraInfo { get; set; }

        /// <summary>
        /// Metadata keys that are excluded from text for the embed model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded_embed_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedEmbedMetadataKeys { get; set; }

        /// <summary>
        /// Metadata keys that are excluded from text for the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded_llm_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedLlmMetadataKeys { get; set; }

        /// <summary>
        /// A mapping of relationships to other node information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relationships")]
        public object? Relationships { get; set; }

        /// <summary>
        /// Template for how metadata is formatted, with {key} and {value} placeholders.<br/>
        /// Default Value: {key}: {value}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_template")]
        public string? MetadataTemplate { get; set; }

        /// <summary>
        /// Separator between metadata fields when converting to string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_seperator")]
        public string? MetadataSeperator { get; set; }

        /// <summary>
        /// Text content of the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// MIME type of the node content.<br/>
        /// Default Value: text/plain
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimetype")]
        public string? Mimetype { get; set; }

        /// <summary>
        /// Start char index of the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_char_idx")]
        public int? StartCharIdx { get; set; }

        /// <summary>
        /// End char index of the node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_char_idx")]
        public int? EndCharIdx { get; set; }

        /// <summary>
        /// Template for how text is formatted, with {content} and {metadata_str} placeholders.<br/>
        /// Default Value: {metadata_str}<br/>
        /// {content}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_template")]
        public string? TextTemplate { get; set; }

        /// <summary>
        /// Default Value: TextNode
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextNode" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID of the node.
        /// </param>
        /// <param name="embedding">
        /// Embedding of the node.
        /// </param>
        /// <param name="extraInfo">
        /// A flat dictionary of metadata fields
        /// </param>
        /// <param name="excludedEmbedMetadataKeys">
        /// Metadata keys that are excluded from text for the embed model.
        /// </param>
        /// <param name="excludedLlmMetadataKeys">
        /// Metadata keys that are excluded from text for the LLM.
        /// </param>
        /// <param name="relationships">
        /// A mapping of relationships to other node information.
        /// </param>
        /// <param name="metadataTemplate">
        /// Template for how metadata is formatted, with {key} and {value} placeholders.<br/>
        /// Default Value: {key}: {value}
        /// </param>
        /// <param name="metadataSeperator">
        /// Separator between metadata fields when converting to string.
        /// </param>
        /// <param name="text">
        /// Text content of the node.
        /// </param>
        /// <param name="mimetype">
        /// MIME type of the node content.<br/>
        /// Default Value: text/plain
        /// </param>
        /// <param name="startCharIdx">
        /// Start char index of the node.
        /// </param>
        /// <param name="endCharIdx">
        /// End char index of the node.
        /// </param>
        /// <param name="textTemplate">
        /// Template for how text is formatted, with {content} and {metadata_str} placeholders.<br/>
        /// Default Value: {metadata_str}<br/>
        /// {content}
        /// </param>
        /// <param name="className">
        /// Default Value: TextNode
        /// </param>
        public TextNode(
            string? id,
            global::System.Collections.Generic.IList<double>? embedding,
            object? extraInfo,
            global::System.Collections.Generic.IList<string>? excludedEmbedMetadataKeys,
            global::System.Collections.Generic.IList<string>? excludedLlmMetadataKeys,
            object? relationships,
            string? metadataTemplate,
            string? metadataSeperator,
            string? text,
            string? mimetype,
            int? startCharIdx,
            int? endCharIdx,
            string? textTemplate,
            string? className)
        {
            this.Id = id;
            this.Embedding = embedding;
            this.ExtraInfo = extraInfo;
            this.ExcludedEmbedMetadataKeys = excludedEmbedMetadataKeys;
            this.ExcludedLlmMetadataKeys = excludedLlmMetadataKeys;
            this.Relationships = relationships;
            this.MetadataTemplate = metadataTemplate;
            this.MetadataSeperator = metadataSeperator;
            this.Text = text;
            this.Mimetype = mimetype;
            this.StartCharIdx = startCharIdx;
            this.EndCharIdx = endCharIdx;
            this.TextTemplate = textTemplate;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextNode" /> class.
        /// </summary>
        public TextNode()
        {
        }
    }
}