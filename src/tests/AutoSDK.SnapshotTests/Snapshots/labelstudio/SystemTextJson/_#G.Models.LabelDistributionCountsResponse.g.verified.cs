//HintName: G.Models.LabelDistributionCountsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelDistributionCountsResponse
    {
        /// <summary>
        /// Next offset for pagination when using limit/offset mode; null when there are no more results or when filtering by explicit `choice_keys`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_offset")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LabelDistributionCountsRow> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LabelDistributionCountsTotals Totals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionCountsResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="totals"></param>
        /// <param name="nextOffset">
        /// Next offset for pagination when using limit/offset mode; null when there are no more results or when filtering by explicit `choice_keys`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelDistributionCountsResponse(
            global::System.Collections.Generic.IList<global::G.LabelDistributionCountsRow> results,
            global::G.LabelDistributionCountsTotals totals,
            int? nextOffset)
        {
            this.NextOffset = nextOffset;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Totals = totals ?? throw new global::System.ArgumentNullException(nameof(totals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionCountsResponse" /> class.
        /// </summary>
        public LabelDistributionCountsResponse()
        {
        }
    }
}