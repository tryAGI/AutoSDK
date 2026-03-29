//HintName: G.Models.PGVectorHNSWSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// HNSW settings for PGVector.
    /// </summary>
    public sealed partial class PGVectorHNSWSettings
    {
        /// <summary>
        /// The number of edges to use during the construction phase.<br/>
        /// Default Value: 64
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ef_construction")]
        public int? EfConstruction { get; set; }

        /// <summary>
        /// The number of edges to use during the search phase.<br/>
        /// Default Value: 40
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ef_search")]
        public int? EfSearch { get; set; }

        /// <summary>
        /// The number of bi-directional links created for each new element.<br/>
        /// Default Value: 16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("m")]
        public int? M { get; set; }

        /// <summary>
        /// The type of vector to use.<br/>
        /// Default Value: vector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_type")]
        public global::G.PGVectorVectorType? VectorType { get; set; }

        /// <summary>
        /// The distance method to use.<br/>
        /// Default Value: cosine
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance_method")]
        public global::G.PGVectorDistanceMethod? DistanceMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PGVectorHNSWSettings" /> class.
        /// </summary>
        /// <param name="efConstruction">
        /// The number of edges to use during the construction phase.<br/>
        /// Default Value: 64
        /// </param>
        /// <param name="efSearch">
        /// The number of edges to use during the search phase.<br/>
        /// Default Value: 40
        /// </param>
        /// <param name="m">
        /// The number of bi-directional links created for each new element.<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="vectorType">
        /// The type of vector to use.<br/>
        /// Default Value: vector
        /// </param>
        /// <param name="distanceMethod">
        /// The distance method to use.<br/>
        /// Default Value: cosine
        /// </param>
        public PGVectorHNSWSettings(
            int? efConstruction,
            int? efSearch,
            int? m,
            global::G.PGVectorVectorType? vectorType,
            global::G.PGVectorDistanceMethod? distanceMethod)
        {
            this.EfConstruction = efConstruction;
            this.EfSearch = efSearch;
            this.M = m;
            this.VectorType = vectorType;
            this.DistanceMethod = distanceMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PGVectorHNSWSettings" /> class.
        /// </summary>
        public PGVectorHNSWSettings()
        {
        }
    }
}