//HintName: G.Models.LocationResultPostalAddress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Postal address of the location.
    /// </summary>
    public sealed partial class LocationResultPostalAddress
    {
        /// <summary>
        /// Address type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Region/state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Postal/ZIP code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Street address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("street_address")]
        public string? StreetAddress { get; set; }

        /// <summary>
        /// Formatted display address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_address")]
        public string? DisplayAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultPostalAddress" /> class.
        /// </summary>
        /// <param name="type">
        /// Address type.
        /// </param>
        /// <param name="country">
        /// Country.
        /// </param>
        /// <param name="region">
        /// Region/state.
        /// </param>
        /// <param name="postalCode">
        /// Postal/ZIP code.
        /// </param>
        /// <param name="city">
        /// City.
        /// </param>
        /// <param name="streetAddress">
        /// Street address.
        /// </param>
        /// <param name="displayAddress">
        /// Formatted display address.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocationResultPostalAddress(
            string? type,
            string? country,
            string? region,
            string? postalCode,
            string? city,
            string? streetAddress,
            string? displayAddress)
        {
            this.Type = type;
            this.Country = country;
            this.Region = region;
            this.PostalCode = postalCode;
            this.City = city;
            this.StreetAddress = streetAddress;
            this.DisplayAddress = displayAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultPostalAddress" /> class.
        /// </summary>
        public LocationResultPostalAddress()
        {
        }
    }
}