//HintName: G.Models.StripeCustomerAddress.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe customer address.
    /// </summary>
    public sealed partial class StripeCustomerAddress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line1", Required = global::Newtonsoft.Json.Required.Always)]
        public string Line1 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line2")]
        public global::G.AnyOf<string, object>? Line2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city", Required = global::Newtonsoft.Json.Required.Always)]
        public string City { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.AnyOf<string, object>? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("postal_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string PostalCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country", Required = global::Newtonsoft.Json.Required.Always)]
        public string Country { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}