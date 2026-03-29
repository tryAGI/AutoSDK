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
        [global::Newtonsoft.Json.JsonProperty("next_offset")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LabelDistributionCountsRow> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totals", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LabelDistributionCountsTotals Totals { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelDistributionCountsResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="totals"></param>
        /// <param name="nextOffset">
        /// Next offset for pagination when using limit/offset mode; null when there are no more results or when filtering by explicit `choice_keys`.
        /// </param>
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