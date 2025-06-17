//HintName: G.Models.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch
    {
        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch" /> class.
        /// </summary>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch" /> class.
        /// </summary>
        public BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch()
        {
        }
    }
}