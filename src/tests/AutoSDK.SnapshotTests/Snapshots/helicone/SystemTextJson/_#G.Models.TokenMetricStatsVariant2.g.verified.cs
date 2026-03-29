//HintName: G.Models.TokenMetricStatsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenMetricStatsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medianPer1000Tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MedianPer1000Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenMetricStatsVariant2" /> class.
        /// </summary>
        /// <param name="medianPer1000Tokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenMetricStatsVariant2(
            double medianPer1000Tokens)
        {
            this.MedianPer1000Tokens = medianPer1000Tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenMetricStatsVariant2" /> class.
        /// </summary>
        public TokenMetricStatsVariant2()
        {
        }
    }
}