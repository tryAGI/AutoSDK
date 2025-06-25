//HintName: G.Models.ListNamespaceModelVersionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListNamespaceModelVersionsResponse contains a list of models.
    /// </summary>
    public sealed partial class ListNamespaceModelVersionsResponse
    {
        /// <summary>
        /// A list of model resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<global::G.ModelVersion>? Versions { get; set; }

        /// <summary>
        /// Total number of versions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// The requested page offset.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespaceModelVersionsResponse" /> class.
        /// </summary>
        /// <param name="versions">
        /// A list of model resources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of versions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="page">
        /// The requested page offset.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListNamespaceModelVersionsResponse(
            global::System.Collections.Generic.IList<global::G.ModelVersion>? versions,
            int? totalSize,
            int? pageSize,
            int? page)
        {
            this.Versions = versions;
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNamespaceModelVersionsResponse" /> class.
        /// </summary>
        public ListNamespaceModelVersionsResponse()
        {
        }
    }
}