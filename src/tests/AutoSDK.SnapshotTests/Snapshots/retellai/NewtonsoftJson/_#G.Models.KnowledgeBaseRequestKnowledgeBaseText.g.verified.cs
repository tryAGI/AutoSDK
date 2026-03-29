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
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Text to add to the knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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