//HintName: G.Models.ResearchDtoClassVariant3CostDollars.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassVariant3CostDollars
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numSearches", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumSearches { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numPages", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumPages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoningTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double ReasoningTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3CostDollars" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="numSearches"></param>
        /// <param name="numPages"></param>
        /// <param name="reasoningTokens"></param>
        public ResearchDtoClassVariant3CostDollars(
            double total,
            double numSearches,
            double numPages,
            double reasoningTokens)
        {
            this.Total = total;
            this.NumSearches = numSearches;
            this.NumPages = numPages;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3CostDollars" /> class.
        /// </summary>
        public ResearchDtoClassVariant3CostDollars()
        {
        }
    }
}