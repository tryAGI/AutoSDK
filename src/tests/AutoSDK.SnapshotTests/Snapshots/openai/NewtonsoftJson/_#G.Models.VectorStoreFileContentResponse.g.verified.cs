//HintName: G.Models.VectorStoreFileContentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents the parsed content of a vector store file.
    /// </summary>
    public sealed partial class VectorStoreFileContentResponse
    {
        /// <summary>
        /// Parsed content of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VectorStoreFileContentResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Indicates if there are more content pages to fetch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// The token for the next page, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public string? NextPage { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `vector_store.file_content.page`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.VectorStoreFileContentResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileContentResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Parsed content of the file.
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more content pages to fetch.
        /// </param>
        /// <param name="nextPage">
        /// The token for the next page, if any.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `vector_store.file_content.page`
        /// </param>
        public VectorStoreFileContentResponse(
            global::System.Collections.Generic.IList<global::G.VectorStoreFileContentResponseDataItem> data,
            bool hasMore,
            string? nextPage,
            global::G.VectorStoreFileContentResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage ?? throw new global::System.ArgumentNullException(nameof(nextPage));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileContentResponse" /> class.
        /// </summary>
        public VectorStoreFileContentResponse()
        {
        }
    }
}