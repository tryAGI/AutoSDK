//HintName: G.Models.CostDollars.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostDollars
    {
        /// <summary>
        /// Total dollar cost for your request<br/>
        /// Example: 0.005
        /// </summary>
        /// <example>0.005</example>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public float? Total { get; set; }

        /// <summary>
        /// Breakdown of costs by operation type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakDown")]
        public global::System.Collections.Generic.IList<global::G.CostDollarsBreakDownItem>? BreakDown { get; set; }

        /// <summary>
        /// Standard price per request for different operations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perRequestPrices")]
        public global::G.CostDollarsPerRequestPrices? PerRequestPrices { get; set; }

        /// <summary>
        /// Standard price per page for different content operations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("perPagePrices")]
        public global::G.CostDollarsPerPagePrices? PerPagePrices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollars" /> class.
        /// </summary>
        /// <param name="total">
        /// Total dollar cost for your request<br/>
        /// Example: 0.005
        /// </param>
        /// <param name="breakDown">
        /// Breakdown of costs by operation type
        /// </param>
        /// <param name="perRequestPrices">
        /// Standard price per request for different operations
        /// </param>
        /// <param name="perPagePrices">
        /// Standard price per page for different content operations
        /// </param>
        public CostDollars(
            float? total,
            global::System.Collections.Generic.IList<global::G.CostDollarsBreakDownItem>? breakDown,
            global::G.CostDollarsPerRequestPrices? perRequestPrices,
            global::G.CostDollarsPerPagePrices? perPagePrices)
        {
            this.Total = total;
            this.BreakDown = breakDown;
            this.PerRequestPrices = perRequestPrices;
            this.PerPagePrices = perPagePrices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollars" /> class.
        /// </summary>
        public CostDollars()
        {
        }
    }
}