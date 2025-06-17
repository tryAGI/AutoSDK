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
        [global::Newtonsoft.Json.JsonProperty("indexes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RAGDocumentIndexResponseModel> Indexes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexesResponseModel" /> class.
        /// </summary>
        /// <param name="indexes"></param>
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