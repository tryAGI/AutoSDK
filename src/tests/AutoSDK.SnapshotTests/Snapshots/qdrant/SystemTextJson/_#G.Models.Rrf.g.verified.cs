//HintName: G.Models.Rrf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for Reciprocal Rank Fusion
    /// </summary>
    public sealed partial class Rrf
    {
        /// <summary>
        /// K parameter for reciprocal rank fusion<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k")]
        public int? K { get; set; }

        /// <summary>
        /// Weights for each prefetch source. Higher weight gives more influence on the final ranking. If not specified, all prefetches are weighted equally. The number of weights should match the number of prefetches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        public global::System.Collections.Generic.IList<float>? Weights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rrf" /> class.
        /// </summary>
        /// <param name="k">
        /// K parameter for reciprocal rank fusion<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="weights">
        /// Weights for each prefetch source. Higher weight gives more influence on the final ranking. If not specified, all prefetches are weighted equally. The number of weights should match the number of prefetches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Rrf(
            int? k,
            global::System.Collections.Generic.IList<float>? weights)
        {
            this.K = k;
            this.Weights = weights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rrf" /> class.
        /// </summary>
        public Rrf()
        {
        }
    }
}