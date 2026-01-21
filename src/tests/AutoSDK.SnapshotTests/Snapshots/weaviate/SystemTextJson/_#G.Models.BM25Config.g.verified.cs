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
        /// Default Value: 1.2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k1")]
        public float? K1 { get; set; }

        /// <summary>
        /// Calibrates term-weight scaling based on the document length<br/>
        /// Default Value: 0.75
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b")]
        public float? B { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BM25Config" /> class.
        /// </summary>
        /// <param name="k1">
        /// Calibrates term-weight scaling based on the term frequency within a document<br/>
        /// Default Value: 1.2
        /// </param>
        /// <param name="b">
        /// Calibrates term-weight scaling based on the document length<br/>
        /// Default Value: 0.75
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BM25Config(
            float? k1,
            float? b)
        {
            this.K1 = k1;
            this.B = b;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BM25Config" /> class.
        /// </summary>
        public BM25Config()
        {
        }
    }
}