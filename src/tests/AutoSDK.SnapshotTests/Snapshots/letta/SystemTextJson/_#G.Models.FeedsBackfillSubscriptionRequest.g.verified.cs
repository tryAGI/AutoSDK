//HintName: G.Models.FeedsBackfillSubscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsBackfillSubscriptionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_sequence")]
        public double? FromSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_sequence")]
        public double? ToSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsBackfillSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="fromSequence"></param>
        /// <param name="toSequence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedsBackfillSubscriptionRequest(
            double? fromSequence,
            double? toSequence)
        {
            this.FromSequence = fromSequence;
            this.ToSequence = toSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsBackfillSubscriptionRequest" /> class.
        /// </summary>
        public FeedsBackfillSubscriptionRequest()
        {
        }
    }
}