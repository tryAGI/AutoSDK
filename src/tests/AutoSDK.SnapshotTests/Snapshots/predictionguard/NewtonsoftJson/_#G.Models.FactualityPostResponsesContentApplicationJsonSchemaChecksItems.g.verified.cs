//HintName: G.Models.FactualityPostResponsesContentApplicationJsonSchemaChecksItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FactualityPostResponsesContentApplicationJsonSchemaChecksItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The factuality score.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualityPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="score">
        /// The factuality score.
        /// </param>
        public FactualityPostResponsesContentApplicationJsonSchemaChecksItems(
            int? index,
            double? score)
        {
            this.Index = index;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualityPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        public FactualityPostResponsesContentApplicationJsonSchemaChecksItems()
        {
        }
    }
}