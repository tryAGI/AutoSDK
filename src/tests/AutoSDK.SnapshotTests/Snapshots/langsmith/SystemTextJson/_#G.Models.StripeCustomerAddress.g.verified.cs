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
        [global::System.Text.Json.Serialization.JsonPropertyName("line1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Line1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line2")]
        public string? Line2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postal_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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