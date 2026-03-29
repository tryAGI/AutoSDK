//HintName: G.Models.SubscriptionLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionLimits
    {
        /// <summary>
        /// True if this call was blocked by the Call Concurrency limit<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyBlocked")]
        public bool? ConcurrencyBlocked { get; set; }

        /// <summary>
        /// Account Call Concurrency limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyLimit")]
        public double? ConcurrencyLimit { get; set; }

        /// <summary>
        /// Incremental number of concurrent calls that will be allowed, including this call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remainingConcurrentCalls")]
        public double? RemainingConcurrentCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLimits" /> class.
        /// </summary>
        /// <param name="concurrencyBlocked">
        /// True if this call was blocked by the Call Concurrency limit<br/>
        /// Default Value: false
        /// </param>
        /// <param name="concurrencyLimit">
        /// Account Call Concurrency limit
        /// </param>
        /// <param name="remainingConcurrentCalls">
        /// Incremental number of concurrent calls that will be allowed, including this call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionLimits(
            bool? concurrencyBlocked,
            double? concurrencyLimit,
            double? remainingConcurrentCalls)
        {
            this.ConcurrencyBlocked = concurrencyBlocked;
            this.ConcurrencyLimit = concurrencyLimit;
            this.RemainingConcurrentCalls = remainingConcurrentCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLimits" /> class.
        /// </summary>
        public SubscriptionLimits()
        {
        }
    }
}