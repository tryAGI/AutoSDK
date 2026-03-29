//HintName: G.Models.KnowledgeBaseResponseDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseResponseDocument
    {
        /// <summary>
        /// This is the content of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// This is the similarity score of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity", Required = global::Newtonsoft.Json.Required.Always)]
        public double Similarity { get; set; } = default!;

        /// <summary>
        /// This is the uuid of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseResponseDocument" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the document.
        /// </param>
        /// <param name="similarity">
        /// This is the similarity score of the document.
        /// </param>
        /// <param name="uuid">
        /// This is the uuid of the document.
        /// </param>
        public KnowledgeBaseResponseDocument(
            string content,
            double similarity,
            string? uuid)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Similarity = similarity;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseResponseDocument" /> class.
        /// </summary>
        public KnowledgeBaseResponseDocument()
        {
        }
    }
}