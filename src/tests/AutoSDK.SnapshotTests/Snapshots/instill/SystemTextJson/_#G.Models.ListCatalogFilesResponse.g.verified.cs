//HintName: G.Models.ListCatalogFilesResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCatalogFilesResponse
    {
        /// <summary>
        /// The list of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::G.File>? Files { get; set; }

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int TotalSize { get; set; }

        /// <summary>
        /// The requested page size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.ListCatalogFilesFilter>? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}