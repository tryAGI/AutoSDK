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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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