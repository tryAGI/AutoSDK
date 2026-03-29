//HintName: G.Models.EvaluatorStatsScoreDistributionItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorStatsScoreDistributionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStatsScoreDistributionItem" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="range"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorStatsScoreDistributionItem(
            double count,
            string range)
        {
            this.Count = count;
            this.Range = range ?? throw new global::System.ArgumentNullException(nameof(range));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStatsScoreDistributionItem" /> class.
        /// </summary>
        public EvaluatorStatsScoreDistributionItem()
        {
        }
    }
}