//HintName: G.Models.CohortAggregatedResultTopRecommendation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortAggregatedResultTopRecommendation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResultTopRecommendation" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="count"></param>
        public CohortAggregatedResultTopRecommendation(
            string text,
            double count)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResultTopRecommendation" /> class.
        /// </summary>
        public CohortAggregatedResultTopRecommendation()
        {
        }
    }
}