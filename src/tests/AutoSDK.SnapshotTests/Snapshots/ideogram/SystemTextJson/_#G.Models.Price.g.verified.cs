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
        /// <example>USD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrencyCode { get; set; }

        /// <summary>
        /// The amount of the currency in the common denomination. For example, in USD this is cents.<br/>
        /// Example: 1050
        /// </summary>
        /// <example>1050</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        /// <param name="currencyCode">
        /// The ISO 4217 currency code for the price object.<br/>
        /// Example: USD
        /// </param>
        /// <param name="amount">
        /// The amount of the currency in the common denomination. For example, in USD this is cents.<br/>
        /// Example: 1050
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Price(
            string currencyCode,
            double amount)
        {
            this.CurrencyCode = currencyCode ?? throw new global::System.ArgumentNullException(nameof(currencyCode));
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        public Price()
        {
        }
    }
}