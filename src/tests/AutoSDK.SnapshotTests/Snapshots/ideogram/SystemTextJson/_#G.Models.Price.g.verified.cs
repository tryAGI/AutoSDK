//HintName: G.Models.Price.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a price.
    /// </summary>
    public sealed partial class Price
    {
        /// <summary>
        /// The ISO 4217 currency code for the price object.<br/>
        /// Example: USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrencyCode { get; set; }

        /// <summary>
        /// The amount of the currency in the common denomination. For example, in USD this is cents.<br/>
        /// Example: 1050
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}