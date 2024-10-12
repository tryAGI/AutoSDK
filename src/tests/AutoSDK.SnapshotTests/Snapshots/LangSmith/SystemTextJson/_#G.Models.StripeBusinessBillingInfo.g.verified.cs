//HintName: G.Models.StripeBusinessBillingInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe customer billing information.
    /// </summary>
    public sealed partial class StripeBusinessBillingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Stripe customer address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public global::G.StripeCustomerAddress? Address { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}