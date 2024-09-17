//HintName: G.Models.Catalog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Catalog represents a catalog.
    /// </summary>
    public sealed partial class Catalog
    {
        /// <summary>
        /// The catalog id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        public string? CatalogId { get; set; }

        /// <summary>
        /// The catalog name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The catalog description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The creation time of the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// The last update time of the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// The owner/namespace of the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// The catalog tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The catalog converting pipelines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convertingPipelines")]
        public global::System.Collections.Generic.IList<string>? ConvertingPipelines { get; set; }

        /// <summary>
        /// The catalog splitting pipelines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splittingPipelines")]
        public global::System.Collections.Generic.IList<string>? SplittingPipelines { get; set; }

        /// <summary>
        /// The catalog embedding pipelines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddingPipelines")]
        public global::System.Collections.Generic.IList<string>? EmbeddingPipelines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downstreamApps")]
        public global::System.Collections.Generic.IList<string>? DownstreamApps { get; set; }

        /// <summary>
        /// The total files in catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFiles")]
        public long? TotalFiles { get; set; }

        /// <summary>
        /// The total tokens in catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// The current used storage in catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedStorage")]
        public string? UsedStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}