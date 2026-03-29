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
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSearches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumSearches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3CostDollars" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="numSearches"></param>
        /// <param name="numPages"></param>
        /// <param name="reasoningTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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