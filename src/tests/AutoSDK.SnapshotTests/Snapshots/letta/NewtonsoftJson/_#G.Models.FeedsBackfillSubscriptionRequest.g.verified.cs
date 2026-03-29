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
        [global::Newtonsoft.Json.JsonProperty("from_sequence")]
        public double? FromSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_sequence")]
        public double? ToSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsBackfillSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="fromSequence"></param>
        /// <param name="toSequence"></param>
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