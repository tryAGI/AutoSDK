//HintName: G.Models.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator(
            global::G.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator" /> class.
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminator()
        {
        }
    }
}