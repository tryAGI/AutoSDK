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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DocumentContentType Type { get; set; }

        /// <summary>
        /// Relevant information that could be used by the model to generate a more accurate reply.<br/>
        /// The content of each document are generally short (should be under 300 words). Metadata should be used to provide additional information, both the key name and the value will be<br/>
        /// passed to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Document Document { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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