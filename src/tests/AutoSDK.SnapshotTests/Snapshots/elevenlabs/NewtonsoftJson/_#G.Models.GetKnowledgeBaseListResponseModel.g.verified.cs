//HintName: G.Models.GetKnowledgeBaseListResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseListResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DocumentsItem> Documents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseListResponseModel" /> class.
        /// </summary>
        /// <param name="documents"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
        public GetKnowledgeBaseListResponseModel(
            global::System.Collections.Generic.IList<global::G.DocumentsItem> documents,
            bool hasMore,
            string? nextCursor)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseListResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseListResponseModel()
        {
        }
    }
}