//HintName: G.Models.StripeCustomerAddress.g.cs

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
        public string? Line2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city", Required = global::Newtonsoft.Json.Required.Always)]
        public string City { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCustomerAddress" /> class.
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="line2"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="postalCode"></param>
        /// <param name="country"></param>
        public StripeCustomerAddress(
            string line1,
            string city,
            string postalCode,
            string country,
            string? line2,
            string? state)
        {
            this.Line1 = line1 ?? throw new global::System.ArgumentNullException(nameof(line1));
            this.City = city ?? throw new global::System.ArgumentNullException(nameof(city));
            this.PostalCode = postalCode ?? throw new global::System.ArgumentNullException(nameof(postalCode));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.Line2 = line2;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCustomerAddress" /> class.
        /// </summary>
        public StripeCustomerAddress()
        {
        }
    }
}