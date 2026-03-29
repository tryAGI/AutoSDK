//HintName: G.Models.KnowledgeBaseRequestKnowledgeBaseText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseRequestKnowledgeBaseText
    {
        /// <summary>
        /// Title of the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Text to add to the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseRequestKnowledgeBaseText" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the text.
        /// </param>
        /// <param name="text">
        /// Text to add to the knowledge base.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseRequestKnowledgeBaseText(
            string title,
            string text)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseRequestKnowledgeBaseText" /> class.
        /// </summary>
        public KnowledgeBaseRequestKnowledgeBaseText()
        {
        }
    }
}