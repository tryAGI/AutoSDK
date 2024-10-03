//HintName: G.Models.BM25Config.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// tuning parameters for the BM25 algorithm
    /// </summary>
    public sealed partial class BM25Config
    {
        /// <summary>
        /// Calibrates term-weight scaling based on the term frequency within a document<br/>
        /// Default Value: 1.2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("k1")]
        public float? K1 { get; set; } = 1.2F;

        /// <summary>
        /// Calibrates term-weight scaling based on the document length<br/>
        /// Default Value: 0.75F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b")]
        public float? B { get; set; } = 0.75F;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}