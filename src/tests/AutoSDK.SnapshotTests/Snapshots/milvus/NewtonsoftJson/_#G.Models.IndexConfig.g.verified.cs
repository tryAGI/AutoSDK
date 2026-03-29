//HintName: G.Models.IndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexConfig
    {
        /// <summary>
        /// The type of the index to create
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexType { get; set; } = default!;

        /// <summary>
        /// The maximum degree of the node and applies only when index_type is set to __HNSW__.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("M")]
        public string? M { get; set; }

        /// <summary>
        /// The search scope. This applies only when **index_type** is set to **HNSW**
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("efConstruction")]
        public string? EfConstruction { get; set; }

        /// <summary>
        /// The number of cluster units. This applies to IVF-related index types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nlist")]
        public string? Nlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexConfig" /> class.
        /// </summary>
        /// <param name="indexType">
        /// The type of the index to create
        /// </param>
        /// <param name="m">
        /// The maximum degree of the node and applies only when index_type is set to __HNSW__.
        /// </param>
        /// <param name="efConstruction">
        /// The search scope. This applies only when **index_type** is set to **HNSW**
        /// </param>
        /// <param name="nlist">
        /// The number of cluster units. This applies to IVF-related index types.
        /// </param>
        public IndexConfig(
            string indexType,
            string? m,
            string? efConstruction,
            string? nlist)
        {
            this.IndexType = indexType ?? throw new global::System.ArgumentNullException(nameof(indexType));
            this.M = m;
            this.EfConstruction = efConstruction;
            this.Nlist = nlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexConfig" /> class.
        /// </summary>
        public IndexConfig()
        {
        }
    }
}