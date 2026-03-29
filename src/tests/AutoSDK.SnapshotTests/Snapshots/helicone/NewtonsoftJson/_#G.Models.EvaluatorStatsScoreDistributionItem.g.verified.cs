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
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range", Required = global::Newtonsoft.Json.Required.Always)]
        public string Range { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStatsScoreDistributionItem" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="range"></param>
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