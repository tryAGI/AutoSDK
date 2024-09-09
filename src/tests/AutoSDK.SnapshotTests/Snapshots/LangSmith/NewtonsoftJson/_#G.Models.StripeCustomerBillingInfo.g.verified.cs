//HintName: G.Models.StripeCustomerBillingInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe customer billing information.
    /// </summary>
    public sealed partial class StripeCustomerBillingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Stripe customer address.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StripeCustomerAddress Address { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}