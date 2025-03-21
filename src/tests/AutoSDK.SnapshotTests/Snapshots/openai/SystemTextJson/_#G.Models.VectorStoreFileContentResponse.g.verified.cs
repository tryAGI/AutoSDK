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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VectorStoreFileContentResponseDataItem> Data { get; set; }

        /// <summary>
        /// Indicates if there are more content pages to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The token for the next page, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? NextPage { get; set; }

        /// <summary>
        /// The object type, which is always `vector_store.file_content.page`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreFileContentResponseObjectJsonConverter))]
        public global::G.VectorStoreFileContentResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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