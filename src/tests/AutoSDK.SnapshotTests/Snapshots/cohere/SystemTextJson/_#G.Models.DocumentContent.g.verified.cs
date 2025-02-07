//HintName: G.Models.DocumentContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Document content.
    /// </summary>
    public sealed partial class DocumentContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DocumentContentTypeJsonConverter))]
        public global::G.DocumentContentType Type { get; set; }

        /// <summary>
        /// Relevant information that could be used by the model to generate a more accurate reply.<br/>
        /// The content of each document are generally short (should be under 300 words). Metadata should be used to provide additional information, both the key name and the value will be<br/>
        /// passed to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Document Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentContent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="document">
        /// Relevant information that could be used by the model to generate a more accurate reply.<br/>
        /// The content of each document are generally short (should be under 300 words). Metadata should be used to provide additional information, both the key name and the value will be<br/>
        /// passed to the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentContent(
            global::G.Document document,
            global::G.DocumentContentType type)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentContent" /> class.
        /// </summary>
        public DocumentContent()
        {
        }
    }
}