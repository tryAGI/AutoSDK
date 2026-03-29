//HintName: G.Models.SubscriptionPaymentLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionPaymentLinkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        public string? PlanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPaymentLinkRequest" /> class.
        /// </summary>
        /// <param name="planId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPaymentLinkRequest(
            string? planId)
        {
            this.PlanId = planId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPaymentLinkRequest" /> class.
        /// </summary>
        public SubscriptionPaymentLinkRequest()
        {
        }
    }
}