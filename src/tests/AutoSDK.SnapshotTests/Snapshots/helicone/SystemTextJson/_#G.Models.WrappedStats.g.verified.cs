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
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topProviders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WrappedStatsTopProvider> TopProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topModels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WrappedStatsTopModel> TopModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WrappedStatsTotalTokens TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mostExpensiveRequest")]
        public global::G.MostExpensiveRequest? MostExpensiveRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WrappedStats" /> class.
        /// </summary>
        /// <param name="totalRequests"></param>
        /// <param name="topProviders"></param>
        /// <param name="topModels"></param>
        /// <param name="totalTokens"></param>
        /// <param name="mostExpensiveRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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