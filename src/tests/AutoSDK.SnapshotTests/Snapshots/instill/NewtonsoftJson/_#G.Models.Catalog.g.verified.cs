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
        /// The catalog uid.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalogUid")]
        public string? CatalogUid { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="Catalog" /> class.
        /// </summary>
        /// <param name="catalogUid">
        /// The catalog uid.
        /// </param>
        /// <param name="catalogId">
        /// The catalog id.
        /// </param>
        /// <param name="name">
        /// The catalog name.
        /// </param>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="createTime">
        /// The creation time of the catalog.
        /// </param>
        /// <param name="updateTime">
        /// The last update time of the catalog.
        /// </param>
        /// <param name="ownerName">
        /// The owner/namespace of the catalog.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="convertingPipelines">
        /// The catalog converting pipelines.
        /// </param>
        /// <param name="splittingPipelines">
        /// The catalog splitting pipelines.
        /// </param>
        /// <param name="embeddingPipelines">
        /// The catalog embedding pipelines.
        /// </param>
        /// <param name="downstreamApps"></param>
        /// <param name="totalFiles">
        /// The total files in catalog.
        /// </param>
        /// <param name="totalTokens">
        /// The total tokens in catalog.
        /// </param>
        /// <param name="usedStorage">
        /// The current used storage in catalog.
        /// </param>
        public Catalog(
            string catalogId,
            string? catalogUid,
            string? name,
            string? description,
            string? createTime,
            string? updateTime,
            string? ownerName,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? convertingPipelines,
            global::System.Collections.Generic.IList<string>? splittingPipelines,
            global::System.Collections.Generic.IList<string>? embeddingPipelines,
            global::System.Collections.Generic.IList<string>? downstreamApps,
            long? totalFiles,
            long? totalTokens,
            string? usedStorage)
        {
            this.CatalogId = catalogId ?? throw new global::System.ArgumentNullException(nameof(catalogId));
            this.CatalogUid = catalogUid;
            this.Name = name;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.OwnerName = ownerName;
            this.Tags = tags;
            this.ConvertingPipelines = convertingPipelines;
            this.SplittingPipelines = splittingPipelines;
            this.EmbeddingPipelines = embeddingPipelines;
            this.DownstreamApps = downstreamApps;
            this.TotalFiles = totalFiles;
            this.TotalTokens = totalTokens;
            this.UsedStorage = usedStorage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Catalog" /> class.
        /// </summary>
        public Catalog()
        {
        }
    }
}