//HintName: G.Models.BillingContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Billing context for LLM request cost tracking.
    /// </summary>
    public sealed partial class BillingContext
    {
        /// <summary>
        /// Subscription tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        public string? PlanType { get; set; }

        /// <summary>
        /// Cost source: 'quota' or 'credits'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_source")]
        public string? CostSource { get; set; }

        /// <summary>
        /// Customer ID for billing records
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingContext" /> class.
        /// </summary>
        /// <param name="planType">
        /// Subscription tier
        /// </param>
        /// <param name="costSource">
        /// Cost source: 'quota' or 'credits'
        /// </param>
        /// <param name="customerId">
        /// Customer ID for billing records
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingContext(
            string? planType,
            string? costSource,
            string? customerId)
        {
            this.PlanType = planType;
            this.CostSource = costSource;
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingContext" /> class.
        /// </summary>
        public BillingContext()
        {
        }
    }
}