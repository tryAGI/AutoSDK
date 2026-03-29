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
        [global::System.Text.Json.Serialization.JsonPropertyName("index_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexType { get; set; }

        /// <summary>
        /// The maximum degree of the node and applies only when index_type is set to __HNSW__.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("M")]
        public string? M { get; set; }

        /// <summary>
        /// The search scope. This applies only when **index_type** is set to **HNSW**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efConstruction")]
        public string? EfConstruction { get; set; }

        /// <summary>
        /// The number of cluster units. This applies to IVF-related index types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nlist")]
        public string? Nlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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