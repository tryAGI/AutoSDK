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
        [global::Newtonsoft.Json.JsonProperty("catalogId", Required = global::Newtonsoft.Json.Required.Always)]
        public string CatalogId { get; set; } = default!;

        /// <summary>
        /// The catalog name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The catalog description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The creation time of the catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// The last update time of the catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// The owner/namespace of the catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// The catalog tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The catalog converting pipelines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("convertingPipelines")]
        public global::System.Collections.Generic.IList<string>? ConvertingPipelines { get; set; }

        /// <summary>
        /// The catalog splitting pipelines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("splittingPipelines")]
        public global::System.Collections.Generic.IList<string>? SplittingPipelines { get; set; }

        /// <summary>
        /// The catalog embedding pipelines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddingPipelines")]
        public global::System.Collections.Generic.IList<string>? EmbeddingPipelines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("downstreamApps")]
        public global::System.Collections.Generic.IList<string>? DownstreamApps { get; set; }

        /// <summary>
        /// The total files in catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalFiles")]
        public long? TotalFiles { get; set; }

        /// <summary>
        /// The total tokens in catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens")]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// The current used storage in catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usedStorage")]
        public string? UsedStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Catalog? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Catalog>(
                json,
                jsonSerializerOptions);
        }

    }
}