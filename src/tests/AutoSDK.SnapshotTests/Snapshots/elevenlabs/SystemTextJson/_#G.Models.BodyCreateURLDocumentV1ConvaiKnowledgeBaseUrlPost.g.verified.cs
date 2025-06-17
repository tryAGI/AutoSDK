//HintName: G.Models.BodyCreateURLDocumentV1ConvaiKnowledgeBaseUrlPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateURLDocumentV1ConvaiKnowledgeBaseUrlPost
    {
        /// <summary>
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        /// Initializes a new instance of the <see cref="BodyCreateURLDocumentV1ConvaiKnowledgeBaseUrlPost" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateURLDocumentV1ConvaiKnowledgeBaseUrlPost(
            string url,
            string? name)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateURLDocumentV1ConvaiKnowledgeBaseUrlPost" /> class.
        /// </summary>
        public BodyCreateURLDocumentV1ConvaiKnowledgeBaseUrlPost()
        {
        }
    }
}