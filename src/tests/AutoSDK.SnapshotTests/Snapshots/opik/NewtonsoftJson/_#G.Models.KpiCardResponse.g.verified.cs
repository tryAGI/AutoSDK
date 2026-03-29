//HintName: G.Models.KpiCardResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KpiCardResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::System.Collections.Generic.IList<global::G.KpiMetric>? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiCardResponse" /> class.
        /// </summary>
        /// <param name="stats"></param>
        public KpiCardResponse(
            global::System.Collections.Generic.IList<global::G.KpiMetric>? stats)
        {
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiCardResponse" /> class.
        /// </summary>
        public KpiCardResponse()
        {
        }
    }
}