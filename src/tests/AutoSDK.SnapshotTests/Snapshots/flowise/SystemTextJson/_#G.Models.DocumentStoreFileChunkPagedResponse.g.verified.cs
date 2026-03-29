//HintName: G.Models.DocumentStoreFileChunkPagedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreFileChunkPagedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::G.DocumentStoreFileChunk>? Chunks { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public double? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::G.DocumentStoreLoaderForPreview? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentPage")]
        public double? CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storeName")]
        public string? StoreName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreFileChunkPagedResponse" /> class.
        /// </summary>
        /// <param name="chunks"></param>
        /// <param name="count">
        /// Example: 1
        /// </param>
        /// <param name="file"></param>
        /// <param name="currentPage"></param>
        /// <param name="storeName"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentStoreFileChunkPagedResponse(
            global::System.Collections.Generic.IList<global::G.DocumentStoreFileChunk>? chunks,
            double? count,
            global::G.DocumentStoreLoaderForPreview? file,
            double? currentPage,
            string? storeName,
            string? description)
        {
            this.Chunks = chunks;
            this.Count = count;
            this.File = file;
            this.CurrentPage = currentPage;
            this.StoreName = storeName;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreFileChunkPagedResponse" /> class.
        /// </summary>
        public DocumentStoreFileChunkPagedResponse()
        {
        }
    }
}