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
        [global::Newtonsoft.Json.JsonProperty("stripe_session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StripeSessionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCheckoutSessionsConfirm" /> class.
        /// </summary>
        /// <param name="stripeSessionId"></param>
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