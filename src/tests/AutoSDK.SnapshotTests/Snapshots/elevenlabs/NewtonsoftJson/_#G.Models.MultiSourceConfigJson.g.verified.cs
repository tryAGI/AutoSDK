//HintName: G.Models.MultiSourceConfigJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON-serializable multi-source retrieval configuration.<br/>
    /// This can be passed as JSON in tool configurations for full control.
    /// </summary>
    public sealed partial class MultiSourceConfigJson
    {
        /// <summary>
        /// List of source names to use (e.g., ['chunks', 'products'])
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_names")]
        public global::System.Collections.Generic.IList<string>? SourceNames { get; set; }

        /// <summary>
        /// Per-source parameter overrides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_overrides")]
        public global::System.Collections.Generic.IList<global::G.SourceConfigJson>? SourceOverrides { get; set; }

        /// <summary>
        /// How to merge results from multiple sources<br/>
        /// Default Value: rank_fusion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merging_strategy")]
        public global::G.MergingStrategy? MergingStrategy { get; set; }

        /// <summary>
        /// Final number of chunks after merging<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("final_top_k")]
        public int? FinalTopK { get; set; }

        /// <summary>
        /// Decompose complex queries<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_decomposition")]
        public bool? UseDecomposition { get; set; }

        /// <summary>
        /// LLM reformulates query<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_reformulation")]
        public bool? UseReformulation { get; set; }

        /// <summary>
        /// LLM generates answer vs raw chunks<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("synthesize_response")]
        public bool? SynthesizeResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSourceConfigJson" /> class.
        /// </summary>
        /// <param name="sourceNames">
        /// List of source names to use (e.g., ['chunks', 'products'])
        /// </param>
        /// <param name="sourceOverrides">
        /// Per-source parameter overrides
        /// </param>
        /// <param name="mergingStrategy">
        /// How to merge results from multiple sources<br/>
        /// Default Value: rank_fusion
        /// </param>
        /// <param name="finalTopK">
        /// Final number of chunks after merging<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="useDecomposition">
        /// Decompose complex queries<br/>
        /// Default Value: true
        /// </param>
        /// <param name="useReformulation">
        /// LLM reformulates query<br/>
        /// Default Value: true
        /// </param>
        /// <param name="synthesizeResponse">
        /// LLM generates answer vs raw chunks<br/>
        /// Default Value: true
        /// </param>
        public MultiSourceConfigJson(
            global::System.Collections.Generic.IList<string>? sourceNames,
            global::System.Collections.Generic.IList<global::G.SourceConfigJson>? sourceOverrides,
            global::G.MergingStrategy? mergingStrategy,
            int? finalTopK,
            bool? useDecomposition,
            bool? useReformulation,
            bool? synthesizeResponse)
        {
            this.SourceNames = sourceNames;
            this.SourceOverrides = sourceOverrides;
            this.MergingStrategy = mergingStrategy;
            this.FinalTopK = finalTopK;
            this.UseDecomposition = useDecomposition;
            this.UseReformulation = useReformulation;
            this.SynthesizeResponse = synthesizeResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSourceConfigJson" /> class.
        /// </summary>
        public MultiSourceConfigJson()
        {
        }
    }
}