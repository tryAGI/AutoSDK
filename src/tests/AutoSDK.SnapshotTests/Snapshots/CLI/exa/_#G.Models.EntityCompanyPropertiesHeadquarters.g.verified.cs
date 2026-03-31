//HintName: G.Models.EntityCompanyPropertiesHeadquarters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Company headquarters information.
    /// </summary>
    public sealed partial class EntityCompanyPropertiesHeadquarters
    {
        /// <summary>
        /// Street address.<br/>
        /// Example: 123 Main St
        /// </summary>
        /// <example>123 Main St</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// City name.<br/>
        /// Example: San Francisco
        /// </summary>
        /// <example>San Francisco</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Postal/ZIP code.<br/>
        /// Example: 94105
        /// </summary>
        /// <example>94105</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Full country name.<br/>
        /// Example: United States
        /// </summary>
        /// <example>United States</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesHeadquarters" /> class.
        /// </summary>
        /// <param name="address">
        /// Street address.<br/>
        /// Example: 123 Main St
        /// </param>
        /// <param name="city">
        /// City name.<br/>
        /// Example: San Francisco
        /// </param>
        /// <param name="postalCode">
        /// Postal/ZIP code.<br/>
        /// Example: 94105
        /// </param>
        /// <param name="country">
        /// Full country name.<br/>
        /// Example: United States
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntityCompanyPropertiesHeadquarters(
            string? address,
            string? city,
            string? postalCode,
            string? country)
        {
            this.Address = address;
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesHeadquarters" /> class.
        /// </summary>
        public EntityCompanyPropertiesHeadquarters()
        {
        }
    }
}