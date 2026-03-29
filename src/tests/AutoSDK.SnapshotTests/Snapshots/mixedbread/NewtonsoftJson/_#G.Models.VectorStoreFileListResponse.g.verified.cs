//HintName: G.Models.VectorStoreFileListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List response wrapper for vector store files.
    /// </summary>
    public sealed partial class VectorStoreFileListResponse
    {
        /// <summary>
        /// Response model for cursor-based pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CursorPaginationResponse Pagination { get; set; } = default!;

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The list of vector store files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VectorStoreFile> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileListResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// Response model for cursor-based pagination.
        /// </param>
        /// <param name="data">
        /// The list of vector store files
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        public VectorStoreFileListResponse(
            global::G.CursorPaginationResponse pagination,
            global::System.Collections.Generic.IList<global::G.VectorStoreFile> data,
            string? @object)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileListResponse" /> class.
        /// </summary>
        public VectorStoreFileListResponse()
        {
        }
    }
}