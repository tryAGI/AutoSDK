//HintName: G.Models.ToxicityPostResponsesContentApplicationJsonSchemaChecksItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToxicityPostResponsesContentApplicationJsonSchemaChecksItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The toxicity score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToxicityPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="score">
        /// The toxicity score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToxicityPostResponsesContentApplicationJsonSchemaChecksItems(
            int? index,
            double? score)
        {
            this.Index = index;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToxicityPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        public ToxicityPostResponsesContentApplicationJsonSchemaChecksItems()
        {
        }
    }
}