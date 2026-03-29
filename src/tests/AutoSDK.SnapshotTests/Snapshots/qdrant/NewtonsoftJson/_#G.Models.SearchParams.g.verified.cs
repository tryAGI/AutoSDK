//HintName: G.Models.SearchParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional parameters of the search
    /// </summary>
    public sealed partial class SearchParams
    {
        /// <summary>
        /// Params relevant to HNSW index Size of the beam in a beam-search. Larger the value - more accurate the result, more time required for search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hnsw_ef")]
        public int? HnswEf { get; set; }

        /// <summary>
        /// Search without approximation. If set to true, search may run long but with exact results.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exact")]
        public bool? Exact { get; set; }

        /// <summary>
        /// Quantization params
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization")]
        public global::G.QuantizationSearchParams? Quantization { get; set; }

        /// <summary>
        /// If enabled, the engine will only perform search among indexed or small segments. Using this option prevents slow searches in case of delayed index, but does not guarantee that all uploaded vectors will be included in search results<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexed_only")]
        public bool? IndexedOnly { get; set; }

        /// <summary>
        /// ACORN search params
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("acorn")]
        public global::G.AcornSearchParams? Acorn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParams" /> class.
        /// </summary>
        /// <param name="hnswEf">
        /// Params relevant to HNSW index Size of the beam in a beam-search. Larger the value - more accurate the result, more time required for search.
        /// </param>
        /// <param name="exact">
        /// Search without approximation. If set to true, search may run long but with exact results.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="quantization">
        /// Quantization params
        /// </param>
        /// <param name="indexedOnly">
        /// If enabled, the engine will only perform search among indexed or small segments. Using this option prevents slow searches in case of delayed index, but does not guarantee that all uploaded vectors will be included in search results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="acorn">
        /// ACORN search params
        /// </param>
        public SearchParams(
            int? hnswEf,
            bool? exact,
            global::G.QuantizationSearchParams? quantization,
            bool? indexedOnly,
            global::G.AcornSearchParams? acorn)
        {
            this.HnswEf = hnswEf;
            this.Exact = exact;
            this.Quantization = quantization;
            this.IndexedOnly = indexedOnly;
            this.Acorn = acorn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParams" /> class.
        /// </summary>
        public SearchParams()
        {
        }
    }
}