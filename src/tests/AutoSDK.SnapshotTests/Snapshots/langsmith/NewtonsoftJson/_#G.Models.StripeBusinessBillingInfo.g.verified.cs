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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address")]
        public global::G.StripeCustomerAddress? Address { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessBillingInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public StripeBusinessBillingInfo(
            string name,
            global::G.StripeCustomerAddress? address)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Address = address;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessBillingInfo" /> class.
        /// </summary>
        public StripeBusinessBillingInfo()
        {
        }
    }
}