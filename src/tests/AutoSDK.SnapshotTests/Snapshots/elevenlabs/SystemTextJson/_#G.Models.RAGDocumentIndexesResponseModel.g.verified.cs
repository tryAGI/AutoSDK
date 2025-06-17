//HintName: G.Models.RAGDocumentIndexesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGDocumentIndexesResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RAGDocumentIndexResponseModel> Indexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexesResponseModel" /> class.
        /// </summary>
        /// <param name="indexes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGDocumentIndexesResponseModel(
            global::System.Collections.Generic.IList<global::G.RAGDocumentIndexResponseModel> indexes)
        {
            this.Indexes = indexes ?? throw new global::System.ArgumentNullException(nameof(indexes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexesResponseModel" /> class.
        /// </summary>
        public RAGDocumentIndexesResponseModel()
        {
        }
    }
}