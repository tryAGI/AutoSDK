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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch" /> class.
        /// </summary>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
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