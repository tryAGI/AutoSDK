//HintName: G.Models.WrappedStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WrappedStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalRequests", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topProviders", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WrappedStatsTopProvider> TopProviders { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topModels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WrappedStatsTopModel> TopModels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WrappedStatsTotalTokens TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mostExpensiveRequest")]
        public global::G.MostExpensiveRequest? MostExpensiveRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStats" /> class.
        /// </summary>
        /// <param name="totalRequests"></param>
        /// <param name="topProviders"></param>
        /// <param name="topModels"></param>
        /// <param name="totalTokens"></param>
        /// <param name="mostExpensiveRequest"></param>
        public WrappedStats(
            double totalRequests,
            global::System.Collections.Generic.IList<global::G.WrappedStatsTopProvider> topProviders,
            global::System.Collections.Generic.IList<global::G.WrappedStatsTopModel> topModels,
            global::G.WrappedStatsTotalTokens totalTokens,
            global::G.MostExpensiveRequest? mostExpensiveRequest)
        {
            this.TotalRequests = totalRequests;
            this.TopProviders = topProviders ?? throw new global::System.ArgumentNullException(nameof(topProviders));
            this.TopModels = topModels ?? throw new global::System.ArgumentNullException(nameof(topModels));
            this.TotalTokens = totalTokens ?? throw new global::System.ArgumentNullException(nameof(totalTokens));
            this.MostExpensiveRequest = mostExpensiveRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStats" /> class.
        /// </summary>
        public WrappedStats()
        {
        }
    }
}