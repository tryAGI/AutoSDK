//HintName: G.Models.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminator(
            global::G.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminator" /> class.
        /// </summary>
        public GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminator()
        {
        }
    }
}