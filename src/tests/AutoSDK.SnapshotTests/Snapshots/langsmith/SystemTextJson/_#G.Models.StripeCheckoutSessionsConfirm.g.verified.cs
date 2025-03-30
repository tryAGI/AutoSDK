//HintName: G.Models.StripeCheckoutSessionsConfirm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeCheckoutSessionsConfirm
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripeSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCheckoutSessionsConfirm" /> class.
        /// </summary>
        /// <param name="stripeSessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeCheckoutSessionsConfirm(
            string stripeSessionId)
        {
            this.StripeSessionId = stripeSessionId ?? throw new global::System.ArgumentNullException(nameof(stripeSessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCheckoutSessionsConfirm" /> class.
        /// </summary>
        public StripeCheckoutSessionsConfirm()
        {
        }
    }
}