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
        [global::Newtonsoft.Json.JsonProperty("currency_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurrencyCode { get; set; } = default!;

        /// <summary>
        /// The amount of the currency in the common denomination. For example, in USD this is cents.<br/>
        /// Example: 1050
        /// </summary>
        /// <example>1050</example>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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