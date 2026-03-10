//HintName: G.Models.GetDocumentationFromKnowledgeBaseResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentationFromKnowledgeBaseResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter))]
        public global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentationFromKnowledgeBaseResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentationFromKnowledgeBaseResponseDiscriminator(
            global::G.GetDocumentationFromKnowledgeBaseResponseDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentationFromKnowledgeBaseResponseDiscriminator" /> class.
        /// </summary>
        public GetDocumentationFromKnowledgeBaseResponseDiscriminator()
        {
        }
    }
}