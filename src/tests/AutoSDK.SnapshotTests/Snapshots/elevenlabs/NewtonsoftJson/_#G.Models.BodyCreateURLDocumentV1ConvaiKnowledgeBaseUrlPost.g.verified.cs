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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BodyCreateURLDocumentV1ConvaiKnowledgeBaseUrlPost" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
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