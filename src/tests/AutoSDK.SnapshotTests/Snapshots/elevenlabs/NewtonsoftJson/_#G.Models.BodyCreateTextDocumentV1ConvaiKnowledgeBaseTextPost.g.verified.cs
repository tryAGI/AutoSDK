//HintName: G.Models.BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost
    {
        /// <summary>
        /// Text content to be added to the knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost" /> class.
        /// </summary>
        /// <param name="text">
        /// Text content to be added to the knowledge base.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        public BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost(
            string text,
            string? name)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost" /> class.
        /// </summary>
        public BodyCreateTextDocumentV1ConvaiKnowledgeBaseTextPost()
        {
        }
    }
}