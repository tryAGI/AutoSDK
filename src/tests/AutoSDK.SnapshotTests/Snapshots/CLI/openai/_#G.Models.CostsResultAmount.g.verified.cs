﻿//HintName: G.Models.CostsResultAmount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The monetary value in its associated currency.
    /// </summary>
    public sealed partial class CostsResultAmount
    {
        /// <summary>
        /// The numeric value of the cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Lowercase ISO-4217 currency e.g. "usd"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostsResultAmount" /> class.
        /// </summary>
        /// <param name="value">
        /// The numeric value of the cost.
        /// </param>
        /// <param name="currency">
        /// Lowercase ISO-4217 currency e.g. "usd"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostsResultAmount(
            double? value,
            string? currency)
        {
            this.Value = value;
            this.Currency = currency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostsResultAmount" /> class.
        /// </summary>
        public CostsResultAmount()
        {
        }
    }
}