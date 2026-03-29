//HintName: G.Models.CostDollarsBreakDownItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostDollarsBreakDownItem
    {
        /// <summary>
        /// Cost of your search operations<br/>
        /// Example: 0.005
        /// </summary>
        /// <example>0.005</example>
        [global::Newtonsoft.Json.JsonProperty("search")]
        public float? Search { get; set; }

        /// <summary>
        /// Cost of your content operations<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public float? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakdown")]
        public global::G.CostDollarsBreakDownItemBreakdown? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsBreakDownItem" /> class.
        /// </summary>
        /// <param name="search">
        /// Cost of your search operations<br/>
        /// Example: 0.005
        /// </param>
        /// <param name="contents">
        /// Cost of your content operations<br/>
        /// Example: 0
        /// </param>
        /// <param name="breakdown"></param>
        public CostDollarsBreakDownItem(
            float? search,
            float? contents,
            global::G.CostDollarsBreakDownItemBreakdown? breakdown)
        {
            this.Search = search;
            this.Contents = contents;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsBreakDownItem" /> class.
        /// </summary>
        public CostDollarsBreakDownItem()
        {
        }
    }
}